﻿using Civilization1;
using Disassembler.MZ;
using IRB.Collections.Generic;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Disassembler
{
	public class CPU
	{
		// flags
		private CPUFlags oFlags = new CPUFlags();

		// registers
		private CPURegister oAX = new CPURegister();
		private CPURegister oBX = new CPURegister();
		private CPURegister oCX = new CPURegister();
		private CPURegister oDX = new CPURegister();
		private CPURegister oBP = new CPURegister();
		private CPURegister oSP = new CPURegister();
		private CPURegister oSI = new CPURegister();
		private CPURegister oDI = new CPURegister();
		private CPURegister oDS = new CPURegister();
		private CPURegister oES = new CPURegister();
		private CPURegister oSS = new CPURegister();
		private CPURegister oCS = new CPURegister();

		// temporary registers
		private CPURegister oTemp = new CPURegister();

		// memory
		private CPUMemory oMemory;

		// Timer(s)
		private bool bEnableInterrupt = true;
		private bool bEnableTimer = false;
		private bool bTimerFlag = false;
		private bool bInTimer = false;
		private Timer oTimer;

		// DOS file stuff
		private uint uiDOSDTA = 0;
		private int iFileCount = 0;
		private FileStream[] aFileHandles = new FileStream[256];

		private string sDefaultDirectory = "C:\\DOS\\CIV\\";
		private short sFileHandleCount = 0x20;
		private BDictionary<short, FileStreamItem> aOpenFiles = new BDictionary<short, FileStreamItem>();

		private Civilization oParent;
		private LogWrapper oLog;

		public CPU(Civilization parent, LogWrapper log)
		{
			this.oParent = parent;
			this.oLog = log;
			this.oMemory = new CPUMemory(this);
			this.oTimer = new Timer(oTimer_Tick, null, 100, 100);
			//this.oTimer.Dispose();
		}

		public Civilization Parent
		{
			get { return this.oParent; }
		}

		public LogWrapper Log
		{
			get { return this.oLog; }
			set { this.oLog = value; }
		}

		public bool EnableTimer
		{
			get { return this.bEnableTimer; }
			set { this.bEnableTimer = value; this.bTimerFlag = false; }
		}

		private void oTimer_Tick(object state)
		{
			if (this.bEnableTimer && !this.bTimerFlag)
			{
				this.bTimerFlag = true;
			}
		}

		public void STI()
		{
			this.bEnableInterrupt = true;
		}

		public void CLI()
		{
			this.bEnableInterrupt = false;
		}

		public void DoEvents()
		{
			System.Windows.Forms.Application.DoEvents();
			if (this.bEnableInterrupt && this.bEnableTimer && this.bTimerFlag && !this.bInTimer)
			{
				this.bInTimer = true;

				LogWrapper oLogTemp = this.oLog;
				this.oLog = this.oParent.InterruptLog;

				MainRegistersCheck registersCheck = new MainRegistersCheck(this);
				ushort usCS = this.oCS.Word;
				this.PushF();

				this.PushWord(0x0);
				this.PushWord(usCS);
				this.oParent.Segment_1000.F0_1000_01a7_Timer();
				this.PopDWord();

				this.PopF();
				this.oCS.Word = usCS;
				if (!registersCheck.CheckMainRegisters(this))
					throw new Exception("Return main registers doesn't match");

				this.oLog = oLogTemp;

				this.bTimerFlag = false;
				this.bInTimer = false;
			}
		}

		#region Flags & registers
		public CPUFlags Flags
		{
			get { return this.oFlags; }
		}

		public CPURegister AX
		{
			get { return this.oAX; }
		}

		public CPURegister BX
		{
			get { return this.oBX; }
		}

		public CPURegister CX
		{
			get { return this.oCX; }
		}

		public CPURegister DX
		{
			get { return this.oDX; }
		}

		public CPURegister BP
		{
			get { return this.oBP; }
		}

		public CPURegister SP
		{
			get { return this.oSP; }
		}

		public CPURegister SI
		{
			get { return this.oSI; }
		}

		public CPURegister DI
		{
			get { return this.oDI; }
		}

		public CPURegister DS
		{
			get { return this.oDS; }
		}

		public CPURegister ES
		{
			get { return this.oES; }
		}

		public CPURegister SS
		{
			get { return this.oSS; }
		}

		public CPURegister CS
		{
			get { return this.oCS; }
		}

		public CPURegister Temp
		{
			get { return this.oTemp; }
		}
		#endregion

		#region Helper functions
		public void DWordToWords(CPURegister regLow, CPURegister regHigh, uint value)
		{
			regLow.Word = (ushort)(value & 0xffff);
			regHigh.Word = (ushort)((value & 0xffff0000) >> 16);
		}

		public uint WordsToDWord(ushort lowValue, ushort highValue)
		{
			return ((uint)highValue << 16) | (uint)lowValue;
		}
		#endregion

		#region Memory
		public CPUMemory Memory
		{
			get { return this.oMemory; }
		}

		public byte ReadByte(ushort segment, ushort offset)
		{
			this.DoEvents();
			return this.oMemory.ReadByte(segment, offset);
		}

		public ushort ReadWord(ushort segment, ushort offset)
		{
			this.DoEvents();
			return this.oMemory.ReadWord(segment, offset);
		}

		public uint ReadDWord(ushort segment, ushort offset)
		{
			this.DoEvents();
			return this.oMemory.ReadDWord(segment, offset);
		}

		public void WriteByte(ushort segment, ushort offset, byte value)
		{
			this.DoEvents();
			this.oMemory.WriteByte(segment, offset, value);
		}

		public void WriteWord(ushort segment, ushort offset, ushort value)
		{
			this.DoEvents();
			this.oMemory.WriteWord(segment, offset, value);
		}

		public void WriteDWord(ushort segment, ushort offset, uint value)
		{
			this.DoEvents();
			this.oMemory.WriteDWord(segment, offset, value);
		}
		#endregion

		#region String instructions
		public string ReadString(uint address)
		{
			if (address == 0)
				return "";

			StringBuilder sb = new StringBuilder();
			byte ch;

			while ((ch = this.oMemory.ReadByte(address)) != 0)
			{
				sb.Append((char)ch);
				address++;
			}

			return sb.ToString();
		}

		public string ReadDosString(uint address)
		{
			if (address == 0)
				return "";

			StringBuilder sb = new StringBuilder();
			byte ch;

			while ((ch = this.oMemory.ReadByte(address)) != (byte)'$')
			{
				sb.Append((char)ch);
				address++;
			}

			return sb.ToString();
		}

		public void WriteString(uint address, string text, int maxLength)
		{
			if (address == 0)
				return;

			for (int i = 0; i < text.Length && i < maxLength; i++)
			{
				this.oMemory.WriteByte(address, (byte)text[i]);
				address++;
			}

			this.oMemory.WriteByte(address, 0);
		}
		#endregion

		#region File operations
		public string DefaultDirectory
		{
			get { return this.sDefaultDirectory; }
		}

		public short FileHandleCount
		{
			get { return this.sFileHandleCount; }
			set { this.sFileHandleCount = value; }
		}

		public BDictionary<short, FileStreamItem> Files
		{
			get { return this.aOpenFiles; }
		}
		#endregion

		#region CPU stack
		public void PushAWord(CPURegister regAX, CPURegister regCX, CPURegister regDX, CPURegister regBX,
			CPURegister regSI, CPURegister regDI)
		{
			ushort uiTemp = this.oSP.Word;
			this.PushWord(regAX.Word);
			this.PushWord(regCX.Word);
			this.PushWord(regDX.Word);
			this.PushWord(regBX.Word);
			this.PushWord(uiTemp);
			this.PushWord(this.oBP.Word);
			this.PushWord(regSI.Word);
			this.PushWord(regDI.Word);
		}

		public void PushF()
		{
			PushWord(this.oFlags.Value);
		}

		public void PushWord(ushort value)
		{
			if ((int)this.oSP.Word - 2 < 0)
			{
				throw new Exception("Stack overflow");
				//return;
			}
			this.oSP.Word -= 1;
			this.oMemory.WriteByte(this.oSS.Word, this.oSP.Word, (byte)((value & 0xff00) >> 8));
			this.oSP.Word -= 1;
			this.oMemory.WriteByte(this.oSS.Word, this.oSP.Word, (byte)(value & 0xff));
		}

		public void PushDWord(uint value)
		{
			if ((int)this.oSP.Word - 4 < 0)
			{
				throw new Exception("Stack overflow");
				//return;
			}
			this.oSP.Word -= 1;
			this.oMemory.WriteByte(this.oSS.Word, this.oSP.Word, (byte)((value & 0xff000000) >> 24));
			this.oSP.Word -= 1;
			this.oMemory.WriteByte(this.oSS.Word, this.oSP.Word, (byte)((value & 0xff0000) >> 16));
			this.oSP.Word -= 1;
			this.oMemory.WriteByte(this.oSS.Word, this.oSP.Word, (byte)((value & 0xff00) >> 8));
			this.oSP.Word -= 1;
			this.oMemory.WriteByte(this.oSS.Word, this.oSP.Word, (byte)(value & 0xff));
		}

		public void PopAWord(CPURegister regAX, CPURegister regCX, CPURegister regDX, CPURegister regBX,
			CPURegister regSI, CPURegister regDI)
		{
			regDI.Word = this.PopWord();
			regSI.Word = this.PopWord();
			this.oBP.Word = this.PopWord();
			this.PopWord();
			regBX.Word = this.PopWord();
			regDX.Word = this.PopWord();
			regCX.Word = this.PopWord();
			regAX.Word = this.PopWord();
		}

		public void PopF()
		{
			this.oFlags.Value = PopWord();
		}

		public ushort PopWord()
		{
			if ((int)this.oSP.Word + 2 >= 0x10000)
			{
				throw new Exception("Stack underflow");
				//return 0;
			}

			return (ushort)((ushort)this.oMemory.ReadByte(this.oSS.Word, this.oSP.Word++) |
				((ushort)this.oMemory.ReadByte(this.oSS.Word, this.oSP.Word++) << 8));
		}

		public uint PopDWord()
		{
			if ((int)this.oSP.Word + 4 >= 0x10000)
			{
				throw new Exception("Stack underflow");
				//return 0;
			}

			return (uint)(((uint)this.oMemory.ReadByte(this.oSS.Word, this.oSP.Word++)) |
				((uint)this.oMemory.ReadByte(this.oSS.Word, this.oSP.Word++) << 8) |
				((uint)this.oMemory.ReadByte(this.oSS.Word, this.oSP.Word++) << 16) |
				((uint)this.oMemory.ReadByte(this.oSS.Word, this.oSP.Word++) << 24));
		}
		#endregion

		#region CPU instructions
		public byte ADCByte(byte value1, byte value2)
		{
			byte bCFlag = (byte)((this.oFlags.C) ? 1 : 0);
			byte res = (byte)(value1 + value2 + bCFlag);
			// Modifies flags: AF CF OF PF SF ZF
			this.oFlags.C = (res < value1) || (bCFlag != 0 && (res == value1));
			this.oFlags.O = (((value1 ^ value2 ^ 0x80) & (res ^ value2)) & 0x80) != 0;
			this.oFlags.S = (res & 0x80) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public ushort ADCWord(ushort value1, ushort value2)
		{
			ushort bCFlag = (ushort)((this.oFlags.C) ? 1 : 0);
			ushort res = (ushort)(value1 + value2 + bCFlag);
			// Modifies flags: AF CF OF PF SF ZF
			this.oFlags.C = (res < value1) || (bCFlag != 0 && (res == value1));
			this.oFlags.O = (((value1 ^ value2 ^ 0x8000) & (res ^ value2)) & 0x8000) != 0;
			this.oFlags.S = (res & 0x8000) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public byte ADDByte(byte value1, byte value2)
		{
			byte res = (byte)(value1 + value2);
			// Modifies flags: AF CF OF PF SF ZF
			this.oFlags.C = (res < value1);
			this.oFlags.O = (((value1 ^ value2 ^ 0x80) & (res ^ value2)) & 0x80) != 0;
			this.oFlags.S = (res & 0x80) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public ushort ADDWord(ushort value1, ushort value2)
		{
			ushort res = (ushort)(value1 + value2);
			// Modifies flags: AF CF OF PF SF ZF
			this.oFlags.C = (res < value1);
			this.oFlags.O = (((value1 ^ value2 ^ 0x8000) & (res ^ value2)) & 0x8000) != 0;
			this.oFlags.S = (res & 0x8000) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public byte ANDByte(byte value1, byte value2)
		{
			byte res = (byte)(value1 & value2);
			// Modifies flags: CF OF PF SF ZF (AF undefined)
			this.oFlags.C = false;
			this.oFlags.O = false;
			this.oFlags.S = (res & 0x80) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public ushort ANDWord(ushort value1, ushort value2)
		{
			ushort res = (ushort)(value1 & value2);
			// Modifies flags: CF OF PF SF ZF (AF undefined)
			this.oFlags.C = false;
			this.oFlags.O = false;
			this.oFlags.S = (res & 0x8000) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public void CMPByte(byte value1, byte value2)
		{
			byte res = (byte)(value1 - value2);
			// Modifies flags: AF CF OF PF SF ZF
			this.oFlags.C = (value1 < value2);
			this.oFlags.O = (((value1 ^ value2) & (value1 ^ res)) & 0x80) != 0;
			this.oFlags.S = (res & 0x80) != 0;
			this.oFlags.Z = (res == 0);
		}

		public void CMPWord(ushort value1, ushort value2)
		{
			ushort res = (ushort)(value1 - value2);
			// Modifies flags: AF CF OF PF SF ZF
			this.oFlags.C = (value1 < value2);
			this.oFlags.O = (((value1 ^ value2) & (value1 ^ res)) & 0x8000) != 0;
			this.oFlags.S = (res & 0x8000) != 0;
			this.oFlags.Z = (res == 0);
		}

		public void CMPSByte(CPURegister regES, CPURegister regDI, CPURegister sReg, CPURegister regSI)
		{
			CMPByte(this.oMemory.ReadByte(regES.Word, regDI.Word), this.oMemory.ReadByte(sReg.Word, regSI.Word));

			if (this.oFlags.D)
			{
				this.oSI.Word--;
			}
			else
			{
				this.oSI.Word++;
			}
		}

		public void REPECMPSByte(CPURegister regES, CPURegister regDI, CPURegister sReg, CPURegister regSI)
		{
			while (this.oCX.Word != 0)
			{
				CMPSByte(regES, regDI, sReg, regSI);
				this.oCX.Word--;

				if (!this.oFlags.Z)
					break;
			}
		}

		public void CBW(CPURegister regAX)
		{
			if ((regAX.Low & 0x80) != 0)
				regAX.High = 0xff;
			else
				regAX.High = 0;
		}

		public void CWD(CPURegister regAX, CPURegister regDX)
		{
			if ((regAX.Word & 0x8000) != 0)
				regDX.Word = 0xffff;
			else
				regDX.Word = 0;
		}

		public void DAS()
		{
			byte osigned = (byte)(this.oAX.Low & 0x80);
			if (((this.oAX.Low & 0x0f) > 9))
			{
				if ((this.oAX.Low > 0x99) || this.oFlags.C)
				{
					this.oAX.Low -= 0x60;
					this.oFlags.C = true;
				}
				else
				{
					this.oFlags.C = this.oAX.Low <= 0x05;
				}
				this.oAX.Low -= 6;
			}
			else
			{
				if ((this.oAX.Low > 0x99) || this.oFlags.C)
				{
					this.oAX.Low -= 0x60;
					this.oFlags.C = true;
				}
				else
				{
					this.oFlags.C = false;
				}
			}
			this.oFlags.O = osigned != 0 && (this.oAX.Low & 0x80) == 0;
			this.oFlags.S = (this.oAX.Low & 0x80) != 0;
			this.oFlags.Z = this.oAX.Low == 0;
		}

		public byte DECByte(byte value1)
		{
			byte res = (byte)(value1 - 1);
			// Modifies flags: AF OF PF SF ZF
			this.oFlags.O = (res == 0x7f);
			this.oFlags.S = (res & 0x80) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public ushort DECWord(ushort value1)
		{
			ushort res = (ushort)(value1 - 1);
			// Modifies flags: AF OF PF SF ZF
			this.oFlags.O = (res == 0x7fff);
			this.oFlags.S = (res & 0x8000) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public void DIVWord(CPURegister regAX, CPURegister regDX, ushort value)
		{
			if (value == 0)
				throw new Exception("Division by zero");
			uint num = ((uint)regDX.Word << 16) | (uint)regAX.Word;
			uint quo = num / value;
			ushort rem = (ushort)(num % value);
			ushort quo16 = (ushort)(quo & 0xffff);
			if (quo != quo16)
				throw new Exception("Division error");
			regDX.Word = rem;
			regAX.Word = quo16;
		}

		public void IDIVByte(CPURegister regAX, byte value)
		{
			if (value == 0)
				throw new Exception("Division by zero");
			short valuea = (sbyte)value;
			short num = (short)regAX.Word;
			short quo = (short)(num / valuea);
			sbyte rem = (sbyte)(num % valuea);
			byte quo8 = (byte)((ushort)quo & 0xff);
			if (quo != quo8)
				throw new Exception("Division error");
			regAX.High = (byte)rem;
			regAX.Low = quo8;
		}

		public void IDIVWord(CPURegister regAX, CPURegister regDX, ushort value)
		{
			if (value == 0)
				throw new Exception("Division by zero");
			int valuea = (short)value;
			int num = (int)(((uint)regDX.Word << 16) | (uint)regAX.Word);
			int quo = num / valuea;
			short rem = (short)(num % valuea);
			ushort quo16 = (ushort)((uint)quo & 0xffff);
			if (quo != quo16)
				throw new Exception("Division error");
			regDX.Word = (ushort)rem;
			regAX.Word = quo16;
		}

		public void IMULByte(CPURegister regAX, byte value1)
		{
			ushort res = (ushort)((short)((sbyte)regAX.Low) * (short)((sbyte)value1));
			regAX.Word = res;

			if ((res & 0xff80) == 0xff80 || (res & 0xff80) == 0x0)
			{
				this.oFlags.C = false;
				this.oFlags.O = false;
			}
			else
			{
				this.oFlags.C = true;
				this.oFlags.O = true;
			}
		}

		public void IMULWord(CPURegister regAX, CPURegister regDX, ushort value1)
		{
			uint res = (uint)((int)((short)regAX.Word) * (int)((short)value1));
			regAX.Word = (ushort)(res & 0xffff);
			regDX.Word = (ushort)((res & 0xffff0000) >> 16);

			if ((res & 0xffff8000) == 0xffff8000 || (res & 0xffff8000) == 0x0)
			{
				this.oFlags.C = false;
				this.oFlags.O = false;
			}
			else
			{
				this.oFlags.C = true;
				this.oFlags.O = true;
			}
		}

		public ushort IMUL1Word(ushort value1, ushort value2)
		{
			uint res = (uint)((uint)value1 * (uint)value2);

			if ((res & 0xffff8000) == 0xffff8000 || (res & 0xffff8000) == 0x0)
			{
				this.oFlags.C = false;
				this.oFlags.O = false;
			}
			else
			{
				this.oFlags.C = true;
				this.oFlags.O = true;
			}

			return (ushort)(res & 0xffff);
		}

		public byte INCByte(byte value1)
		{
			byte res = (byte)(value1 + 1);
			// Modifies flags: AF OF PF SF ZF
			this.oFlags.O = (res == 0x80);
			this.oFlags.S = (res & 0x80) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public ushort INCWord(ushort value1)
		{
			ushort res = (ushort)(value1 + 1);
			// Modifies flags: AF OF PF SF ZF
			this.oFlags.O = (res == 0x8000);
			this.oFlags.S = (res & 0x8000) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public bool Loop(CPURegister regCX)
		{
			regCX.Word--;

			return regCX.Word != 0;
		}

		/// <summary>
		/// LODS - Load String (Byte, Word or Double) from DS:SI
		/// </summary>
		public void LODSByte()
		{
			this.oAX.Low = oMemory.ReadByte(this.oDS.Word, this.oSI.Word);

			// Modifies flags: None
			if (this.oFlags.D)
			{
				this.oSI.Word--;
			}
			else
			{
				this.oSI.Word++;
			}
		}

		/// <summary>
		/// LODS - Load String (Byte, Word or Double) from DS:SI
		/// </summary>
		public void LODSWord()
		{
			this.oAX.Word = oMemory.ReadWord(this.oDS.Word, this.oSI.Word);

			// Modifies flags: None
			if (this.oFlags.D)
			{
				this.oSI.Word -= 2;
			}
			else
			{
				this.oSI.Word += 2;
			}
		}

		public ushort MOVSXWord(ushort value1)
		{
			value1 &= 0xff;
			if ((value1 & 0x80) != 0)
				return (ushort)(0xff00 | value1);

			return value1;
		}

		public uint MOVSXDWord(uint value1)
		{
			value1 &= 0xffff;
			if ((value1 & 0x8000) != 0)
				return 0xffff0000 | value1;

			return value1;
		}

		public ushort MOVZXWord(ushort value1)
		{
			return (ushort)(value1 & 0xff);
		}

		public uint MOVZXDWord(uint value1)
		{
			return value1 & 0xffff;
		}

		/// <summary>
		/// MOVS - Move String (Byte or Word) ES:DI = DS:SI
		/// </summary>
		public void MOVSByte(CPURegister sReg, CPURegister regSI, CPURegister regES, CPURegister regDI)
		{
			byte res = oMemory.ReadByte(sReg.Word, regSI.Word);
			oMemory.WriteByte(regES.Word, regDI.Word, res);
			// Modifies flags: None
			if (this.oFlags.D)
			{
				regSI.Word--;
				regDI.Word--;
			}
			else
			{
				regSI.Word++;
				regDI.Word++;
			}
		}

		/// <summary>
		/// MOVS - Move String (Byte or Word) ES:DI = DS:SI
		/// </summary>
		public void REPEMOVSByte(CPURegister sReg, CPURegister regSI, CPURegister regES, CPURegister regDI, CPURegister regCX)
		{
			while (regCX.Word != 0)
			{
				MOVSByte(sReg, regSI, regES, regDI);

				regCX.Word--;
			}
		}

		/// <summary>
		/// MOVS - Move String (Byte or Word) ES:DI = DS:SI
		/// </summary>
		public void MOVSWord(CPURegister sReg, CPURegister regSI, CPURegister regES, CPURegister regDI)
		{
			oMemory.WriteWord(regES.Word, regDI.Word, oMemory.ReadWord(sReg.Word, regSI.Word));
			// Modifies flags: None
			if (this.oFlags.D)
			{
				regSI.Word -= 2;
				regDI.Word -= 2;
			}
			else
			{
				regSI.Word += 2;
				regDI.Word += 2;
			}
		}

		/// <summary>
		/// MOVS - Move String (Byte or Word) ES:DI = DS:SI
		/// </summary>
		public void REPEMOVSWord(CPURegister sReg, CPURegister regSI, CPURegister regES, CPURegister regDI, CPURegister regCX)
		{
			while (regCX.Word != 0)
			{
				MOVSWord(sReg, regSI, regES, regDI);

				regCX.Word--;
			}
		}

		public void MULByte(CPURegister regAX, byte value)
		{
			regAX.Word = (ushort)((ushort)regAX.Low * (ushort)value);
			oFlags.Z = regAX.Low == 0;
			if (regAX.High != 0)
			{
				oFlags.C = true;
				oFlags.O = true;
			}
			else
			{
				oFlags.C = false;
				oFlags.O = false;
			}
		}

		public void MULWord(CPURegister regDX, CPURegister regAX, ushort value)
		{
			uint tempu = (uint)regAX.Word * (uint)value;
			regAX.Word = (ushort)(tempu & 0xfffful);
			regDX.Word = (ushort)((tempu & 0xffff0000ul) >> 16);
			oFlags.Z = regAX.Word == 0;
			if (regDX.Word != 0)
			{
				oFlags.C = true;
				oFlags.O = true;
			}
			else
			{
				oFlags.C = false;
				oFlags.O = false;
			}
		}

		public byte NEGByte(byte value1)
		{
			byte res = (byte)(((ushort)0x100 - (ushort)value1) & 0xff);

			this.oFlags.C = value1 != 0;
			this.oFlags.Z = res == 0;
			this.oFlags.S = (value1 & 0x80) != 0;
			this.oFlags.O = (value1 == 0x80);

			return res;
		}

		public ushort NEGWord(ushort value1)
		{
			ushort res = (ushort)(((uint)0x10000 - (uint)value1) & 0xffff);

			this.oFlags.C = value1 != 0;
			this.oFlags.Z = res == 0;
			this.oFlags.S = (value1 & 0x8000) != 0;
			this.oFlags.O = (value1 == 0x8000);

			return res;
		}

		public byte NOTByte(byte value1)
		{
			byte res = (byte)(~value1);
			// Modifies flags: None

			return res;
		}

		public ushort NOTWord(ushort value1)
		{
			ushort res = (ushort)(~value1);
			// Modifies flags: None

			return res;
		}

		public byte ORByte(byte value1, byte value2)
		{
			byte res = (byte)(value1 | value2);
			// Modifies flags: CF OF PF SF ZF (AF undefined)
			this.oFlags.C = false;
			this.oFlags.O = false;
			this.oFlags.S = (res & 0x80) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public ushort ORWord(ushort value1, ushort value2)
		{
			ushort res = (ushort)(value1 | value2);
			// Modifies flags: CF OF PF SF ZF (AF undefined)
			this.oFlags.C = false;
			this.oFlags.O = false;
			this.oFlags.S = (res & 0x8000) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public byte RCLByte(byte value1, byte value2)
		{
			if ((value2 % 9) == 0) return value1;
			value2 %= 9;
			byte cf = (byte)((oFlags.C) ? 1 : 0);
			byte res = (byte)((value1 << value2) |
				(cf << (value2 - 1)) |
				(value1 >> (9 - value2)));
			oFlags.O = ((oFlags.C ? 1 : 0) ^ (res >> 7)) != 0;
			oFlags.C = (((value1 >> (8 - value2)) & 1)) != 0;

			return res;
		}

		public ushort RCLWord(ushort value1, byte value2)
		{
			if ((value2 % 17) == 0) return value1;
			value2 %= 17;
			ushort cf = (ushort)((oFlags.C) ? 1 : 0);
			ushort res = (ushort)((value1 << value2) |
				(cf << (value2 - 1)) |
				(value1 >> (17 - value2)));
			oFlags.O = ((oFlags.C ? 1 : 0) ^ (res >> 15)) != 0;
			oFlags.C = (((value1 >> (16 - value2)) & 1)) != 0;

			return res;
		}

		public byte RCRByte(byte value1, byte value2)
		{
			if ((value2 % 9) == 0) return value1;
			value2 %= 9;
			byte cf = (oFlags.C) ? (byte)1 : (byte)0;
			byte res = (byte)((value1 >> value2) |
				(cf << (8 - value2)) |
				(value1 << (9 - value2)));

			this.oFlags.C = ((value1 >> (value2 - 1)) & 1) != 0;
			this.oFlags.O = ((res ^ (res << 1)) & 0x80) != 0;

			return res;
		}

		public ushort RCRWord(ushort value1, ushort value2)
		{
			if ((value2 % 17) == 0) return value1;
			value2 %= 17;
			ushort cf = (oFlags.C) ? (ushort)1 : (ushort)0;
			ushort res = (ushort)((value1 >> value2) |
				(cf << (16 - value2)) |
				(value1 << (17 - value2)));

			this.oFlags.C = ((value1 >> (value2 - 1)) & 1) != 0;
			this.oFlags.O = ((res ^ (res << 1)) & 0x8000) != 0;

			return res;
		}

		public byte ROLByte(byte value1, byte value2)
		{
			if ((value2 & 0x7) == 0)
			{
				if ((value2 & 0x18) != 0)
				{
					oFlags.C = (value1 & 1) != 0;
					oFlags.O = ((value1 & 1) ^ (value1 >> 7)) != 0;
				}
				return value1;
			}
			value2 &= 0x7;
			byte res = (byte)((value1 << value2) | (value1 >> (8 - value2)));
			oFlags.C = (res & 1) != 0;
			oFlags.O = ((res & 1) ^ (res >> 7)) != 0;

			return res;
		}

		public ushort ROLWord(ushort value1, byte value2)
		{
			if ((value2 & 0xf) == 0)
			{
				if ((value2 & 0x10) != 0)
				{
					oFlags.C = (value1 & 1) != 0;
					oFlags.O = ((value1 & 1) ^ (value1 >> 15)) != 0;
				}
				return value1;
			}
			value2 &= 0xf;
			ushort res = (ushort)((value1 << value2) | (value1 >> (16 - value2)));
			oFlags.C = (res & 1) != 0;
			oFlags.O = ((res & 1) ^ (res >> 15)) != 0;

			return res;
		}

		public byte RORByte(byte value1, byte value2)
		{
			if ((value2 & 0x7) == 0)
			{
				if ((value2 & 0x18) != 0)
				{
					oFlags.C = (value1 >> 7) != 0;
					oFlags.O = ((value1 >> 7) ^ ((value1 >> 6) & 0x1)) != 0;
				}
				return value1;
			}
			value2 &= 0x7;
			byte res = (byte)((value1 >> value2) | (value1 << (8 - value2)));
			oFlags.C = (res & 0x80) != 0;
			oFlags.O = ((res ^ (res << 1)) & 0x80) != 0;

			return res;
		}

		public ushort RORWord(ushort value1, byte value2)
		{
			if ((value2 & 0xf) == 0)
			{
				if ((value2 & 0x10) != 0)
				{
					oFlags.C = (value1 >> 15) != 0;
					oFlags.O = ((value1 >> 15) ^ ((value1 >> 14) & 0x1)) != 0;
				}
				return value1;
			}
			value2 &= 0xf;
			ushort res = (ushort)((value1 >> value2) | (value1 << (16 - value2)));
			oFlags.C = (res & 0x8000) != 0;
			oFlags.O = ((res ^ (res << 1)) & 0x8000) != 0;

			return res;
		}

		public byte SARByte(byte value1, byte value2)
		{
			byte res;

			if (value2 == 0)
				return value1;

			if (value2 > 8) value2 = 8;
			if ((value1 & 0x80) != 0)
			{
				res = (byte)((value1 >> value2) | (0xff << (8 - value2)));
			}
			else
			{
				res = (byte)(value1 >> value2);
			}
			this.oFlags.C = (((byte)(value1) >> (value2 - 1)) & 1) != 0;
			this.oFlags.Z = (res == 0);
			this.oFlags.S = (res & 0x80) != 0;
			this.oFlags.O = false;

			return res;
		}

		public ushort SARWord(ushort value1, byte value2)
		{
			ushort res;

			if (value2 == 0)
				return value1;

			if (value2 > 16) value2 = 16;
			if ((value1 & 0x8000) != 0)
			{
				res = (ushort)((value1 >> value2) | (0xffff << (16 - value2)));
			}
			else
			{
				res = (ushort)(value1 >> value2);
			}
			this.oFlags.C = (((ushort)(value1) >> (value2 - 1)) & 1) != 0;
			this.oFlags.Z = (res == 0);
			this.oFlags.S = (res & 0x8000) != 0;
			this.oFlags.O = false;

			return res;
		}

		public byte SBBByte(byte value1, byte value2)
		{
			byte bCFlag = (byte)((this.oFlags.C) ? 1 : 0);
			byte res = (byte)(value1 - (value2 + bCFlag));

			// Modifies flags: AF CF OF PF SF ZF
			this.oFlags.C = (value1 < res) || (this.oFlags.C && (value2 == 0xff));
			this.oFlags.O = (((value1 ^ value2) & (value1 ^ res)) & 0x80) != 0;
			this.oFlags.S = (res & 0x80) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public ushort SBBWord(ushort value1, ushort value2)
		{
			ushort bCFlag = (ushort)((this.oFlags.C) ? 1 : 0);
			ushort res = (ushort)(value1 - (value2 + bCFlag));

			// Modifies flags: AF CF OF PF SF ZF
			this.oFlags.C = (value1 < res) || (this.oFlags.C && (value2 == 0xffff));
			this.oFlags.O = (((value1 ^ value2) & (value1 ^ res)) & 0x8000) != 0;
			this.oFlags.S = (res & 0x8000) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public void SCASByte()
		{
			CMPByte(this.oAX.Low, oMemory.ReadByte(this.oES.Word, this.oDI.Word));
			if (this.oFlags.D)
			{
				this.oDI.Word--;
			}
			else
			{
				this.oDI.Word++;
			}
		}

		public void REPNESCASByte()
		{
			while (this.oCX.Word != 0)
			{
				CMPByte(this.oAX.Low, oMemory.ReadByte(this.oES.Word, this.oDI.Word));
				if (this.oFlags.D)
				{
					this.oDI.Word--;
				}
				else
				{
					this.oDI.Word++;
				}
				this.oCX.Word--;

				if (this.oFlags.Z)
					break;
			}
		}

		public byte SHLByte(byte value1, byte value2)
		{
			if (value2 == 0)
				return value1;

			byte res = (byte)(value1 << value2);
			// Modifies flags: CF OF PF SF ZF (AF undefined)
			this.oFlags.C = (value2 > 8) ? false : ((value1 >> (8 - value2)) & 1) != 0;
			this.oFlags.O = ((res ^ value1) & 0x80) != 0;
			this.oFlags.S = (res & 0x80) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public ushort SHLWord(ushort value1, byte value2)
		{
			if (value2 == 0)
				return value1;

			ushort res = (ushort)(value1 << value2);
			// Modifies flags: CF OF PF SF ZF (AF undefined)
			this.oFlags.C = (value2 > 16) ? false : ((value1 >> (16 - value2)) & 1) != 0;
			this.oFlags.O = ((res ^ value1) & 0x8000) != 0;
			this.oFlags.S = (res & 0x8000) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public ushort SHLD1Word(ushort value1, ushort value2, byte value3)
		{
			if (value3 == 0)
				return value1;

			uint res = (uint)((uint)value1 << value3) | (uint)(value2 & ((uint)Math.Pow(2.0, value3) - 1));

			// Modifies flags: SF, ZF, PF, CF (AF, OF undefined)
			this.oFlags.C = (res & 0x10000) != 0;
			this.oFlags.S = (res & 0x8000) != 0;
			this.oFlags.Z = (res & 0xffff) == 0;

			return (ushort)(res & 0xffff);
		}

		public byte SHRByte(byte value1, byte value2)
		{
			if (value2 == 0)
				return value1;

			byte res = (byte)(value1 >> value2);
			// Modifies flags: CF OF PF SF ZF (AF undefined)
			this.oFlags.C = (value2 > 8) ? false : ((value1 >> (value2 - 1)) & 1) != 0;
			this.oFlags.O = ((value2 & 0x1f) == 1) ? (value1 > 0x80) : false;
			this.oFlags.S = (res & 0x80) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public ushort SHRWord(ushort value1, byte value2)
		{
			if (value2 == 0)
				return value1;

			ushort res = (ushort)(value1 >> value2);
			// Modifies flags: CF OF PF SF ZF (AF undefined)
			this.oFlags.C = (value2 > 16) ? false : ((value1 >> (value2 - 1)) & 1) != 0;
			this.oFlags.O = ((value2 & 0x1f) == 1) ? (value1 > 0x8000) : false;
			this.oFlags.S = (res & 0x8000) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		/// <summary>
		/// STOS - Store String (Byte, Word or Doubleword) to ES:DI
		/// </summary>
		public void STOSByte()
		{
			oMemory.WriteByte(this.oES.Word, this.oDI.Word, this.oAX.Low);
			// Modifies flags: None
			if (this.oFlags.D)
			{
				this.oDI.Word--;
			}
			else
			{
				this.oDI.Word++;
			}
		}

		/// <summary>
		/// STOS - Store String (Byte, Word or Doubleword) to ES:DI
		/// </summary>
		public void REPESTOSByte()
		{
			while (this.oCX.Word != 0)
			{
				STOSByte();
				this.oCX.Word--;
			}
		}

		/// <summary>
		/// STOS - Store String (Byte, Word or Doubleword) to ES:DI
		/// </summary>
		public void STOSWord()
		{
			oMemory.WriteWord(this.oES.Word, this.oDI.Word, this.oAX.Word);
			// Modifies flags: None
			if (this.oFlags.D)
			{
				this.oDI.Word -= 2;
			}
			else
			{
				this.oDI.Word += 2;
			}
		}

		/// <summary>
		/// STOS - Store String (Byte, Word or Doubleword) to ES:DI
		/// </summary>
		public void REPESTOSWord()
		{
			while (this.oCX.Word != 0)
			{
				STOSWord();
				this.oCX.Word--;
			}
		}

		public byte SUBByte(byte value1, byte value2)
		{
			byte res = (byte)(value1 - value2);
			// Modifies flags: AF CF OF PF SF ZF
			this.oFlags.C = (value1 < value2);
			this.oFlags.O = (((value1 ^ value2) & (value1 ^ res)) & 0x80) != 0;
			this.oFlags.S = (res & 0x80) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public ushort SUBWord(ushort value1, ushort value2)
		{
			ushort res = (ushort)(value1 - value2);
			// Modifies flags: AF CF OF PF SF ZF
			this.oFlags.C = (value1 < value2);
			this.oFlags.O = (((value1 ^ value2) & (value1 ^ res)) & 0x8000) != 0;
			this.oFlags.S = (res & 0x8000) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public void TESTByte(byte value1, byte value2)
		{
			byte res = (byte)(value1 & value2);
			// Modifies flags: CF OF PF SF ZF (AF undefined)
			this.oFlags.C = false;
			this.oFlags.O = false;
			this.oFlags.S = (res & 0x80) != 0;
			this.oFlags.Z = (res == 0);
		}

		public void TESTWord(ushort value1, ushort value2)
		{
			ushort res = (ushort)(value1 & value2);
			// Modifies flags: CF OF PF SF ZF (AF undefined)
			this.oFlags.C = false;
			this.oFlags.O = false;
			this.oFlags.S = (res & 0x8000) != 0;
			this.oFlags.Z = (res == 0);
		}

		public void XLAT(CPURegister regAX, CPURegister sReg, CPURegister regBX)
		{
			regAX.Low = this.oMemory.ReadByte(sReg.Word, (ushort)(regBX.Word + regAX.Low));
		}

		public byte XORByte(byte value1, byte value2)
		{
			byte res = (byte)(value1 ^ value2);
			// Modifies flags: CF OF PF SF ZF (AF undefined)
			this.oFlags.C = false;
			this.oFlags.O = false;
			this.oFlags.S = (res & 0x80) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}

		public ushort XORWord(ushort value1, ushort value2)
		{
			ushort res = (ushort)(value1 ^ value2);
			// Modifies flags: CF OF PF SF ZF (AF undefined)
			this.oFlags.C = false;
			this.oFlags.O = false;
			this.oFlags.S = (res & 0x8000) != 0;
			this.oFlags.Z = (res == 0);

			return res;
		}
		#endregion

		#region IO instructions
		public byte INByte(ushort port)
		{
			switch (port)
			{
				case 0x40:
					// 8253 or 8254 Programmable Interval Timer
					break;

				case 0x61:
					// 8255 Port B output - reset keyboard
					break;

				/*case 0x3c7:
					// DAC Status
					return this.oGPU.DACReadAddress;

				case 0x3c8:
					// DAC Palette Address, write
					return this.oGPU.DACWriteAddress;

				case 0x3c9:
					// DAC Palette Data
					return this.oGPU.DACPalette;

				case 0x3d5:
					// CRT Controller data, read
					this.oLog.WriteLine($"Input byte from port 0x{port:x4} (CRT Controller data, read)");
					break;

				case 0x3da:
					// Status Register
					return this.oGPU.HWStatus;*/

				default:
					this.oLog.WriteLine($"Input byte from port 0x{port:x4}");
					break;
			}

			return 0;
		}

		public void OUTByte(byte port, byte value)
		{
			this.OUTByte((ushort)port, value);
		}

		public void OUTByte(ushort port, byte value)
		{
			//this.oLog.WriteLine($"Output to port 0x{port:x4}, byte value 0x{value:x2}");

			switch (port)
			{
				case 0x20:
					// 8259A Master Programmable Interrupt Controller
					break;

				case 0x40:
				case 0x43:
					// 8253 or 8254 Programmable Interval Timer
					break;

				case 0x61:
					// system control port (for compatibility with 8255)
					break;

				/*case 0x3c0:
					// Attribute controller
					//this.oLog.WriteLine($"Output to port 0x{port:x4} (Old palette register), byte value 0x{value:x2}");
					this.oGPU.AttributeControllerWrite(value);
					break;

				case 0x3c4:
					this.oGPU.HWSequencerAddress = value;
					break;

				case 0x3c5:
					this.oGPU.SetSequencerValue(value);
					break;

				case 0x3c7:
					// DAC Palette Address, read
					this.oGPU.DACReadAddress = value;
					break;

				case 0x3c8:
					// DAC Palette Address, write
					this.oGPU.DACWriteAddress = value;
					break;

				case 0x3c9:
					// DAC Palette data, write
					this.oGPU.DACPalette = value;
					break;

				case 0x3ce:
					this.oGPU.HWGraphicsAddress = value;
					break;

				case 0x3cf:
					this.oGPU.SetGraphicsValue(value);
					break;

				case 0x3d0:
				case 0x3d2:
				case 0x3d6:
					// ignore this port
					break;

				case 0x3d4:
					// CRT Controller address
					this.oLog.WriteLine($"Output to port 0x{port:x4} (CRT Controller address), byte value 0x{value:x2}");
					break;

				case 0x3d1:
				case 0x3d3:
				case 0x3d7:
					// ignore this port
					break;

				case 0x3d5:
					// CRT Controller data, write
					this.oLog.WriteLine($"Output to port 0x{port:x4} (CRT Controller data, write), byte value 0x{value:x2}");
					break;*/

				default:
					this.oLog.WriteLine($"Output to port 0x{port:x4}, byte value 0x{value:x2}");
					break;
			}
		}

		public void OUTWord(ushort port, ushort value)
		{
			OUTByte(port, (byte)(value & 0xff));
			OUTByte((ushort)(port + 1), (byte)((value & 0xff00) >> 8));
		}

		public void REPEOUTSByte(CPURegister regSeg, CPURegister regSI, CPURegister regCX)
		{
			while (this.oCX.Word != 0)
			{
				OUTByte(this.oDX.Word, this.oMemory.ReadByte(regSeg.Word, regSI.Word));
				this.oCX.Word--;
			}
		}
		#endregion

		#region Flow control instructions
		public void Exit(int code)
		{
			this.EnableTimer = false;

			Console.WriteLine();
			Console.WriteLine($"Exiting program with code {code}, press any key...");

			while (Console.KeyAvailable)
			{
				Console.ReadKey();
			}

			while (!Console.KeyAvailable)
			{
				Thread.Sleep(200);
				System.Windows.Forms.Application.DoEvents();
			}

			Environment.Exit(code);
			System.Windows.Forms.Application.Exit();
		}

		public void Call(ushort offset)
		{
			this.oLog.WriteLine($"Trying to call function at 0x{this.oCS.Word:x4}:0x{offset:x4}");
		}

		public void Call(ushort segment, ushort offset)
		{
			this.oLog.WriteLine($"Trying to call function at 0x{segment:x4}:0x{offset:x4}");
		}

		public void CallF(uint address)
		{
			this.oLog.WriteLine($"Trying to call function at 0x{address:x8}");
		}

		public void Jmp(ushort offset)
		{
			this.oLog.WriteLine($"Trying to jump to 0x{this.CS.Word:x4}:0x{offset:x4}");
		}

		public void JmpF(uint address)
		{
			this.oLog.WriteLine($"Trying to jump to 0x{address:x8}");
		}
		#endregion

		#region Interrupt instruction
		private byte bVGAMode = 3;

		public void INT(byte value)
		{
			int iCount;
			int iLeft;
			int iTop;

			switch (value)
			{
				case 0x10:
					switch (this.oAX.High)
					{
						case 0x0:
							this.bVGAMode = this.oAX.Low;
							this.oFlags.C = false;
							break;

						case 0x2:
							Console.CursorLeft = this.oDX.Low;
							Console.CursorTop = this.oDX.High;
							this.oFlags.C = false;
							break;

						case 0x9:
							iLeft = Console.CursorLeft;
							iTop = Console.CursorTop;
							iCount = this.oCX.Word;
							for (; iCount > 0; iCount--)
							{
								//this.oGPU.PrintStdOut((char)this.oAX.Low, this.oBX.Low);
								Console.Write((char)this.oAX.Low);
							}
							Console.CursorLeft = iLeft;
							Console.CursorTop = iTop;
							this.oFlags.C = false;
							break;

						case 0xe:
							Console.Write((char)this.oAX.Low);
							this.oFlags.C = false;
							break;

						case 0xf:
							this.oAX.High = 80;
							this.oAX.Low = this.bVGAMode;
							this.oBX.High = 0;
							this.oFlags.C = false;
							break;

						default:
							throw new Exception($"Unknown 0x10 interrupt 0x{this.oAX.High:x2}");
					}
					break;

				case 0x21:
					switch (this.oAX.High)
					{
						case 0:
							DOSTerminateProcess();
							break;

						case 1:
							DOSKeyboardInputWithEcho();
							break;

						case 2:
							DOSPrintChar();
							break;

						case 5:
							DOSPrinterOutput();
							break;

						case 6:
							DOSDirectConsoleIO();
							break;

						case 9:
							DOSPrintString();
							break;

						case 0xf:
							DOSOpenFile();
							break;

						case 0x10:
							DOSCloseFile();
							break;

						case 0x11:
							DOSSearchForFirstEntryUsingFCB();
							break;

						case 0x16:
							DOSCreateFile();
							break;

						case 0x19:
							DOSGetCurrentDefaultDrive();
							break;

						case 0x1a:
							DOSSetFileTransferArea();
							break;

						case 0x21:
							DOSRandomFileRead();
							break;

						case 0x22:
							DOSRandomFileWrite();
							break;

						case 0x25:
							DOSSetInterruptVector();
							break;

						case 0x29:
							DOSParseAFilenameForFCB();
							break;

						case 0x2c:
							DOSGetCurrentTime();
							break;

						case 0x30:
							// DOS version 6.33
							this.oAX.Word = 0x1606;
							this.oFlags.C = false;
							break;

						case 0x35:
							DOSGetInterruptVector();
							break;

						case 0x3d:
							DOSOpenFileUsingHandle();
							break;

						case 0x3e:
							DOSCloseFileUsingHandle();
							break;

						case 0x3f:
							DOSReadFromFileOrDeviceUsingHandle();
							break;

						case 0x44:
							DOSIOControlForDevices();
							break;

						case 0x47:
							DosGetCurrentDirectory();
							break;

						case 0x48:
							DOSAllocateBlock();
							break;

						case 0x49:
							DOSFreeBlock();
							break;

						case 0x4a:
							DOSAdjustBlockSize();
							break;

						case 0x4b:
							DOSLoadOrExecuteProgram();
							break;

						case 0x4c:
							DOSTerminateProcessWithReturnCode();
							break;

						default:
							throw new Exception($"Unknown 0x21 interrupt 0x{this.oAX.High:x2}");
					}
					break;

				case 0x16:
					switch (this.oAX.High)
					{
						case 0:
							this.oParent.MSCAPI.getch();
							if (this.oAX.Word == 0)
							{
								this.oParent.MSCAPI.getch();
								switch (this.oAX.Word)
								{
									case 0x4b:
										this.oAX.Word = 0x4b00; // Left
										break;

									case 0x48:
										this.oAX.Word = 0x4800; // Up
										break;

									case 0x4d:
										this.oAX.Word = 0x4d00; // Right
										break;

									case 0x50:
										this.oAX.Word = 0x5000; // Down
										break;
								}
							}
							break;

						default:
							throw new Exception($"Unknown 0x16 interrupt 0x{this.oAX.High:x2}");
					}
					break;

				default:
					throw new Exception(string.Format("Unknown 0x{0:x2} interrupt", value));
			}
		}

		private void DOSKeyboardInputWithEcho()
		{
			while (this.oParent.VGADriver.Keys.Count == 0)
			{
				Thread.Sleep(200);
				this.DoEvents();
			}

			lock (this.oParent.VGADriver.VGALock)
			{
				this.oAX.Low = (byte)this.oParent.VGADriver.Keys.Dequeue();
			}
			Console.Write((char)this.oAX.Low);
		}

		private void DOSLoadOrExecuteProgram()
		{
			if (this.oAX.Low == 3)
			{
				string sTemp = this.ReadString(CPUMemory.ToLinearAddress(this.DS.Word, this.DX.Word));
				ushort usSegment = ReadWord(this.oES.Word, this.oBX.Word);
				ushort usRelocationSegment = ReadWord(this.oES.Word, (ushort)(this.oBX.Word + 2));
				this.oLog.WriteLine($"Loading overlay '{sTemp}' at segment 0x{usSegment:x4}");
				MZExecutable oOverlay = new MZExecutable($"{sDefaultDirectory}{sTemp}");
				oOverlay.ApplyRelocations(usRelocationSegment);
				this.oMemory.WriteBlock(usSegment, 0, oOverlay.Data, 0, oOverlay.Data.Length);
				this.oFlags.C = false;
			}
			else
			{
				throw new Exception("Load and Execute Program");
			}
		}

		private void DOSSetInterruptVector()
		{
			this.oLog.WriteLine($"Setting interrupt vector 0x{this.oAX.Low:x2} to address 0x{this.oDS.Word:x4}:0x{this.oDX.Word:x4}");
			this.oFlags.C = false;
		}

		private void DOSGetInterruptVector()
		{
			this.oLog.WriteLine($"Getting interrupt vector 0x{this.oAX.Low:x2} address");
			this.oES.Word = 0;
			this.oBX.Word = 0;
			this.oFlags.C = false;
		}

		/// <summary>
		/// <para>INT 21,2 - Display Output</para>
		/// <para>Parameters: AH = 02; DL = character to output</para>
		/// <para>Returns: nothing</para>
		/// <para>Remarks: Outputs character to STDOUT.
		/// Backspace is treated as non-destructive cursor left.
		/// If Ctrl-Break is detected, INT 23 is executed.</para>
		/// </summary>
		private void DOSPrintChar()
		{
			Console.Write((char)this.oDX.Low);
			this.oFlags.C = false;
		}

		/// <summary>
		/// <para>INT 21,5 - Printer Output</para>
		/// <para>Parameters: AH = 05; DL = character to output</para>
		/// <para>Returns: nothing</para>
		/// <para>Remarks: Sends character in DL to STDPRN.
		/// Waits until STDPRN device is ready before output.</para>
		/// </summary>
		private void DOSPrinterOutput()
		{
			throw new Exception("Printer output");
		}

		private void DOSIOControlForDevices()
		{
			// I/O Control for Devices
			if (this.oAX.Low == 0)
			{
				this.oLog.WriteLine($"Get Device Information for handle 0x{this.oBX.Word:x4}");
				switch (this.oBX.Word)
				{
					case 0:
					case 1:
					case 2:
						this.oDX.Word = 0x80d3;
						this.oFlags.C = false;
						break;

					case 3:
						this.oDX.Word = 0x80c0;
						this.oFlags.C = false;
						break;

					case 4:
						this.oDX.Word = 0xa8c0;
						this.oFlags.C = false;
						break;

					default:
						this.oDX.Word = 0xa8c0;
						this.oFlags.C = false;
						break;
				}
			}
		}

		///<summary>
		/// <para>INT 21,6 - Direct Console I/O</para>
		/// <para>Parameters: DL = (0-0xFE) character to output; 0xFF if console input request</para>
		/// <para>Returns: AL = input character if console input request (DL=FF)</para>
		/// <para>ZF = 0 if console request character available (in AL); 
		/// 1 if no character is ready, and function request was console input</para>
		/// <para>Remarks: reads from or writes to the console device depending on the value of DL, 
		/// cannot output character FF (DL=FF indicates read function), 
		/// for console read, no echo is produced,
		/// returns 0 for extended keystroke, then function must be called again to return scan code,
		/// ignores Ctrl-Break and Ctrl-PrtSc</para>
		///</summary>
		private void DOSDirectConsoleIO()
		{
			if (this.oDX.Low != 0xff)
			{
				Console.Write((char)this.oDX.Low);
			}
			else
			{
				if (this.oParent.VGADriver.Keys.Count > 0)
				{
					oFlags.Z = false;
					lock (this.oParent.VGADriver.VGALock)
					{
						this.oAX.Low = (byte)this.oParent.VGADriver.Keys.Dequeue();
					}
				}
				else
				{
					oFlags.Z = true;
				}
			}
			this.oFlags.C = false;
		}

		/// <summary>
		/// <para>INT 21,9 - Print String</para>
		/// <para>Parameters: DS:DX = pointer to string ending in "$"</para>
		/// <para>Returns: nothing</para>
		/// <para>Remarks: outputs character string to STDOUT up to "$",
		/// backspace is treated as non-destructive,
		/// if Ctrl-Break is detected, INT 23 is executed</para>
		/// </summary>
		private void DOSPrintString()
		{
			string sTemp = this.ReadDosString(CPUMemory.ToLinearAddress(this.oDS.Word, this.oDX.Word));
			if (sTemp.Length > 0)
			{
				Console.Write(sTemp);
			}
			this.oFlags.C = false;
		}

		private void DOSOpenFileUsingHandle()
		{
			// open file
			string sTemp = this.ReadString(CPUMemory.ToLinearAddress(this.DS.Word, this.DX.Word));
			FileAccess access = FileAccess.Read;
			switch (this.oAX.Low & 0x7)
			{
				case 0:
					access = FileAccess.Read;
					break;

				case 1:
					access = FileAccess.Write;
					break;

				case 2:
					access = FileAccess.ReadWrite;
					break;

				default:
					break;

			}
			if (this.sFileHandleCount > 0x7fff)
			{
				this.oFlags.C = true;
			}
			else
			{
				try
				{
					this.oLog.WriteLine($"Opening file '{sDefaultDirectory}{sTemp}'");
					this.aOpenFiles.Add(this.sFileHandleCount, new FileStreamItem(new FileStream($"{sDefaultDirectory}{sTemp}", FileMode.Open, access), FileStreamTypeEnum.Binary));
					this.oAX.Word = (ushort)this.sFileHandleCount;
					this.sFileHandleCount++;
					this.oFlags.C = false;
				}
				catch
				{
					this.oFlags.C = true;
				}
			}
		}

		private void DOSCloseFileUsingHandle()
		{
			short handle = (short)this.oBX.Word;
			if (this.aOpenFiles.ContainsKey(handle))
			{
				this.aOpenFiles.GetValueByKey(handle).Stream.Close();
				this.aOpenFiles.RemoveByKey(handle);

				this.oFlags.C = false;
			}
			else
			{
				this.oFlags.C = true;
			}
		}

		private void DOSReadFromFileOrDeviceUsingHandle()
		{
			short handle = (short)this.oBX.Word;
			if (this.aOpenFiles.ContainsKey(handle))
			{
				byte[] aBuffer = new byte[this.oCX.Word];
				int iReadBytes = this.aOpenFiles.GetValueByKey(handle).Stream.Read(aBuffer, 0, aBuffer.Length);
				if (iReadBytes >= 0)
				{
					this.oMemory.WriteBlock(this.oDS.Word, this.oDX.Word, aBuffer, 0, iReadBytes);
					this.oAX.Word = (ushort)iReadBytes;
					this.oFlags.C = false;
				}
				else
				{
					this.oFlags.C = true;
				}
			}
			else
			{
				this.oFlags.C = true;
			}
		}

		/// <summary>
		/// <para>INT 21,F - Open a File Using FCB</para>
		/// <para>Parameters: AH = 0F;
		/// DS:DX = pointer to unopened FCB</para>
		/// <para>Returns: AL = 00 if file opened; = FF if unable to open</para>
		/// <para>Remarks: Opens an existing file using a previously setup FCB.
		/// The FCB fields drive identifier, filename and extension
		/// must be filled in before call.
		/// Sets default FCB fields; current block number is set to 0;
		/// record size is set to 80h; file size, date and time are set
		/// to the values from the directory.
		/// Does not create file, see  INT 21,16.
		/// DOS 2.x allows opening of subdirectories, DOS 3.x does not.</para>
		/// </summary>
		private void DOSOpenFile()
		{
			if (DOS_FCBOpen(this.oDS.Word, this.oDX.Word))
			{
				this.oAX.Low = 0;
			}
			else
			{
				this.oAX.Low = 0xff;
			}
		}

		private void DOSGetCurrentDefaultDrive()
		{
			string sTemp = Path.GetPathRoot(sDefaultDirectory);
			this.oAX.Low = (byte)(sTemp[0] - 'A');
			this.oFlags.C = false;
		}

		private void DosGetCurrentDirectory()
		{
			if (this.oDX.Low != 0 && this.oDX.Low != 2)
			{
				this.oLog.WriteLine($"Wrong drive number {this.oDX.Low}");
			}
			string sTemp = sDefaultDirectory.Substring(3);
			this.WriteString(CPUMemory.ToLinearAddress(this.oDS.Word, this.oSI.Word), sTemp, sTemp.Length);
			this.oFlags.C = false;
		}

		bool DOS_FCBOpen(ushort seg, ushort offset)
		{
			DOS_FCB fcb = new DOS_FCB(this.oMemory, seg, offset);
			string shortname;
			int handle = -1;
			FileStream file;
			shortname = fcb.GetName();

			// First check if the name is correct
			if (!File.Exists(shortname))
				return false;

			// Check, if file is already opened
			for (int i = 0; i < this.aFileHandles.Length; i++)
			{
				file = this.aFileHandles[i];
				if (file != null && file.Name.Equals(shortname, StringComparison.CurrentCultureIgnoreCase))
				{
					handle = i;
					fcb.FileOpen((byte)handle);
					return true;
				}
			}

			if (!File.Exists(shortname) || this.iFileCount > 255)
				return false;
			file = new FileStream(shortname, FileMode.Open, FileAccess.ReadWrite);
			for (int i = 0; i < this.aFileHandles.Length; i++)
			{
				if (this.aFileHandles[i] == null)
				{
					handle = i;
					this.iFileCount++;
					break;
				}
			}
			if (handle < 0)
				return false;

			this.aFileHandles[handle] = file;
			fcb.FileOpen((byte)handle);

			return true;
		}

		/// <summary>
		/// <para>INT 21,10 - Close a File Using FCB</para>
		/// <para>Parameters: AH = 10h;
		/// DS:DX = pointer to an opened FCB</para>
		/// <para>Returns: AL = 00  if file closed;
		/// = FF  if file not closed</para>
		/// <para>Remarks: Closes a previously opened file opened with an FCB
		/// FCB must be setup with drive id, filename, and extension
		/// before call.</para>
		/// </summary>
		private void DOSCloseFile()
		{
			if (DOS_FCBClose(this.oDS.Word, this.oDX.Word))
			{
				this.oAX.Low = 0;
			}
			else
			{
				this.oAX.Low = 0xff;
			}
			this.oFlags.C = false;
		}

		void DOSParseAFilenameForFCB()
		{
			DOS_FCB fcb = new DOS_FCB(this.oMemory, this.oES.Word, this.oDI.Word);
			string sFilename = this.ReadString(CPUMemory.ToLinearAddress(this.oDS.Word, this.oSI.Word));
			string sName = Path.GetFileNameWithoutExtension(sFilename);
			string sExtension = Path.GetExtension(sFilename).Substring(1);
			if (File.Exists($"{this.sDefaultDirectory}{sFilename}"))
			{
				fcb.SetName(2, ref sName, ref sExtension);

				this.oSI.Word = (ushort)(this.oSI.Word + sFilename.Length);
				this.oAX.Low = 0;
			}
			else
			{
				sName = "";
				fcb.SetName(2, ref sName, ref sExtension);
				this.oSI.Word = (ushort)(this.oSI.Word + sFilename.Length);
				this.oAX.Low = 0;
			}
		}

		void DOSSearchForFirstEntryUsingFCB()
		{
			DOS_FCB fcb = new DOS_FCB(this.oMemory, this.oDS.Word, this.oDX.Word);
			string sFileName = fcb.GetName();

			if (File.Exists($"{this.sDefaultDirectory}{sFileName}"))
			{
				this.oAX.Low = 0;
			}
			else
			{
				this.oAX.Low = 0xff;
			}
		}

		bool DOS_FCBClose(ushort seg, ushort offset)
		{
			DOS_FCB fcb = new DOS_FCB(this.oMemory, seg, offset);
			if (!fcb.Valid())
				return false;

			byte fhandle;
			fcb.FileClose(out fhandle);
			if (fhandle >= this.iFileCount)
				return false;
			this.aFileHandles[fhandle].Close();
			this.aFileHandles[fhandle] = null;
			return true;
		}


		/// <summary>
		/// <para>INT 21,16 - Create a File Using FCB</para>
		/// <para>Parameters: AH = 16h;
		/// DS:DX = pointer to an unopened FCB</para>
		/// <para>Returns: AL = 00 if file created;
		/// = FF if file creation failed</para>
		/// <para>Remarks: Creates file using FCB and leaves open for later output.
		/// FCB must be setup with drive id, filename, and extension before call.</para>
		/// </summary>
		private void DOSCreateFile()
		{
			throw new Exception("Create file");
		}

		/// <summary>
		/// <para>INT 21,1A - Set Disk Transfer Address (DTA)</para>
		/// <para>Parameters: AH = 1A;
		/// DS:DX = pointer to disk transfer address (DTA)</para>
		/// <para>Returns: nothing</para>
		/// <para>Remarks: Specifies the disk transfer address to DOS.
		/// DTA cannot overlap 64K segment boundary.
		/// Offset 80h in the PSP is a 128 byte default DTA supplied
		/// by DOS upon program load. 
		/// Use of the DTA provided by DOS will result in the loss
		/// of the program command tail which also occupies the 128
		/// bytes starting at offset 80h of the PSP.</para>
		/// </summary>
		private void DOSSetFileTransferArea()
		{
			this.uiDOSDTA = CPUMemory.ToLinearAddress(this.oDS.Word, this.oDX.Word);
		}

		/// <summary>
		/// <para>INT 21,21 - Random Read Using FCB</para>
		/// <para>Parameters: AH = 21h;
		/// DS:DX = pointer to an opened FCB</para>
		/// <para>Returns: AL = 00 if read successful;
		/// = 01 if EOF (no data read);
		/// = 02 if DTA is too small;
		/// = 03 if EOF (partial record read)</para>
		/// <para>Remarks: Reads random records from a file opened with an FCB
		/// to the DTA.
		/// FCB must be setup with drive id, filename, extension,
		/// record position and record length before call.
		/// Current record position field in FCB is not updated.</para>
		/// </summary>
		private void DOSRandomFileRead()
		{
			this.oAX.Low = DOS_FCBRandomRead(this.oDS.Word, this.oDX.Word, 1, true);
		}

		byte DOS_FCBRandomRead(ushort seg, ushort offset, ushort numRec, bool restore)
		{
			/* if restore is true :random read else random block read. 
			 * random read updates old block and old record to reflect the random data
			 * before the read!!!!!!!!! and the random data is not updated! (user must do this)
			 * Random block read updates these fields to reflect the state after the read!
			 */

			/* BUG: numRec should return the amount of records read! 
			 * Not implemented yet as I'm unsure how to count on error states (partial/failed) 
			 */

			DOS_FCB fcb = new DOS_FCB(this.oMemory, seg, offset);
			uint random;
			ushort old_block = 0;
			byte old_rec = 0;
			byte error = 0;

			// Set the correct record from the random data
			fcb.GetRandom(out random);
			fcb.SetRecord((ushort)(random / 128), (byte)(random & 127));
			if (restore)
				fcb.GetRecord(out old_block, out old_rec); //store this for after the read.

			// Read records
			for (int i = 0; i < numRec; i++)
			{
				error = DOS_FCBRead(seg, offset, (ushort)i);
				if (error != 0x0) break;
			}

			ushort new_block;
			byte new_rec;
			fcb.GetRecord(out new_block, out new_rec);
			if (restore)
				fcb.SetRecord(old_block, old_rec);
			// Update the random record pointer with new position only when restore is false
			if (!restore)
				fcb.SetRandom((uint)new_block * 128 + (uint)new_rec);

			return error;
		}

		byte DOS_FCBRead(ushort seg, ushort offset, ushort recno)
		{
			DOS_FCB fcb = new DOS_FCB(this.oMemory, seg, offset);
			byte fhandle, cur_rec;
			ushort cur_block, rec_size;
			fcb.GetSeqData(out fhandle, out rec_size);
			fcb.GetRecord(out cur_block, out cur_rec);

			uint pos = (((uint)cur_block * 128) + (uint)cur_rec) * (uint)rec_size;
			byte[] dos_copybuf = new byte[rec_size];
			FileStream file = this.aFileHandles[fhandle];
			if (file == null)
				return 1;

			long newpos = file.Seek(pos, SeekOrigin.Current);

			ushort toread = rec_size;
			toread = (ushort)file.Read(dos_copybuf, 0, toread);
			if (toread == 0)
				return 0x1;
			if (toread < rec_size)
			{
				//Zero pad copybuffer to rec_size
				ushort i = toread;
				while (i < rec_size)
					dos_copybuf[i++] = 0;
			}
			for (int i = 0; i < dos_copybuf.Length; i++)
			{
				this.oMemory.WriteByte((uint)(this.uiDOSDTA + ((uint)recno * (uint)rec_size) + i), dos_copybuf[i]);
			}
			if (++cur_rec > 127)
			{
				cur_block++;
				cur_rec = 0;
			}
			fcb.SetRecord(cur_block, cur_rec);

			if (toread == rec_size)
				return 0;

			if (toread == 0)
				return 1;

			return 3;
		}

		/// <summary>
		/// <para>INT 21,22 - Random Write Using FCB</para>
		/// <para>Parameters: AH = 21h;
		/// DS:DX = pointer to an opened FCB</para>
		/// <para>Returns: AL = 00 if write successful; 
		/// = 01 if diskette full or read only; 
		/// = 02 if DTA is too small</para>
		/// <para>Remarks: Write records to random location in file opened with FCB.
		/// FCB must be setup with drive id, filename, extension,
		/// record position and record length before call.
		/// Current record position field in FCB is not updated.</para>
		/// </summary>
		private void DOSRandomFileWrite()
		{
			throw new Exception("File write");
		}

		/// <summary>
		/// <para>INT 21,2C - Get Time</para>
		/// <para>Parameters: -</para>
		/// <para>Returns: CH = hour (0-23); CL = minutes (0-59); DH = seconds (0-59); DL = hundredths (0-99)</para>
		/// <para>Remarks: retrieves DOS maintained clock time</para>
		/// </summary>
		private void DOSGetCurrentTime()
		{
			DateTime value = DateTime.Now;
			this.oCX.High = (byte)value.Hour;
			this.oCX.Low = (byte)value.Minute;
			this.oDX.High = (byte)value.Second;
			this.oDX.Low = (byte)(value.Millisecond / 10);
			this.oFlags.C = false;
		}

		/// <summary>
		/// <para>INT 21,48 - Allocate Memory</para>
		/// <para>Parameters: BX = number of memory paragraphs requested</para>
		/// <para>Returns: AX = segment address of allocated memory block (MCB + 1para), 
		/// or error code if CF set;
		/// BX = size in paras of the largest block of memory available, or 
		/// if CF set, and AX = 08 (Not Enough Mem); 
		/// CF = 0 if successful, 1 if error</para>
		/// <para>Remarks: returns segment address of allocated memory block AX:0000,
		/// each allocation requires a 16 byte overhead for the MCB,
		/// returns maximum block size available if error</para>
		/// </summary>
		private void DOSAllocateBlock()
		{
			ushort usTemp;
			if (this.oBX.Word == 0xffff)
			{
				this.oBX.Word = (ushort)((this.oMemory.FreeMemory.Size >> 4) & 0xffff);
				this.oFlags.C = true;
			}
			else if (this.oMemory.AllocateMemoryBlock(this.oBX.Word, out usTemp))
			{
				oFlags.C = false;
				this.oAX.Word = usTemp;
			}
			else
			{
				oFlags.C = true;
				this.oBX.Word = usTemp;
				this.oAX.Word = 8; // Insufficient memory
			}
		}

		/// <summary>
		/// <para>INT 21,49 - Free Allocated Memory</para>
		/// <para>Parameters: ES = segment of the block to be returned (MCB + 1para)</para>
		/// <para>Returns: AX = error code if CF set</para>
		/// <para>Remarks: releases memory and MCB allocated by INT 21,48. 
		/// May cause unpredictable results if memory wasn't allocated using 
		/// INT 21,48 or if memory wasn't allocated by the current process. 
		/// Checks for valid MCB id, but does NOT check for process ownership. 
		/// Care must be taken when freeing the memory of another process, to 
		/// assure the segment isn't in use by a TSR or ISR. 
		/// This function is unreliable in a TSR once resident, since 
		/// COMMAND.COM and many other .COM files take all available memory 
		/// when they load.</para>
		/// </summary>
		private void DOSFreeBlock()
		{
			if (this.oMemory.FreeMemoryBlock(this.oES.Word))
			{
				oFlags.C = false;
			}
			else
			{
				oFlags.C = true;
				this.oAX.Word = 9; // Invalid memory block address
			}
		}

		/// <summary>
		/// <para>INT 21,4A - Modify Allocated Memory Block (SETBLOCK)</para>
		/// <para>Parameters: BX = new requested block size in paragraphs,
		/// ES = segment of the block (MCB + 1 para)</para>
		/// <para>Returns: AX = error code if CF set; 
		/// BX = maximum block size possible, if CF set and AX = 8</para>
		/// <para>Remarks: modifies memory blocks allocated by  INT 21,48,
		/// can be used by programs to shrink or increase the size of allocated memory, 
		/// PC-DOS version 2.1 and DOS 3.x will actually allocate the largest
		/// available block if CF is set.  BX will equal the size allocated.</para>
		/// </summary>
		private void DOSAdjustBlockSize()
		{
			if (this.oMemory.ResizeMemoryBlock(this.oES.Word, this.oBX.Word))
			{
				oFlags.C = false;
				this.oAX.Word = 00;
			}
			else
			{
				oFlags.C = true;
				this.oAX.Word = 8;
				this.oBX.Word = 0;
			}
		}

		private void DOSTerminateProcessWithReturnCode()
		{
			this.Exit(this.oAX.Low);
		}

		private void DOSTerminateProcess()
		{
			this.Exit(-1);
		}

		public class DOS_FCB
		{
			private bool extended;
			private uint pt;
			private CPUMemory oMemory;

			// struct sFCB
			private byte drive;         // Drive number 0=default, 1=A, etc.
			private string filename;        // 8 Space padded name
			private string ext;         // 3 Space padded extension
			private ushort cur_block;       // Current Block
			private ushort rec_size;        // Logical record size
			private uint filesize;      // File Size
			private ushort date;
			private ushort time;
			// Reserved Block should be 8 bytes
			private byte sft_entries;
			private byte share_attributes;
			private byte extra_info;
			private byte file_handle;
			private byte[] reserved = new byte[4];  // 4
													// end
			private byte cur_rec;           // Current record in current block
			private uint rndm;          // Current relative record number

			// -7   byte	if FF this is an extended FCB 0
			// -6  5bytes	reserved  0
			// -1   byte	file attribute if extended FCB 0
			// 00   byte	drive number (0 for default drive, 1=A:, 2=B:, ...)
			// 01  8bytes	filename, left justified with trailing blanks
			// 09  3bytes	filename extension, left justified w/blanks
			// 0C   word	current block number relative to beginning of the file, starting with zero
			// 0E   word	logical record size in bytes
			// 10   dword	file size in bytes
			// 14   word	date the file was created or last updated
			// |F|E|D|C|B|A|9|8|7|6|5|4|3|2|1|0| 15,14 (Intel reverse order)
			// | | | | | | | | | | | `--------- day 1-31
			// | | | | | | | `---------------- month 1-12
			// `----------------------------- year + 1980

			// 16   word	time of last write
			// |F|E|D|C|B|A|9|8|7|6|5|4|3|2|1|0| 17,16 (Intel reverse order)
			// | | | | | | | | | | | `---------- secs in 2 second increments
			// | | | | | `--------------------- minutes (0-59)
			// `------------------------------ hours (0-23)

			// 18  8bytes	see below for version specific information  Ø
			// 1A   dword	address of device header if character device  Ø
			// 20   byte	current relative record number within current BLOCK
			// 21   dword	relative record number relative to the beginning of
			// 		the file, starting with zero; high bit omitted if
			// 		record length is 64 bytes

			public DOS_FCB(CPUMemory mem, ushort seg, ushort off) :
				this(mem, seg, off, true)
			{ }

			public DOS_FCB(CPUMemory mem, ushort seg, ushort off, bool allow_extended)
			{
				this.oMemory = mem;
				this.pt = CPUMemory.ToLinearAddress(seg, off);
				extended = false;

				ReadFCBFromMemory();

				if (allow_extended)
				{
					if (this.drive == 0xff)
					{
						this.pt += 7;
						extended = true;
						ReadFCBFromMemory();
					}
				}
			}

			private void ReadFCBFromMemory()
			{
				this.drive = oMemory.ReadByte(pt);
				this.filename = ReadString(pt + 1, 8);
				this.ext = ReadString(pt + 9, 3);
				this.cur_block = oMemory.ReadWord(pt + 0xc);
				this.rec_size = oMemory.ReadWord(pt + 0xe);
				this.filesize = (uint)oMemory.ReadWord(pt + 0x10) |
					((uint)oMemory.ReadWord(pt + 0x12) << 16);
				this.date = oMemory.ReadWord(pt + 0x14);
				this.time = oMemory.ReadWord(pt + 0x16);
				this.sft_entries = oMemory.ReadByte(pt + 0x18);
				this.share_attributes = oMemory.ReadByte(pt + 0x19);
				this.extra_info = oMemory.ReadByte(pt + 0x1a);
				this.file_handle = oMemory.ReadByte(pt + 0x1b);
				this.reserved[0] = oMemory.ReadByte(pt + 0x1c);
				this.reserved[1] = oMemory.ReadByte(pt + 0x1d);
				this.reserved[2] = oMemory.ReadByte(pt + 0x1e);
				this.reserved[3] = oMemory.ReadByte(pt + 0x1f);
				this.cur_rec = oMemory.ReadByte(pt + 0x20);
				this.rndm = (uint)oMemory.ReadWord(pt + 0x21) |
						((uint)oMemory.ReadWord(pt + 0x23) << 16);
			}

			private string ReadString(uint address, int size)
			{
				StringBuilder text = new StringBuilder();

				for (int i = 0; i < size; i++)
				{
					byte ch = oMemory.ReadByte((uint)(address + i));
					if (ch == 0x20 || ch == 0)
						break;
					text.Append((char)ch);
				}

				return text.ToString();
			}

			private void WriteString(uint address, int size, string text)
			{
				for (int i = 0; i < size; i++)
				{
					byte ch;
					if (i >= text.Length)
						ch = 0x20;
					else
						ch = (byte)text[i];
					oMemory.WriteByte((uint)(address + i), ch);
				}
			}

			//public void Create(bool _extended);
			//public void SetSizeDateTime(uint _size, ushort _date, ushort _time);
			//public void GetSizeDateTime(ref uint _size, ref ushort _date, ref ushort _time);
			public void SetName(byte _drive, ref string _fname, ref string _ext)
			{
				this.drive = _drive;
				oMemory.WriteByte(pt, this.drive);
				this.filename = _fname;
				WriteString(pt + 1, 8, this.filename);
				this.ext = _ext;
				WriteString(pt + 9, 3, this.ext);
			}

			public string GetName()
			{
				StringBuilder name = new StringBuilder();
				//name.Append((char)((byte)'A' + GetDrive()));
				//name.Append(':');
				name.Append(this.filename);
				name.Append('.');
				name.Append(this.ext);

				return name.ToString();
			}

			public void FileOpen(byte _fhandle)
			{
				this.drive = (byte)(GetDrive() + 1);
				oMemory.WriteByte(pt, this.drive);
				this.file_handle = _fhandle;
				oMemory.WriteByte(pt + 0x1b, this.file_handle);
				this.cur_block = 0;
				oMemory.WriteWord(pt + 0xc, this.cur_block);
				this.rec_size = 128;
				oMemory.WriteWord(pt + 0xe, this.rec_size);
				//	this.rndm = 0; // breaks Jewels of darkness. 
				FileInfo info = new FileInfo(this.GetName());
				this.filesize = (uint)(info.Length & 0xffffffffu);
				oMemory.WriteWord(pt + 0x10, (ushort)(this.filesize & 0xffff));
				oMemory.WriteWord(pt + 0x12, (ushort)((this.filesize & 0xffff0000) >> 16));
				this.date = ToDosDate(info.LastWriteTime);
				oMemory.WriteWord(pt + 0x14, this.date);
				this.time = ToDosTime(info.LastWriteTime);
				oMemory.WriteWord(pt + 0x16, this.time);
			}

			// 16   word	time of last write
			// |F|E|D|C|B|A|9|8|7|6|5|4|3|2|1|0| 17,16 (Intel reverse order)
			// | | | | | | | | | | | `---------- secs in 2 second increments
			// | | | | | `--------------------- minutes (0-59)
			// `------------------------------ hours (0-23)
			private ushort ToDosTime(DateTime time)
			{
				ushort val = 0;
				val |= (ushort)((time.Second / 2) & 0x1f);
				val |= (ushort)(((time.Minute) & 0x3f) << 5);
				val |= (ushort)(((time.Hour) & 0x1f) << 11);

				return val;
			}

			// |F|E|D|C|B|A|9|8|7|6|5|4|3|2|1|0| 15,14 (Intel reverse order)
			// | | | | | | | | | | | `--------- day 1-31
			// | | | | | | | `---------------- month 1-12
			// `----------------------------- year + 1980
			private ushort ToDosDate(DateTime time)
			{
				ushort val = 0;
				val |= (ushort)((time.Day) & 0x1f);
				val |= (ushort)(((time.Minute) & 0xf) << 5);
				val |= (ushort)(((time.Year - 1980) & 0x7f) << 9);

				return val;
			}

			public void FileClose(out byte _fhandle)
			{
				_fhandle = this.file_handle;
				this.file_handle = 0xff;
				oMemory.WriteByte(pt + 0x1b, this.file_handle);

			}

			public void GetRecord(out ushort _cur_block, out byte _cur_rec)
			{
				_cur_block = this.cur_block;
				_cur_rec = this.cur_rec;
			}

			public void SetRecord(ushort _cur_block, byte _cur_rec)
			{
				this.cur_block = _cur_block;
				oMemory.WriteWord(pt + 0xc, this.cur_block);
				this.cur_rec = _cur_rec;
				oMemory.WriteByte(pt + 0x20, this.cur_rec);
			}

			public void GetSeqData(out byte _fhandle, out ushort _rec_size)
			{
				_fhandle = this.file_handle;
				_rec_size = this.rec_size;
			}

			public void GetRandom(out uint _random)
			{
				_random = this.rndm;
			}

			public void SetRandom(uint _random)
			{
				this.rndm = _random;
				oMemory.WriteWord(pt + 0x21, (ushort)(this.rndm & 0xffff));
				oMemory.WriteWord(pt + 0x23, (ushort)((this.rndm & 0xffff0000) >> 16));
			}

			public byte GetDrive()
			{
				if (this.drive == 0)
				{
					byte drv = 2;
					string sRoot = Path.GetPathRoot(Assembly.GetExecutingAssembly().Location).ToUpper();
					if (sRoot.Length == 3 && sRoot[1] == ':' && sRoot[2] == Path.PathSeparator)
					{
						drv = (byte)((byte)sRoot[0] - (byte)'A');
					}
					return drv;
				}
				else
					return (byte)(this.drive - 1);
			}

			public bool Extended()
			{
				return this.extended;
			}

			public void GetAttr(ref byte attr)
			{
				if (this.extended)
				{
					attr = oMemory.ReadByte(pt - 1);
				}
			}

			public void SetAttr(byte attr)
			{
				if (this.extended)
				{
					oMemory.WriteByte(pt - 1, attr);
				}
			}

			public bool Valid()
			{
				//Very simple check for Oubliette
				if (this.filename[0] == 0 && this.file_handle == 0)
					return false;

				return true;
			}
		}
		#endregion
	}
}
