using System;
using System.Reflection;
using Disassembler;

namespace Civilization1
{
	public class Segment_1000
	{
		private Civilization oParent;
		private CPU oCPU;

		public Segment_1000(Civilization parent)
		{
			this.oParent = parent;
			this.oCPU = parent.CPU;
		}

		public void F0_1000_0000()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0000'(Cdecl) at 0x1000:0x0000, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.DS.Word);
			this.oCPU.AX.Low = 0x1;
			this.oCPU.Temp.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, 0x5a);
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x5a, this.oCPU.AX.Low);
			this.oCPU.AX.Low = this.oCPU.Temp.Low;
			this.oCPU.AX.Low = this.oCPU.ORByte(this.oCPU.AX.Low, this.oCPU.AX.Low);
			if (this.oCPU.Flags.NE) goto L004f;
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x4c, 0x1); // Segment
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x54, 0x1);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x42, 0x0);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x44, 0x0);
			this.oCPU.AX.Low = 0x36;
			this.oCPU.OUTByte(0x43, this.oCPU.AX.Low);
			this.oCPU.AX.Low = 0x0;
			this.oCPU.OUTByte(0x40, this.oCPU.AX.Low);
			this.oCPU.OUTByte(0x40, this.oCPU.AX.Low);
			this.oCPU.PushWord(0x0034); // stack management - push return offset
			// Instruction address 0x1000:0x0031, size: 3
			F0_1000_0276();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.AX.High = 0x35;
			this.oCPU.AX.Low = 0x8;
			this.oCPU.INT(0x21);
			this.oCPU.WriteWord(this.oCPU.CS.Word, 0x211, this.oCPU.BX.Word);
			this.oCPU.WriteWord(this.oCPU.CS.Word, 0x213, this.oCPU.ES.Word);
			this.oCPU.AX.High = 0x25;
			this.oCPU.AX.Low = 0x8;
			// LDS
			this.oCPU.DX.Word = this.oCPU.ReadWord(this.oCPU.CS.Word, 0x1a3);
			this.oCPU.DS.Word = this.oCPU.ReadWord(this.oCPU.CS.Word, (ushort)(0x1a3 + 2));
			this.oCPU.INT(0x21);

		L004f:
			this.oCPU.DS.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0000'");
		}

		public void F0_1000_0051()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0051'(Cdecl) at 0x1000:0x0051, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.DS.Word);
			this.oCPU.AX.Low = 0x0;
			this.oCPU.Temp.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, 0x5a);
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x5a, this.oCPU.AX.Low);
			this.oCPU.AX.Low = this.oCPU.Temp.Low;
			this.oCPU.AX.Low = this.oCPU.ORByte(this.oCPU.AX.Low, this.oCPU.AX.Low);
			if (this.oCPU.Flags.E) goto L0075;
			this.oCPU.AX.Low = 0x36;
			this.oCPU.OUTByte(0x43, this.oCPU.AX.Low);
			this.oCPU.AX.Low = 0x0;
			this.oCPU.OUTByte(0x40, this.oCPU.AX.Low);
			this.oCPU.OUTByte(0x40, this.oCPU.AX.Low);
			this.oCPU.AX.High = 0x25;
			this.oCPU.AX.Low = 0x8;
			// LDS
			this.oCPU.DX.Word = this.oCPU.ReadWord(this.oCPU.CS.Word, 0x211);
			this.oCPU.DS.Word = this.oCPU.ReadWord(this.oCPU.CS.Word, (ushort)(0x211 + 2));
			this.oCPU.INT(0x21);

		L0075:
			this.oCPU.DS.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0051'");
		}

		public void F0_1000_0276()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0276'(Cdecl) at 0x1000:0x0276, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushF();
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x59, 0x1);
			this.oCPU.AX.Word = 0x0;
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x58, 0x1);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x50, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x52, this.oCPU.AX.Word);
			this.oCPU.PushWord(0x028d); // stack management - push return offset
			// Instruction address 0x1000:0x028a, size: 3
			F0_1000_030b();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.CX.Word = 0x10;

		L0292:
			this.oCPU.PushWord(this.oCPU.BX.Word);
			this.oCPU.PushWord(0x0296); // stack management - push return offset
			// Instruction address 0x1000:0x0293, size: 3
			F0_1000_030b();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.BX.Word = this.oCPU.PopWord();
			this.oCPU.BX.Word = this.oCPU.SUBWord(this.oCPU.BX.Word, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x50, this.oCPU.ADDWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x50), this.oCPU.BX.Word));
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x52, this.oCPU.ADCWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x52), 0x0));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			if (this.oCPU.Loop(this.oCPU.CX)) goto L0292;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x50);
			this.oCPU.DX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x52);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x42, this.oCPU.ADDWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x42), this.oCPU.AX.Word));
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x44, this.oCPU.ADCWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x44), this.oCPU.DX.Word));
			this.oCPU.CX.Word = 0x10;
			this.oCPU.DIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			this.oCPU.AX.Word = this.oCPU.SHRWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x50, this.oCPU.AX.Word);
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.BX.Word = this.oCPU.SHRWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.BX.Word = this.oCPU.SHRWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.BX.Word = this.oCPU.SHRWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.BX.Word = this.oCPU.SHRWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, this.oCPU.BX.Word);
			this.oCPU.DX.Word = 0x0;
			this.oCPU.BX.Word = 0xf89;
			this.oCPU.DIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.BX.Word);
			this.oCPU.CMPWord(this.oCPU.AX.Word, 0x4);
			if (this.oCPU.Flags.B) goto L02df;
			this.oCPU.CMPWord(this.oCPU.AX.Word, 0x6);
			if (this.oCPU.Flags.A) goto L02df;
			goto L02ed;

		L02df:
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x58, 0x0);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x50, 0x4dae);
			this.oCPU.AX.Word = 0x5;

		L02ed:
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x4e, this.oCPU.AX.Word);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x4c), 0x1);
			if (this.oCPU.Flags.E) goto L02fa;
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x4c, this.oCPU.AX.Word);

		L02fa:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x50);
			this.oCPU.DX.Word = 0x0;
			this.oCPU.DIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x4c));
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x48, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x46, this.oCPU.AX.Word);
			this.oCPU.PopF();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0276'");
		}

		public void F0_1000_030b()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_030b'(Cdecl) at 0x1000:0x030b, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushF();
			this.oCPU.DX.Word = 0x3da;
			this.oCPU.BX.Word = 0x0;

		L0312:
			this.oCPU.BX.Word = this.oCPU.DECWord(this.oCPU.BX.Word);
			if (this.oCPU.Flags.E) goto L0336;
			this.oCPU.AX.Low = this.oCPU.INByte(this.oCPU.DX.Word);
			this.oCPU.TESTByte(this.oCPU.AX.Low, 0x8);
			if (this.oCPU.Flags.NE) goto L0312;
			this.oCPU.BX.Word = 0x0;

		L031c:
			this.oCPU.BX.Word = this.oCPU.DECWord(this.oCPU.BX.Word);
			if (this.oCPU.Flags.E) goto L0336;
			this.oCPU.AX.Low = this.oCPU.INByte(this.oCPU.DX.Word);
			this.oCPU.TESTByte(this.oCPU.AX.Low, 0x8);
			if (this.oCPU.Flags.E) goto L031c;
			this.oCPU.AX.Low = 0x0;
			this.oCPU.OUTByte(0x43, this.oCPU.AX.Low);
			this.oCPU.AX.Low = this.oCPU.INByte(0x40);
			this.oCPU.BX.Low = this.oCPU.AX.Low;
			this.oCPU.AX.Low = this.oCPU.INByte(0x40);
			this.oCPU.BX.High = this.oCPU.AX.Low;

		L0336:
			this.oCPU.AX.Word = this.oCPU.BX.Word;
			this.oCPU.PopF();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_030b'");
		}

		public void F0_1000_033a()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_033a'(Cdecl) at 0x1000:0x033a, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5c);
			this.oParent.LogWriteLine("Exiting function 'F0_1000_033a'");
		}

		public void F0_1000_033e()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_033e'(Cdecl) at 0x1000:0x033e, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.AX.Word = 0x0;
			this.oCPU.Temp.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5c);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5c, this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.Temp.Word;
			this.oParent.LogWriteLine("Exiting function 'F0_1000_033e'");
		}

		public void F0_1000_0382()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0382'(Cdecl) at 0x1000:0x0382, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.PushWord(this.oCPU.DS.Word);
			this.oCPU.AX.Word = 0x35cf;
			this.oCPU.DS.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = 0xffff;
			this.oCPU.CX.Low = 0x20;
			this.oCPU.AX.Word = this.oCPU.SHRWord(this.oCPU.AX.Word, this.oCPU.CX.Low);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x0, this.oCPU.AX.Word);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.DECWord(this.oCPU.BX.Word);
			this.oCPU.CMPWord(this.oCPU.BX.Word, 0x8);
			if (this.oCPU.Flags.AE) goto L03f5;
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x2));
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xa));
			this.oCPU.DX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xc));
			this.oCPU.DX.Word = this.oCPU.SUBWord(this.oCPU.DX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.BE) goto L03f5;
			this.oCPU.DX.Word = this.oCPU.INCWord(this.oCPU.DX.Word);
			this.oCPU.CMPWord(this.oCPU.DX.Word, 0x10);
			if (this.oCPU.Flags.BE) goto L03b9;
			this.oCPU.DX.Word = 0x10;

		L03b9:
			this.oCPU.CX.Word = this.oCPU.DX.Word;
			this.oCPU.CX.Word = this.oCPU.ADDWord(this.oCPU.CX.Word, this.oCPU.DX.Word);
			this.oCPU.CX.Word = this.oCPU.ADDWord(this.oCPU.CX.Word, this.oCPU.DX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x4), this.oCPU.CX.Word);
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x6), this.oCPU.AX.Low);
			this.oCPU.PushWord(this.oCPU.DS.Word);
			this.oCPU.ES.Word = this.oCPU.PopWord();
			// LEA
			this.oCPU.DI.Word = (ushort)(this.oCPU.BX.Word + 0x9);
			this.oCPU.DX.Word = 0x3c7;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x6));
			this.oCPU.OUTByte(this.oCPU.DX.Word, this.oCPU.AX.Low);
			this.oCPU.DX.Low = 0xc9;

		L03d6:
			this.oCPU.AX.Low = this.oCPU.INByte(this.oCPU.DX.Word);
			this.oCPU.STOSByte();
			if (this.oCPU.Loop(this.oCPU.CX)) goto L03d6;
			this.oCPU.CX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x4));
			this.oCPU.CX.Word = this.oCPU.SUBWord(this.oCPU.CX.Word, 0x3);
			// LEA
			this.oCPU.SI.Word = (ushort)(this.oCPU.BX.Word + 0x9);
			this.oCPU.REPEMOVSByte(this.oCPU.DS, this.oCPU.SI, this.oCPU.ES, this.oCPU.DI, this.oCPU.CX);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x7), this.oCPU.AX.Low);
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x8), 0x0);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x2), 0x0);

		L03f5:
			this.oCPU.DS.Word = this.oCPU.PopWord();
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0382'");
		}

		public void F0_1000_03fa()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_03fa'(Cdecl) at 0x1000:0x03fa, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.PushWord(this.oCPU.DS.Word);
			this.oCPU.AX.Word = 0x35cf;
			this.oCPU.DS.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.AX.Word = this.oCPU.XORWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.DECWord(this.oCPU.AX.Word);
			this.oCPU.CMPWord(this.oCPU.AX.Word, 0x8);
			if (this.oCPU.Flags.AE) goto L0428;
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x2));
			this.oCPU.AX.Word = 0x3;
			this.oCPU.AX.Word = this.oCPU.XORWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, this.oCPU.BX.Word, this.oCPU.AX.Word);
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x7));
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x8), this.oCPU.AX.Low);

		L0428:
			this.oCPU.DS.Word = this.oCPU.PopWord();
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_03fa'");
		}

		public void F0_1000_042b()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_042b'(Cdecl) at 0x1000:0x042b, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.PushWord(this.oCPU.DS.Word);
			this.oCPU.AX.Word = 0x35cf;
			this.oCPU.DS.Word = this.oCPU.AX.Word;
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.DECWord(this.oCPU.BX.Word);
			this.oCPU.CMPWord(this.oCPU.BX.Word, 0x8);
			if (this.oCPU.Flags.AE) goto L0447;
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x2));
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x8), 0x0);

		L0447:
			this.oCPU.DS.Word = this.oCPU.PopWord();
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_042b'");
		}

		public void F0_1000_04aa()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_04aa'(Cdecl) at 0x1000:0x04aa, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.PushWord(this.oCPU.DS.Word);
			this.oCPU.ES.Word = this.oCPU.PopWord();
			this.oCPU.CX.Word = 0x300;
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.SI.Word = this.oCPU.ADDWord(this.oCPU.SI.Word, 0x6);
			// LEA
			this.oCPU.DI.Word = 0xba06;
			this.oCPU.REPEMOVSByte(this.oCPU.DS, this.oCPU.SI, this.oCPU.ES, this.oCPU.DI, this.oCPU.CX);
			this.oCPU.PushWord(0x04c3); // stack management - push return offset
			// Instruction address 0x1000:0x04c0, size: 3
			F0_1000_0554();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.PushWord(0x04c9); // stack management - push return offset
			// Instruction address 0x1000:0x04c6, size: 3
			F0_1000_050c();
			this.oCPU.PopWord(); // stack management - pop return offset

		L04c9:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x68), 0x0);
			if (this.oCPU.Flags.NE) goto L04c9;
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_04aa'");
		}

		public void F0_1000_04d4()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_04d4'(Cdecl) at 0x1000:0x04d4, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.PushWord(this.oCPU.DS.Word);
			this.oCPU.ES.Word = this.oCPU.PopWord();
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.AX.High = this.oCPU.ReadByte(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xa));
			this.oCPU.BX.Low = this.oCPU.ReadByte(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xc));
			// LEA
			this.oCPU.DI.Word = 0xba06;
			this.oCPU.CX.Word = 0x100;

		L04eb:
			this.oCPU.WriteByte(this.oCPU.DS.Word, this.oCPU.DI.Word, this.oCPU.AX.Low);
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.DI.Word + 0x1), this.oCPU.AX.High);
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.DI.Word + 0x2), this.oCPU.BX.Low);
			this.oCPU.DI.Word = this.oCPU.ADDWord(this.oCPU.DI.Word, 0x3);
			if (this.oCPU.Loop(this.oCPU.CX)) goto L04eb;
			this.oCPU.PushWord(0x04fb); // stack management - push return offset
			// Instruction address 0x1000:0x04f8, size: 3
			F0_1000_0554();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.PushWord(0x0501); // stack management - push return offset
			// Instruction address 0x1000:0x04fe, size: 3
			F0_1000_050c();
			this.oCPU.PopWord(); // stack management - pop return offset

		L0501:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x68), 0x0);
			if (this.oCPU.Flags.NE) goto L0501;
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_04d4'");
		}

		public void F0_1000_050c()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_050c'(Cdecl) at 0x1000:0x050c, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.AX.High = 0x6;
			this.oCPU.MULByte(this.oCPU.AX, this.oCPU.AX.High);
			this.oCPU.BP.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x66);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L051f;
			this.oCPU.PushWord(0x051c); // stack management - push return offset
			// Instruction address 0x1000:0x0519, size: 3
			F0_1000_0573();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x66, this.oCPU.AX.Word);

		L051f:
			this.oCPU.DX.Word = 0x0;
			this.oCPU.CX.Word = 0xe;
			this.oCPU.DIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			this.oCPU.AX.High = this.oCPU.ORByte(this.oCPU.AX.High, this.oCPU.AX.High);
			if (this.oCPU.Flags.E) goto L052d;
			this.oCPU.AX.Word = 0x100;

		L052d:
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x64, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x62, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x62, this.oCPU.NEGWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x62)));
			this.oCPU.MULWord(this.oCPU.DX, this.oCPU.AX, this.oCPU.BP.Word);
			this.oCPU.CX.High = this.oCPU.DX.Low;
			this.oCPU.CX.Low = this.oCPU.AX.High;
			this.oCPU.CX.Word = this.oCPU.DECWord(this.oCPU.CX.Word);
			this.oCPU.DX.Word = 0x1;
			this.oCPU.AX.Word = 0x0;
			this.oCPU.DIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6c, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6a, this.oCPU.AX.Word);
			this.oCPU.PushWord(0x054f); // stack management - push return offset
			// Instruction address 0x1000:0x054c, size: 3
			F0_1000_05b7();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x68, this.oCPU.BP.Word);
			this.oParent.LogWriteLine("Exiting function 'F0_1000_050c'");
		}

		public void F0_1000_0554()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0554'(Cdecl) at 0x1000:0x0554, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.DX.Word = 0x3da;

		L0558:
			this.oCPU.AX.Low = this.oCPU.INByte(this.oCPU.DX.Word);
			this.oCPU.TESTByte(this.oCPU.AX.Low, 0x8);
			if (this.oCPU.Flags.E) goto L0558;
			// LEA
			this.oCPU.DI.Word = 0xbd06;
			this.oCPU.CX.Word = 0x300;
			this.oCPU.DX.Low = 0xc7;
			this.oCPU.AX.Low = 0x0;
			this.oCPU.OUTByte(this.oCPU.DX.Word, this.oCPU.AX.Low);
			this.oCPU.DX.Low = 0xc9;

		L056d:
			this.oCPU.AX.Low = this.oCPU.INByte(this.oCPU.DX.Word);
			this.oCPU.STOSByte();
			if (this.oCPU.Loop(this.oCPU.CX)) goto L056d;
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0554'");
		}

		public void F0_1000_0573()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0573'(Cdecl) at 0x1000:0x0573, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.AX.Word = 0xffff;
			this.oCPU.CX.Low = 0x20;
			this.oCPU.AX.Word = this.oCPU.SHRWord(this.oCPU.AX.Word, this.oCPU.CX.Low);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x60, this.oCPU.AX.Word);
			this.oCPU.BX.Word = 0x0;
			this.oCPU.DX.Word = 0x3da;

		L0584:
			this.oCPU.AX.Low = this.oCPU.INByte(this.oCPU.DX.Word);
			this.oCPU.TESTByte(this.oCPU.AX.Low, 0x8);
			if (this.oCPU.Flags.E) goto L0584;

		L0589:
			this.oCPU.AX.Low = this.oCPU.INByte(this.oCPU.DX.Word);
			this.oCPU.TESTByte(this.oCPU.AX.Low, 0x8);
			if (this.oCPU.Flags.NE) goto L0589;

		L058e:
			this.oCPU.DX.Low = 0xc8;
			this.oCPU.AX.Low = 0x0;
			this.oCPU.OUTByte(this.oCPU.DX.Word, this.oCPU.AX.Low);
			this.oCPU.DX.Low = 0xc9;
			// LEA
			this.oCPU.SI.Word = 0xbd06;
			this.oCPU.CX.Word = 0x1e;
			this.oCPU.AX.High = this.oCPU.ORByte(this.oCPU.AX.High, this.oCPU.AX.High);
			if (this.oCPU.Flags.E) goto L05a5;
			this.oCPU.REPEOUTSByte(this.oCPU.DS, this.oCPU.SI, this.oCPU.CX);
			goto L05a9;

		L05a5:
			this.oCPU.LODSByte();
			this.oCPU.OUTByte(this.oCPU.DX.Word, this.oCPU.AX.Low);
			if (this.oCPU.Loop(this.oCPU.CX)) goto L05a5;

		L05a9:
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, 0xa);
			this.oCPU.DX.Low = 0xda;
			this.oCPU.AX.Low = this.oCPU.INByte(this.oCPU.DX.Word);
			this.oCPU.TESTByte(this.oCPU.AX.Low, 0x8);
			if (this.oCPU.Flags.E) goto L058e;
			this.oCPU.AX.Word = this.oCPU.BX.Word;
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0573'");
		}

		public void F0_1000_05b7()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_05b7'(Cdecl) at 0x1000:0x05b7, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.PushWord(this.oCPU.ES.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x62);
			this.oCPU.CX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x64);
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, this.oCPU.CX.Word);
			this.oCPU.AX.High = 0x0;
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x62, this.oCPU.AX.Word);
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.SI.Word = this.oCPU.ADDWord(this.oCPU.SI.Word, this.oCPU.AX.Word);
			this.oCPU.SI.Word = this.oCPU.ADDWord(this.oCPU.SI.Word, this.oCPU.AX.Word);
			// LEA
			this.oCPU.DI.Word = 0xc006;
			this.oCPU.PushWord(this.oCPU.DS.Word);
			this.oCPU.ES.Word = this.oCPU.PopWord();
			this.oCPU.AX.Word = this.oCPU.CX.Word;
			this.oCPU.CX.Word = this.oCPU.ADDWord(this.oCPU.CX.Word, this.oCPU.AX.Word);
			this.oCPU.CX.Word = this.oCPU.ADDWord(this.oCPU.CX.Word, this.oCPU.AX.Word);

		L05db:
			this.oCPU.BX.Word = 0x0;
			this.oCPU.BP.Word = 0x0;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x42fa));
			this.oCPU.AX.High = 0x0;
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L05f7;
			this.oCPU.DX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6a);
			this.oCPU.DX.Word = this.oCPU.NOTWord(this.oCPU.DX.Word);
			this.oCPU.MULWord(this.oCPU.DX, this.oCPU.AX, this.oCPU.DX.Word);
			this.oCPU.BP.Word = this.oCPU.AX.Word;
			this.oCPU.BX.Word = this.oCPU.DX.Word;

		L05f7:
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x45fa));
			this.oCPU.AX.High = 0x0;
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L0609;
			this.oCPU.MULWord(this.oCPU.DX, this.oCPU.AX, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6a));
			this.oCPU.BP.Word = this.oCPU.ADDWord(this.oCPU.BP.Word, this.oCPU.AX.Word);
			this.oCPU.BX.Word = this.oCPU.ADCWord(this.oCPU.BX.Word, this.oCPU.DX.Word);

		L0609:
			this.oCPU.BP.Word = this.oCPU.SHLWord(this.oCPU.BP.Word, 0x1);
			this.oCPU.BX.Word = this.oCPU.ADCWord(this.oCPU.BX.Word, 0x0);
			this.oCPU.AX.Low = this.oCPU.BX.Low;
			this.oCPU.STOSByte();
			this.oCPU.SI.Word = this.oCPU.INCWord(this.oCPU.SI.Word);
			this.oCPU.CMPWord(this.oCPU.SI.Word, 0x300);
			if (this.oCPU.Flags.B) goto L062a;
			this.oCPU.SI.Word = 0x0;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6c);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6a, this.oCPU.ADDWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6a), this.oCPU.AX.Word));
			if (this.oCPU.Flags.AE) goto L062a;
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6a, 0xffff);

		L062a:
			if (this.oCPU.Loop(this.oCPU.CX)) goto L05db;
			this.oCPU.ES.Word = this.oCPU.PopWord();
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_05b7'");
		}

		public void F0_1000_066a()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_066a'(Cdecl) at 0x1000:0x066a, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.PushWord(this.oCPU.ES.Word);
			this.oCPU.AX.High = 0x35;
			this.oCPU.AX.Low = 0x24;
			this.oCPU.INT(0x21);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6e, this.oCPU.ES.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x70, this.oCPU.BX.Word);
			this.oCPU.AX.High = 0x25;
			this.oCPU.AX.Low = 0x24;
			this.oCPU.DX.Word = 0x718;
			this.oCPU.PushWord(this.oCPU.DS.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word);
			this.oCPU.DS.Word = this.oCPU.PopWord();
			this.oCPU.INT(0x21);
			this.oCPU.DS.Word = this.oCPU.PopWord();
			this.oCPU.AX.Word = 0x3b01;
			this.oCPU.ES.Word = this.oCPU.AX.Word;
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.DI.Word = 0x73;
			this.oCPU.AX.Word = 0x2900;
			this.oCPU.INT(0x21);
			this.oCPU.WriteWord(this.oCPU.CS.Word, 0x668, 0x0);
			this.oCPU.AX.High = 0x11;
			this.oCPU.DX.Word = 0x73;
			this.oCPU.INT(0x21);
			this.oCPU.AX.Low = this.oCPU.ORByte(this.oCPU.AX.Low, this.oCPU.AX.Low);
			if (this.oCPU.Flags.E) goto L0700;
			this.oCPU.AX.High = 0xe;
			this.oCPU.DX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.INT(0x21);
			this.oCPU.WriteWord(this.oCPU.CS.Word, 0x668, 0x0);
			this.oCPU.AX.High = 0x11;
			this.oCPU.DX.Word = 0x73;
			this.oCPU.INT(0x21);
			this.oCPU.AX.Low = this.oCPU.ORByte(this.oCPU.AX.Low, this.oCPU.AX.Low);
			if (this.oCPU.Flags.NE) goto L06ce;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.CS.Word, 0x668), 0x0);
			if (this.oCPU.Flags.E) goto L0700;

		L06ce:
			this.oCPU.INT(0x11);
			this.oCPU.AX.Low = this.oCPU.ROLByte(this.oCPU.AX.Low, 0x1);
			this.oCPU.AX.Low = this.oCPU.ROLByte(this.oCPU.AX.Low, 0x1);
			this.oCPU.AX.Low = this.oCPU.ANDByte(this.oCPU.AX.Low, 0x3);
			if (this.oCPU.Flags.NE) goto L06de;

		L06d8:
			this.oCPU.AX.Word = 0xffff;
			goto L0700;

		L06de:
			this.oCPU.WriteWord(this.oCPU.CS.Word, 0x668, 0x0);
			this.oCPU.AX.High = 0x19;
			this.oCPU.INT(0x21);
			this.oCPU.AX.Low = this.oCPU.XORByte(this.oCPU.AX.Low, 0x1);
			this.oCPU.DX.Low = this.oCPU.AX.Low;
			this.oCPU.AX.High = 0xe;
			this.oCPU.INT(0x21);
			this.oCPU.AX.High = 0x11;
			this.oCPU.DX.Word = 0x73;
			this.oCPU.INT(0x21);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.CS.Word, 0x668), 0x0);
			if (this.oCPU.Flags.NE) goto L06d8;

		L0700:
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.High = 0x25;
			this.oCPU.AX.Low = 0x24;
			this.oCPU.PushWord(this.oCPU.DS.Word);
			this.oCPU.DS.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6e);
			this.oCPU.DX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x70);
			this.oCPU.INT(0x21);
			this.oCPU.DS.Word = this.oCPU.PopWord();
			this.oCPU.AX.Word = this.oCPU.PopWord();
			this.oCPU.ES.Word = this.oCPU.PopWord();
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_066a'");
		}

		public void F0_1000_0732()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0732'(Undefined) at 0x1000:0x0732, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, 0x5403), 0x0);
			if (this.oCPU.Flags.NE) goto L0745;
			this.oCPU.WriteWord(this.oCPU.CS.Word, 0x743, this.oCPU.PopWord());
			// Instruction address 0x1000:0x0740, size: 5
			this.oCPU.JmpF(this.oCPU.ReadDWord(this.oCPU.CS.Word, 0x0));
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0732'");
			return;

		L0745:
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x5402, 0x1);
			this.oCPU.WriteWord(this.oCPU.CS.Word, 0x75c, this.oCPU.PopWord());
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5404, this.oCPU.PopWord());
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5406, this.oCPU.PopWord());
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x075e); // stack management - push return offset
			// Instruction address 0x1000:0x0759, size: 5
			this.oCPU.CallF(this.oCPU.ReadDWord(this.oCPU.CS.Word, 0x0));
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment

		L075e:
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x5402, this.oCPU.DECByte(this.oCPU.ReadByte(this.oCPU.DS.Word, 0x5402)));
			if (this.oCPU.Flags.E) goto L0769;
			this.oCPU.PushWord(0x0767); // stack management - push return offset
			// Instruction address 0x1000:0x0764, size: 3
			F0_1000_179a();
			this.oCPU.PopWord(); // stack management - pop return offset
			goto L075e;

		L0769:
			// Instruction address 0x1000:0x0769, size: 4
			this.oCPU.JmpF(this.oCPU.ReadDWord(this.oCPU.DS.Word, 0x5404));
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0732'");
			return;
		}

		public void F0_1000_076f()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_076f'(Undefined) at 0x1000:0x076f, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x076f, size: 5
			this.oParent.EGA.F0_0000_0d60();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_076f'");
			return;
		}

		public void F0_1000_0776()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0776'(Undefined) at 0x1000:0x0776, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x0776, size: 5
			this.oParent.EGA.F0_0000_0d44();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0776'");
			return;
		}

		public void F0_1000_077d()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_077d'(Undefined) at 0x1000:0x077d, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x077d, size: 5
			this.oParent.EGA.F0_0000_193a();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_077d'");
			return;
		}

		public void F0_1000_0784()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0784'(Undefined) at 0x1000:0x0784, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x0784, size: 5
			this.oParent.EGA.F0_0000_009a();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0784'");
			return;
		}

		public void F0_1000_078b()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_078b'(Undefined) at 0x1000:0x078b, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x078b, size: 5
			this.oParent.EGA.F0_0000_23df();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_078b'");
			return;
		}

		public void F0_1000_0797()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0797'(Undefined) at 0x1000:0x0797, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(0x079a); // stack management - push return offset
			// Instruction address 0x1000:0x0797, size: 3
			F0_1000_0732();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			// Instruction address 0x1000:0x07a0, size: 5
			this.oParent.EGA.F0_0000_1796();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0797'");
			return;
		}

		public void F0_1000_07a0()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_07a0'(Undefined) at 0x1000:0x07a0, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x07a0, size: 5
			this.oParent.EGA.F0_0000_1796();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_07a0'");
			return;
		}

		public void F0_1000_07b5()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_07b5'(Undefined) at 0x1000:0x07b5, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x07b5, size: 5
			this.oParent.EGA.F0_0000_105e();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_07b5'");
			return;
		}

		public void F0_1000_07c3()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_07c3'(Undefined) at 0x1000:0x07c3, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x07c3, size: 5
			this.oParent.EGA.F0_0000_2430();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_07c3'");
			return;
		}

		public void F0_1000_07ca()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_07ca'(Undefined) at 0x1000:0x07ca, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x07ca, size: 5
			this.oParent.EGA.F0_0000_09af();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_07ca'");
			return;
		}

		public void F0_1000_07d1()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_07d1'(Undefined) at 0x1000:0x07d1, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x07d1, size: 5
			this.oParent.EGA.F0_0000_0964();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_07d1'");
			return;
		}

		public void F0_1000_07d6()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_07d6'(Undefined) at 0x1000:0x07d6, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(0x07d9); // stack management - push return offset
			// Instruction address 0x1000:0x07d6, size: 3
			F0_1000_0732();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			// Instruction address 0x1000:0x07df, size: 5
			this.oParent.EGA.F0_0000_238f();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_07d6'");
			return;
		}

		public void F0_1000_07ed()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_07ed'(Undefined) at 0x1000:0x07ed, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x07ed, size: 5
			this.oParent.EGA.F0_0000_176a();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_07ed'");
			return;
		}

		public void F0_1000_07f4()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_07f4'(Undefined) at 0x1000:0x07f4, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x07f4, size: 5
			this.oParent.EGA.F0_0000_0a23();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_07f4'");
			return;
		}

		public void F0_1000_07fb()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_07fb'(Undefined) at 0x1000:0x07fb, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x07fb, size: 5
			this.oParent.EGA.F0_0000_130a();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_07fb'");
			return;
		}

		public void F0_1000_0802()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0802'(Undefined) at 0x1000:0x0802, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x0802, size: 5
			this.oParent.EGA.F0_0000_2459();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0802'");
			return;
		}

		public void F0_1000_081e()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_081e'(Undefined) at 0x1000:0x081e, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x081e, size: 5
			this.oParent.EGA.F0_0000_0d4e();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_081e'");
			return;
		}

		public void F0_1000_082c()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_082c'(Undefined) at 0x1000:0x082c, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x082c, size: 5
			this.oParent.EGA.F0_0000_04a3();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_082c'");
			return;
		}

		public void F0_1000_0833()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0833'(Undefined) at 0x1000:0x0833, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x0833, size: 5
			this.oParent.EGA.F0_0000_04ca();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0833'");
			return;
		}

		public void F0_1000_083f()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_083f'(Undefined) at 0x1000:0x083f, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(0x0842); // stack management - push return offset
			// Instruction address 0x1000:0x083f, size: 3
			F0_1000_0732();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			this.oCPU.PushWord(0x0849); // stack management - push return offset
			// Instruction address 0x1000:0x0846, size: 3
			F0_1000_0732();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			this.oCPU.PushWord(0x0850); // stack management - push return offset
			// Instruction address 0x1000:0x084d, size: 3
			F0_1000_0732();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			// Instruction address 0x1000:0x0856, size: 5
			this.oParent.EGA.F0_0000_1859();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_083f'");
			return;
		}

		public void F0_1000_0846()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0846'(Undefined) at 0x1000:0x0846, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(0x0849); // stack management - push return offset
			// Instruction address 0x1000:0x0846, size: 3
			F0_1000_0732();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			this.oCPU.PushWord(0x0850); // stack management - push return offset
			// Instruction address 0x1000:0x084d, size: 3
			F0_1000_0732();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			// Instruction address 0x1000:0x0856, size: 5
			this.oParent.EGA.F0_0000_1859();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0846'");
			return;
		}

		public void F0_1000_084d()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_084d'(Undefined) at 0x1000:0x084d, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(0x0850); // stack management - push return offset
			// Instruction address 0x1000:0x084d, size: 3
			F0_1000_0732();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word), this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word)), this.oCPU.AX.Low));
			// Instruction address 0x1000:0x0856, size: 5
			this.oParent.EGA.F0_0000_1859();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_084d'");
			return;
		}

		public void F0_1000_0856()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0856'(Undefined) at 0x1000:0x0856, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x0856, size: 5
			this.oParent.EGA.F0_0000_1859();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0856'");
			return;
		}

		public void F0_1000_085d()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_085d'(Undefined) at 0x1000:0x085d, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x085d, size: 5
			this.oParent.EGA.F0_0000_1876();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_085d'");
			return;
		}

		public void F0_1000_0864()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0864'(Undefined) at 0x1000:0x0864, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x0864, size: 5
			this.oParent.EGA.F0_0000_17c4();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0864'");
			return;
		}

		public void F0_1000_0872()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0872'(Undefined) at 0x1000:0x0872, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x0872, size: 5
			this.oParent.EGA.F0_0000_0d74();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0872'");
			return;
		}

		public void F0_1000_0879()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0879'(Undefined) at 0x1000:0x0879, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x0879, size: 5
			this.oParent.EGA.F0_0000_0e3c();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0879'");
			return;
		}

		public void F0_1000_0880()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0880'(Undefined) at 0x1000:0x0880, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x0880, size: 5
			this.oParent.EGA.F0_0000_0bca();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0880'");
			return;
		}

		public void F0_1000_0887()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0887'(Undefined) at 0x1000:0x0887, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x0887, size: 5
			this.oParent.EGA.F0_0000_05b9();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0887'");
			return;
		}

		public void F0_1000_088e()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_088e'(Undefined) at 0x1000:0x088e, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x088e, size: 5
			this.oParent.EGA.F0_0000_058c();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_088e'");
			return;
		}

		public void F0_1000_0895()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0895'(Undefined) at 0x1000:0x0895, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x0895, size: 5
			this.oParent.EGA.F0_0000_0e94();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0895'");
			return;
		}

		public void F0_1000_08bf()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_08bf'(Undefined) at 0x1000:0x08bf, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x08bf, size: 5
			this.oParent.EGA.F0_0000_0d36();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_08bf'");
			return;
		}

		public void F0_1000_08c6()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_08c6'(Undefined) at 0x1000:0x08c6, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x08c6, size: 5
			this.oParent.EGA.F0_0000_0d1f();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_08c6'");
			return;
		}

		public void F0_1000_09ec()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_09ec'(Undefined) at 0x1000:0x09ec, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x09ec, size: 5
			this.oParent.Misc.F0_0000_0047();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_09ec'");
			return;
		}

		public void F0_1000_09f3()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_09f3'(Undefined) at 0x1000:0x09f3, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x09f3, size: 5
			this.oParent.Misc.F0_0000_0042();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_09f3'");
			return;
		}

		public void F0_1000_0a2b()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0a2b'(Undefined) at 0x1000:0x0a2b, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x0a2b, size: 5
			this.oParent.NSound.F0_0000_0048();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0a2b'");
			return;
		}

		public void F0_1000_0a32()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0a32'(Undefined) at 0x1000:0x0a32, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x0a32, size: 5
			this.oParent.NSound.F0_0000_0062();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0a32'");
			return;
		}

		public void F0_1000_0a39()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0a39'(Undefined) at 0x1000:0x0a39, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x0a39, size: 5
			this.oParent.NSound.F0_0000_006a();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0a39'");
			return;
		}

		public void F0_1000_0a4e()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0a4e'(Undefined) at 0x1000:0x0a4e, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// Instruction address 0x1000:0x0a4e, size: 5
			this.oParent.NSound.F0_0000_005d();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0a4e'");
			return;
		}

		public void F0_1000_0a76()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0a76'(Cdecl) at 0x1000:0x0a76, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.AX.High = 0x48;
			this.oCPU.BX.Word = 0xffff;
			this.oCPU.INT(0x21);
			if (this.oCPU.Flags.B) goto L0a89;
			// LEA
			this.oCPU.SI.Word = 0x5412;
			goto L0bdb;

		L0a89:
			this.oCPU.AX.High = 0x48;
			this.oCPU.BX.Word = this.oCPU.SUBWord(this.oCPU.BX.Word, 0x100);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x540c, this.oCPU.BX.Word);
			this.oCPU.INT(0x21);
			if (this.oCPU.Flags.AE) goto L0a9e;
			// LEA
			this.oCPU.SI.Word = 0x542d;
			goto L0bdb;

		L0a9e:
			this.oCPU.PushWord(this.oCPU.DS.Word);
			this.oCPU.ES.Word = this.oCPU.PopWord();
			// LEA
			this.oCPU.BX.Word = 0x5408;
			this.oCPU.WriteWord(this.oCPU.DS.Word, this.oCPU.BX.Word, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x2), this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x4b03;
			this.oCPU.DX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.PushWord(0x0ab2); // stack management - push return offset
			// Instruction address 0x1000:0x0aaf, size: 3
			F0_1000_0bba_LoadOverlay();
			this.oCPU.PopWord(); // stack management - pop return offset
			if (this.oCPU.Flags.AE) goto L0ad5;
			this.oCPU.CMPWord(this.oCPU.AX.Word, 0x2);
			if (this.oCPU.Flags.NE) goto L0ac0;
			// LEA
			this.oCPU.SI.Word = 0x5463;
			goto L0bdb;

		L0ac0:
			this.oCPU.CMPWord(this.oCPU.AX.Word, 0x8);
			if (this.oCPU.Flags.NE) goto L0acc;
			// LEA
			this.oCPU.SI.Word = 0x5476;
			goto L0bdb;

		L0acc:
			if (this.oCPU.Flags.E) goto L0ad5;
			// LEA
			this.oCPU.SI.Word = 0x5495;
			goto L0bdb;

		L0ad5:
			this.oCPU.ES.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5408);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.ES.Word, 0x2a);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.ES.Word, 0x2c);
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0xf);
			this.oCPU.AX.Word = this.oCPU.RCRWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.SHRWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.SHRWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.SHRWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, this.oCPU.AX.Word);
			this.oCPU.DX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.DX.Word = this.oCPU.ORWord(this.oCPU.DX.Word, this.oCPU.DX.Word);
			if (this.oCPU.Flags.E) goto L0af9;
			this.oCPU.PushWord(0x0af9); // stack management - push return offset
			// Instruction address 0x1000:0x0af6, size: 3
			F0_1000_0b1e();
			this.oCPU.PopWord(); // stack management - pop return offset

		L0af9:
			this.oCPU.AX.Word = this.oCPU.ES.Word;
			this.oCPU.BX.Word = this.oCPU.SUBWord(this.oCPU.BX.Word, this.oCPU.AX.Word);
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, 0x8);
			this.oCPU.CMPWord(this.oCPU.BX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x540c));
			if (this.oCPU.Flags.BE) goto L0b0d;
			// LEA
			this.oCPU.SI.Word = 0x54b9;
			goto L0bdb;

		L0b0d:
			this.oCPU.AX.High = 0x4a;
			this.oCPU.INT(0x21);
			if (this.oCPU.Flags.AE) goto L0b1a;
			// LEA
			this.oCPU.SI.Word = 0x54de;
			goto L0bdb;

		L0b1a:
			this.oCPU.AX.Word = this.oCPU.ES.Word;
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0a76'");
			return;

		L0bdb:
			this.oCPU.AX.High = 0x2;
			this.oCPU.CMPByte(this.oCPU.AX.Low, 0xa);
			this.oCPU.AX.Low = this.oCPU.SBBByte(this.oCPU.AX.Low, 0x69);
			this.oCPU.DAS();
			this.oCPU.DX.Low = this.oCPU.AX.Low;
			this.oCPU.INT(0x21);
			// LEA
			this.oCPU.DX.Word = 0x540e;
			this.oCPU.AX.High = 0x9;
			this.oCPU.INT(0x21);
			this.oCPU.AX.High = 0x9;
			this.oCPU.DX.Word = this.oCPU.SI.Word;
			this.oCPU.INT(0x21);
			this.oCPU.AX.Word = 0x4c99;
			this.oCPU.INT(0x21);
		}

		public void F0_1000_0b1e()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0b1e'(Cdecl) at 0x1000:0x0b1e, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.DS.Word);
			this.oCPU.AX.Word = 0x3d00;
			this.oCPU.INT(0x21);
			if (this.oCPU.Flags.AE) goto L0b2d;
			// LEA
			this.oCPU.SI.Word = 0x5463;
			goto L0bdb;

		L0b2d:
			this.oCPU.DS.Word = this.oCPU.BX.Word;
			this.oCPU.BX.Word = this.oCPU.AX.Word;

		L0b31:
			this.oCPU.AX.High = 0x3f;
			this.oCPU.DX.Word = 0x0;
			this.oCPU.CX.Word = 0x8000;
			this.oCPU.INT(0x21);
			if (this.oCPU.Flags.AE) goto L0b43;
			// LEA
			this.oCPU.SI.Word = 0x5463;
			goto L0bdb;

		L0b43:
			this.oCPU.CMPWord(this.oCPU.AX.Word, this.oCPU.CX.Word);
			if (this.oCPU.Flags.B) goto L0b50;
			this.oCPU.AX.Word = this.oCPU.DS.Word;
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0x800);
			this.oCPU.DS.Word = this.oCPU.AX.Word;
			goto L0b31;

		L0b50:
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0xf);
			this.oCPU.AX.Word = this.oCPU.RCRWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.SHRWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.SHRWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.SHRWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.DX.Word = this.oCPU.DS.Word;
			this.oCPU.DX.Word = this.oCPU.ADDWord(this.oCPU.DX.Word, this.oCPU.AX.Word);
			this.oCPU.AX.High = 0x3e;
			this.oCPU.INT(0x21);
			if (this.oCPU.Flags.AE) goto L0b6c;
			// LEA
			this.oCPU.SI.Word = 0x5463;
			goto L0bdb;

		L0b6c:
			this.oCPU.BX.Word = this.oCPU.DX.Word;
			this.oCPU.DS.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0b1e'");
			return;

		L0bdb:
			this.oCPU.AX.High = 0x2;
			this.oCPU.CMPByte(this.oCPU.AX.Low, 0xa);
			this.oCPU.AX.Low = this.oCPU.SBBByte(this.oCPU.AX.Low, 0x69);
			this.oCPU.DAS();
			this.oCPU.DX.Low = this.oCPU.AX.Low;
			this.oCPU.INT(0x21);
			// LEA
			this.oCPU.DX.Word = 0x540e;
			this.oCPU.AX.High = 0x9;
			this.oCPU.INT(0x21);
			this.oCPU.AX.High = 0x9;
			this.oCPU.DX.Word = this.oCPU.SI.Word;
			this.oCPU.INT(0x21);
			this.oCPU.AX.Word = 0x4c99;
			this.oCPU.INT(0x21);
		}

		public void F0_1000_0b70()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0b70'(Cdecl) at 0x1000:0x0b70, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.PushWord(this.oCPU.DS.Word);
			this.oCPU.DS.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.SI.Word = 0x32;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x2e);
			this.oCPU.DX.Low = 0x7;
			this.oCPU.MULByte(this.oCPU.AX, this.oCPU.DX.Low);
			// LEA
			this.oCPU.DI.Word = 0x76d;
			this.oCPU.DI.Word = this.oCPU.ADDWord(this.oCPU.DI.Word, this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x1000;
			this.oCPU.ES.Word = this.oCPU.AX.Word;
			this.oCPU.CX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x30);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x28);

		L0b95:
			this.oCPU.DI.Word = this.oCPU.ADDWord(this.oCPU.DI.Word, 0x3);
			this.oCPU.MOVSWord(this.oCPU.DS, this.oCPU.SI, this.oCPU.ES, this.oCPU.DI);
			this.oCPU.STOSWord();
			if (this.oCPU.Loop(this.oCPU.CX)) goto L0b95;
			this.oCPU.DS.Word = this.oCPU.PopWord();
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0b70'");
		}

		public void F0_1000_0bba_LoadOverlay()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0bba'(Cdecl) at 0x1000:0x0bba, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			// DS:DX = pointer to an ASCIIZ filename
			// ES:BX = pointer to a parameter block
			string sFileName = this.oCPU.ReadString(CPUMemory.ToLinearAddress(this.oCPU.DS.Word, this.oCPU.DX.Word));
			ushort usSegment = this.oCPU.Memory.ReadWord(CPUMemory.ToLinearAddress(this.oCPU.ES.Word, this.oCPU.BX.Word));

			switch (sFileName.ToLower())
			{
				case "misc.exe":
					this.oParent.Misc.Segment = usSegment;
					break;

				case "mgraphic.exe":
					this.oParent.EGA.Segment = usSegment;
					break;

				case "nsound.cvl":
					this.oParent.NSound.Segment = usSegment;
					break;

				default:
					throw new Exception("Unknown overlay name");
			}

			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.PushWord(this.oCPU.DS.Word);
			this.oCPU.PushWord(this.oCPU.ES.Word);
			this.oCPU.WriteWord(this.oCPU.CS.Word, 0xbb8, this.oCPU.SS.Word);
			this.oCPU.WriteWord(this.oCPU.CS.Word, 0xbb6, this.oCPU.SP.Word);
			this.oCPU.INT(0x21);
			this.oCPU.SS.Word = this.oCPU.ReadWord(this.oCPU.CS.Word, 0xbb8);
			this.oCPU.SP.Word = this.oCPU.ReadWord(this.oCPU.CS.Word, 0xbb6);
			this.oCPU.ES.Word = this.oCPU.PopWord();
			this.oCPU.DS.Word = this.oCPU.PopWord();
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0bba'");
		}

		public void F0_1000_0bfa()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0bfa'(Cdecl) at 0x1000:0x0bfa, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.AX.Word = 0x0;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xc)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.LE) goto L0c6d;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xe)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.LE) goto L0c6d;
			this.oCPU.PushWord(0x0c0e); // stack management - push return offset
			// Instruction address 0x1000:0x0c0b, size: 3
			F0_1000_0c8e();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, this.oCPU.BX.Word);
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x0c18); // stack management - push return offset
			// Instruction address 0x1000:0x0c13, size: 5
			F0_1000_08bf();
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xa));
			this.oCPU.SI.Word = this.oCPU.ADDWord(this.oCPU.SI.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x4)));
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5858, this.oCPU.SI.Word);
			this.oCPU.CX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xe));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			// LEA
			this.oCPU.DI.Word = 0x5534;
			this.oCPU.DI.Word = this.oCPU.ADDWord(this.oCPU.DI.Word, this.oCPU.SI.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x2)));
			this.oCPU.DX.Word = this.oCPU.CX.Word;
			this.oCPU.REPESTOSWord();
			this.oCPU.CX.Word = this.oCPU.DX.Word;
			// LEA
			this.oCPU.DI.Word = 0x56c4;
			this.oCPU.DI.Word = this.oCPU.ADDWord(this.oCPU.DI.Word, this.oCPU.SI.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x2)));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xc)));
			this.oCPU.AX.Word = this.oCPU.DECWord(this.oCPU.AX.Word);
			this.oCPU.REPESTOSWord();
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x10));
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x0c53); // stack management - push return offset
			// Instruction address 0x1000:0x0c4e, size: 5
			F0_1000_088e();
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5858);
			this.oCPU.CX.Word = this.oCPU.AX.Word;
			this.oCPU.CX.Word = this.oCPU.ADDWord(this.oCPU.CX.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xe)));
			this.oCPU.CX.Word = this.oCPU.DECWord(this.oCPU.CX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x585a, this.oCPU.CX.Word);
			this.oCPU.BX.Word = 0x5534;
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x0c68); // stack management - push return offset
			// Instruction address 0x1000:0x0c63, size: 5
			F0_1000_0880();
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x0c6d); // stack management - push return offset
			// Instruction address 0x1000:0x0c68, size: 5
			F0_1000_0887();
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment

		L0c6d:
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0bfa'");
		}

		public void F0_1000_0c8e()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0c8e'(Cdecl) at 0x1000:0x0c8e, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.AX.Word = 0x3b01;
			this.oCPU.ES.Word = this.oCPU.AX.Word;
			this.oCPU.DI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5858);
			this.oCPU.DI.Word = this.oCPU.ORWord(this.oCPU.DI.Word, this.oCPU.DI.Word);
			if (this.oCPU.Flags.S) goto L0cc3;
			this.oCPU.CX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x585a);
			this.oCPU.CX.Word = this.oCPU.INCWord(this.oCPU.CX.Word);
			this.oCPU.CX.Word = this.oCPU.SUBWord(this.oCPU.CX.Word, this.oCPU.DI.Word);
			this.oCPU.DI.Word = this.oCPU.SHLWord(this.oCPU.DI.Word, 0x1);
			this.oCPU.BX.Word = this.oCPU.CX.Word;
			this.oCPU.DX.Word = this.oCPU.DI.Word;
			this.oCPU.DI.Word = this.oCPU.ADDWord(this.oCPU.DI.Word, 0x5534);
			this.oCPU.AX.Word = 0xffff;
			this.oCPU.REPESTOSWord();
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5858, this.oCPU.AX.Word);
			this.oCPU.CX.Word = this.oCPU.BX.Word;
			this.oCPU.DI.Word = this.oCPU.DX.Word;
			this.oCPU.DI.Word = this.oCPU.ADDWord(this.oCPU.DI.Word, 0x56c4);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.REPESTOSWord();
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x585a, this.oCPU.AX.Word);

		L0cc3:
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0c8e'");
		}

		public void F0_1000_0e3c()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0e3c'(Cdecl) at 0x1000:0x0e3c, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.ES.Word = this.oCPU.AX.Word;
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.ES.Word, 0x0));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.ES.Word, 0x2));
			// LEA
			this.oCPU.AX.Word = 0xfe9;
			this.oCPU.WriteWord(this.oCPU.ES.Word, 0x0, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.ES.Word, 0x2, 0x1000);
			this.oCPU.PushWord(this.oCPU.DS.Word);
			this.oCPU.ES.Word = this.oCPU.PopWord();
			goto L0ec4;

		L0e5e:
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.ES.Word = this.oCPU.AX.Word;
			this.oCPU.WriteWord(this.oCPU.ES.Word, 0x2, this.oCPU.PopWord());
			this.oCPU.WriteWord(this.oCPU.ES.Word, 0x0, this.oCPU.PopWord());
			this.oCPU.PushWord(this.oCPU.DS.Word);
			this.oCPU.ES.Word = this.oCPU.PopWord();
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x552c);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5530);
			this.oCPU.CX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x552e);
			this.oCPU.DX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5532);
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x0e82); // stack management - push return offset
			// Instruction address 0x1000:0x0e7d, size: 5
			F0_1000_0895();
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.Flags.C = false;
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0e3c'");
			return;

		L0e84:
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.ES.Word = this.oCPU.AX.Word;
			this.oCPU.WriteWord(this.oCPU.ES.Word, 0x2, this.oCPU.PopWord());
			this.oCPU.WriteWord(this.oCPU.ES.Word, 0x0, this.oCPU.PopWord());
			this.oCPU.PushWord(this.oCPU.DS.Word);
			this.oCPU.ES.Word = this.oCPU.PopWord();
			this.oCPU.Flags.C = true;
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0e3c'");
			return;

		L0e96:
			this.oCPU.Flags.C = !this.oCPU.Flags.C;
			this.oCPU.DX.Word = this.oCPU.RCRWord(this.oCPU.DX.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5861, this.oCPU.DX.Word);
			this.oCPU.DX.Word = this.oCPU.SARWord(this.oCPU.DX.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5865, this.oCPU.DX.Word);
			this.oCPU.DX.Word = this.oCPU.DI.Word;
			this.oCPU.DX.Word = this.oCPU.SUBWord(this.oCPU.DX.Word, this.oCPU.BP.Word);
			if (this.oCPU.Flags.NO) goto L0eaf;
			this.oCPU.Flags.C = !this.oCPU.Flags.C;
			this.oCPU.DX.Word = this.oCPU.RCRWord(this.oCPU.DX.Word, 0x1);
			goto L0f1f;

		L0eaf:
			this.oCPU.DX.Word = this.oCPU.SARWord(this.oCPU.DX.Word, 0x1);
			goto L0f1f;

		L0eb4:
			this.oCPU.Flags.C = !this.oCPU.Flags.C;
			this.oCPU.DX.Word = this.oCPU.RCRWord(this.oCPU.DX.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5861, this.oCPU.SARWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5861), 0x1));
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5865, this.oCPU.SARWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5865), 0x1));
			goto L0f1f;

		L0ec2:
			goto L0e84;

		L0ec4:
			this.oCPU.CX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x552c);
			this.oCPU.DX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5530);
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x552e);
			this.oCPU.DI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5532);
			this.oCPU.BX.Word = this.oCPU.CX.Word;
			this.oCPU.BP.Word = this.oCPU.DX.Word;
			this.oCPU.PushWord(0x0edb); // stack management - push return offset
			// Instruction address 0x1000:0x0ed8, size: 3
			F0_1000_0fc8();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x5860, this.oCPU.AX.Low);
			this.oCPU.BX.Word = this.oCPU.SI.Word;
			this.oCPU.BP.Word = this.oCPU.DI.Word;
			this.oCPU.PushWord(0x0ee5); // stack management - push return offset
			// Instruction address 0x1000:0x0ee2, size: 3
			F0_1000_0fc8();
			this.oCPU.PopWord(); // stack management - pop return offset
			if (this.oCPU.Flags.NE) goto L0f01;
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, 0x5860), 0x0);
			if (this.oCPU.Flags.NE) goto L0ef1;
			goto L0e5e;

		L0ef1:
			this.oCPU.Temp.Word = this.oCPU.SI.Word;
			this.oCPU.SI.Word = this.oCPU.CX.Word;
			this.oCPU.CX.Word = this.oCPU.Temp.Word;
			this.oCPU.Temp.Word = this.oCPU.DI.Word;
			this.oCPU.DI.Word = this.oCPU.DX.Word;
			this.oCPU.DX.Word = this.oCPU.Temp.Word;
			this.oCPU.Temp.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, 0x5860);
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x5860, this.oCPU.AX.Low);
			this.oCPU.AX.Low = this.oCPU.Temp.Low;
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x552c, this.oCPU.CX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5530, this.oCPU.DX.Word);

		L0f01:
			this.oCPU.TESTByte(this.oCPU.AX.Low, this.oCPU.ReadByte(this.oCPU.DS.Word, 0x5860));
			if (this.oCPU.Flags.NE) goto L0ec2;
			this.oCPU.BP.Word = this.oCPU.DX.Word;
			this.oCPU.DX.Word = this.oCPU.SI.Word;
			this.oCPU.DX.Word = this.oCPU.SUBWord(this.oCPU.DX.Word, this.oCPU.CX.Word);
			if (this.oCPU.Flags.O) goto L0e96;
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5861, this.oCPU.DX.Word);
			this.oCPU.DX.Word = this.oCPU.SARWord(this.oCPU.DX.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5865, this.oCPU.DX.Word);
			this.oCPU.DX.Word = this.oCPU.DI.Word;
			this.oCPU.DX.Word = this.oCPU.SUBWord(this.oCPU.DX.Word, this.oCPU.BP.Word);
			if (this.oCPU.Flags.O) goto L0eb4;

		L0f1f:
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5863, this.oCPU.DX.Word);
			this.oCPU.DX.Word = this.oCPU.SARWord(this.oCPU.DX.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5867, this.oCPU.DX.Word);

		L0f29:
			this.oCPU.TESTByte(this.oCPU.AX.Low, 0x9);
			if (this.oCPU.Flags.E) goto L0f65;
			this.oCPU.BX.Word = this.oCPU.SUBWord(this.oCPU.BX.Word, this.oCPU.BX.Word);
			this.oCPU.SI.Word = this.oCPU.ORWord(this.oCPU.SI.Word, this.oCPU.SI.Word);
			if (this.oCPU.Flags.S) goto L0f37;
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5869);

		L0f37:
			this.oCPU.AX.Word = this.oCPU.BX.Word;
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.CX.Word);
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5863));
			this.oCPU.PushWord(this.oCPU.BX.Word);
			this.oCPU.BX.Word = this.oCPU.DX.Word;
			this.oCPU.IDIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5861));
			this.oCPU.BX.Low = this.oCPU.BX.High;
			this.oCPU.BX.Low = this.oCPU.XORByte(this.oCPU.BX.Low, this.oCPU.ReadByte(this.oCPU.DS.Word, 0x5862));
			if (this.oCPU.Flags.NS) goto L0f51;
			this.oCPU.DX.Word = this.oCPU.NEGWord(this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.DECWord(this.oCPU.AX.Word);

		L0f51:
			this.oCPU.DX.Word = this.oCPU.SUBWord(this.oCPU.DX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5865));
			this.oCPU.DX.High = this.oCPU.XORByte(this.oCPU.DX.High, this.oCPU.BX.High);
			if (this.oCPU.Flags.S) goto L0f5a;
			this.oCPU.AX.Word = this.oCPU.INCWord(this.oCPU.AX.Word);

		L0f5a:
			this.oCPU.BX.Word = this.oCPU.PopWord();
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, this.oCPU.BP.Word);
			if (this.oCPU.Flags.S) goto L0f6d;
			this.oCPU.CMPWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x586b));
			if (this.oCPU.Flags.LE) goto L0f9e;

		L0f65:
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x586b);
			this.oCPU.CMPWord(this.oCPU.DI.Word, this.oCPU.BX.Word);
			if (this.oCPU.Flags.G) goto L0f6f;

		L0f6d:
			this.oCPU.BX.Word = this.oCPU.SUBWord(this.oCPU.BX.Word, this.oCPU.BX.Word);

		L0f6f:
			this.oCPU.AX.Word = this.oCPU.BX.Word;
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.BP.Word);
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5861));
			this.oCPU.PushWord(this.oCPU.BX.Word);
			this.oCPU.BX.Word = this.oCPU.DX.Word;
			this.oCPU.IDIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5863));
			this.oCPU.BX.Low = this.oCPU.BX.High;
			this.oCPU.BX.Low = this.oCPU.XORByte(this.oCPU.BX.Low, this.oCPU.ReadByte(this.oCPU.DS.Word, 0x5864));
			if (this.oCPU.Flags.NS) goto L0f89;
			this.oCPU.DX.Word = this.oCPU.NEGWord(this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.DECWord(this.oCPU.AX.Word);

		L0f89:
			this.oCPU.DX.Word = this.oCPU.SUBWord(this.oCPU.DX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5867));
			this.oCPU.DX.High = this.oCPU.XORByte(this.oCPU.DX.High, this.oCPU.BX.High);
			if (this.oCPU.Flags.S) goto L0f92;
			this.oCPU.AX.Word = this.oCPU.INCWord(this.oCPU.AX.Word);

		L0f92:
			this.oCPU.BX.Word = this.oCPU.PopWord();
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, this.oCPU.CX.Word);
			if (this.oCPU.Flags.S) goto L0faf;
			this.oCPU.CMPWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5869));
			if (this.oCPU.Flags.G) goto L0faf;
			this.oCPU.Temp.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.BX.Word;
			this.oCPU.BX.Word = this.oCPU.Temp.Word;

		L0f9e:
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, 0x5860), 0x0);
			if (this.oCPU.Flags.NE) goto L0fb2;
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5532, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x552e, this.oCPU.BX.Word);
			goto L0e5e;

		L0faf:
			goto L0e84;

		L0fb2:
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5530, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x552c, this.oCPU.BX.Word);
			this.oCPU.Temp.Word = this.oCPU.SI.Word;
			this.oCPU.SI.Word = this.oCPU.CX.Word;
			this.oCPU.CX.Word = this.oCPU.Temp.Word;
			this.oCPU.Temp.Word = this.oCPU.DI.Word;
			this.oCPU.DI.Word = this.oCPU.BP.Word;
			this.oCPU.BP.Word = this.oCPU.Temp.Word;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, 0x5860);
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x5860, 0x0);
			goto L0f29;
		}

		public void F0_1000_0fc8()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_0fc8'(Cdecl) at 0x1000:0x0fc8, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.AX.Low = 0xf;
			this.oCPU.BX.Word = this.oCPU.ORWord(this.oCPU.BX.Word, this.oCPU.BX.Word);
			if (this.oCPU.Flags.S) goto L0fd0;
			this.oCPU.AX.Low = this.oCPU.ANDByte(this.oCPU.AX.Low, 0xf7);

		L0fd0:
			this.oCPU.CMPWord(this.oCPU.BX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5869));
			if (this.oCPU.Flags.G) goto L0fd8;
			this.oCPU.AX.Low = this.oCPU.ANDByte(this.oCPU.AX.Low, 0xfe);

		L0fd8:
			this.oCPU.BP.Word = this.oCPU.ORWord(this.oCPU.BP.Word, this.oCPU.BP.Word);
			if (this.oCPU.Flags.S) goto L0fde;
			this.oCPU.AX.Low = this.oCPU.ANDByte(this.oCPU.AX.Low, 0xfb);

		L0fde:
			this.oCPU.CMPWord(this.oCPU.BP.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x586b));
			if (this.oCPU.Flags.G) goto L0fe6;
			this.oCPU.AX.Low = this.oCPU.ANDByte(this.oCPU.AX.Low, 0xfd);

		L0fe6:
			this.oCPU.AX.Low = this.oCPU.ORByte(this.oCPU.AX.Low, this.oCPU.AX.Low);
			this.oParent.LogWriteLine("Exiting function 'F0_1000_0fc8'");
		}

		public void F0_1000_100a()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_100a'(Cdecl) at 0x1000:0x100a, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x6));
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5869, this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x8));
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x586b, this.oCPU.AX.Word);
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x1023); // stack management - push return offset
			// Instruction address 0x1000:0x101e, size: 5
			F0_1000_08c6();
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x552c, this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xa));
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5530, this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xc));
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x552e, this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xe));
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5532, this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x10));
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x1043); // stack management - push return offset
			// Instruction address 0x1000:0x103e, size: 5
			F0_1000_088e();
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.PushWord(0x1046); // stack management - push return offset
			// Instruction address 0x1000:0x1043, size: 3
			F0_1000_0e3c();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x104b); // stack management - push return offset
			// Instruction address 0x1000:0x1046, size: 5
			F0_1000_0887();
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_100a'");
		}

		public void F0_1000_104f()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_104f'(Cdecl) at 0x1000:0x104f, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.CX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.CX.Word = this.oCPU.ORWord(this.oCPU.CX.Word, this.oCPU.CX.Word);
			if (this.oCPU.Flags.S) goto L108a;
			this.oCPU.CMPWord(this.oCPU.CX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x6)));
			if (this.oCPU.Flags.G) goto L108a;
			this.oCPU.DX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xa));
			this.oCPU.DX.Word = this.oCPU.ORWord(this.oCPU.DX.Word, this.oCPU.DX.Word);
			if (this.oCPU.Flags.S) goto L108a;
			this.oCPU.CMPWord(this.oCPU.DX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x8)));
			if (this.oCPU.Flags.G) goto L108a;
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x1074); // stack management - push return offset
			// Instruction address 0x1000:0x106f, size: 5
			F0_1000_08c6();
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xc));
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x107c); // stack management - push return offset
			// Instruction address 0x1000:0x1077, size: 5
			F0_1000_088e();
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.AX.Word = this.oCPU.CX.Word;
			this.oCPU.BX.Word = this.oCPU.DX.Word;
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x1085); // stack management - push return offset
			// Instruction address 0x1000:0x1080, size: 5
			F0_1000_0879();
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x108a); // stack management - push return offset
			// Instruction address 0x1000:0x1085, size: 5
			F0_1000_0887();
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment

		L108a:
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_104f'");
		}

		public void F0_1000_108e()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_108e'(Cdecl) at 0x1000:0x108e, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.AX.Word = 0x0;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x109b); // stack management - push return offset
			// Instruction address 0x1000:0x1096, size: 5
			F0_1000_0833();
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x2);

		L109e:
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb26e);
			this.oCPU.CMPWord(this.oCPU.SI.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5528));
			if (this.oCPU.Flags.B) goto L10b6;
			this.oCPU.PushWord(this.oCPU.BX.Word);
			this.oCPU.PushWord(this.oCPU.CX.Word);
			this.oCPU.PushWord(this.oCPU.DX.Word);
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x10af); // stack management - push return offset
			// Instruction address 0x1000:0x10ab, size: 4
			this.oCPU.CallF(this.oCPU.ReadDWord(this.oCPU.DS.Word, 0xd91a));
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.DX.Word = this.oCPU.PopWord();
			this.oCPU.CX.Word = this.oCPU.PopWord();
			this.oCPU.BX.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb26e);

		L10b6:
			this.oCPU.LODSWord();
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xb26e, this.oCPU.SI.Word);
			this.oCPU.CMPByte(this.oCPU.AX.Low, 0x58);
			if (this.oCPU.Flags.E) goto L1138;
			this.oCPU.DI.Word = this.oCPU.DS.Word;
			this.oCPU.ES.Word = this.oCPU.DI.Word;
			// LEA
			this.oCPU.DI.Word = 0xba06;
			this.oCPU.CMPWord(this.oCPU.AX.Word, 0x304d);
			if (this.oCPU.Flags.NE) goto L10dd;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), 0x1);
			if (this.oCPU.Flags.B) goto L10da;
			if (this.oCPU.Flags.E) goto L10dd;
			this.oCPU.DI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			goto L10dd;

		L10da:
			this.oCPU.DI.Word = this.oCPU.ADDWord(this.oCPU.DI.Word, 0x2);

		L10dd:
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.STOSWord();
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb26e);
			this.oCPU.CMPWord(this.oCPU.SI.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5528));
			if (this.oCPU.Flags.B) goto L10f7;
			this.oCPU.PushWord(this.oCPU.BX.Word);
			this.oCPU.PushWord(this.oCPU.CX.Word);
			this.oCPU.PushWord(this.oCPU.DX.Word);
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x10f0); // stack management - push return offset
			// Instruction address 0x1000:0x10ec, size: 4
			this.oCPU.CallF(this.oCPU.ReadDWord(this.oCPU.DS.Word, 0xd91a));
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.DX.Word = this.oCPU.PopWord();
			this.oCPU.CX.Word = this.oCPU.PopWord();
			this.oCPU.BX.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb26e);

		L10f7:
			this.oCPU.LODSWord();
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xb26e, this.oCPU.SI.Word);
			this.oCPU.STOSWord();
			this.oCPU.CX.Word = this.oCPU.AX.Word;
			this.oCPU.CX.Word = this.oCPU.SHRWord(this.oCPU.CX.Word, 0x1);
			if (this.oCPU.CX.Word == 0) goto L1123;

		L1103:
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb26e);
			this.oCPU.CMPWord(this.oCPU.SI.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5528));
			if (this.oCPU.Flags.B) goto L111b;
			this.oCPU.PushWord(this.oCPU.BX.Word);
			this.oCPU.PushWord(this.oCPU.CX.Word);
			this.oCPU.PushWord(this.oCPU.DX.Word);
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x1114); // stack management - push return offset
			// Instruction address 0x1000:0x1110, size: 4
			this.oCPU.CallF(this.oCPU.ReadDWord(this.oCPU.DS.Word, 0xd91a));
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.DX.Word = this.oCPU.PopWord();
			this.oCPU.CX.Word = this.oCPU.PopWord();
			this.oCPU.BX.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb26e);

		L111b:
			this.oCPU.LODSWord();
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xb26e, this.oCPU.SI.Word);
			this.oCPU.STOSWord();
			if (this.oCPU.Loop(this.oCPU.CX)) goto L1103;

		L1123:
			this.oCPU.DI.Word = this.oCPU.PopWord();
			// LEA
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.CMPWord(this.oCPU.AX.Word, this.oCPU.DI.Word);
			if (this.oCPU.Flags.NE) goto L1135;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x1132); // stack management - push return offset
			// Instruction address 0x1000:0x112d, size: 5
			F0_1000_0833();
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x2);

		L1135:
			goto L109e;

		L1138:
			this.oCPU.AX.High = this.oCPU.ANDByte(this.oCPU.AX.High, 0x1);
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x68f7, this.oCPU.AX.High);
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb26e);
			this.oCPU.CMPWord(this.oCPU.SI.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5528));
			if (this.oCPU.Flags.B) goto L1157;
			this.oCPU.PushWord(this.oCPU.BX.Word);
			this.oCPU.PushWord(this.oCPU.CX.Word);
			this.oCPU.PushWord(this.oCPU.DX.Word);
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x1150); // stack management - push return offset
			// Instruction address 0x1000:0x114c, size: 4
			this.oCPU.CallF(this.oCPU.ReadDWord(this.oCPU.DS.Word, 0xd91a));
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.DX.Word = this.oCPU.PopWord();
			this.oCPU.CX.Word = this.oCPU.PopWord();
			this.oCPU.BX.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb26e);

		L1157:
			this.oCPU.LODSWord();
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xb26e, this.oCPU.SI.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x68e6, this.oCPU.AX.Word);
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb26e);
			this.oCPU.CMPWord(this.oCPU.SI.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5528));
			if (this.oCPU.Flags.B) goto L1177;
			this.oCPU.PushWord(this.oCPU.BX.Word);
			this.oCPU.PushWord(this.oCPU.CX.Word);
			this.oCPU.PushWord(this.oCPU.DX.Word);
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x1170); // stack management - push return offset
			// Instruction address 0x1000:0x116c, size: 4
			this.oCPU.CallF(this.oCPU.ReadDWord(this.oCPU.DS.Word, 0xd91a));
			//this.oParent.Segment_2fa1.
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.DX.Word = this.oCPU.PopWord();
			this.oCPU.CX.Word = this.oCPU.PopWord();
			this.oCPU.BX.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb26e);

		L1177:
			this.oCPU.LODSWord();
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xb26e, this.oCPU.SI.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x68e2, this.oCPU.AX.Word);
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb26e);
			this.oCPU.CMPWord(this.oCPU.SI.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5528));
			if (this.oCPU.Flags.B) goto L1197;
			this.oCPU.PushWord(this.oCPU.BX.Word);
			this.oCPU.PushWord(this.oCPU.CX.Word);
			this.oCPU.PushWord(this.oCPU.DX.Word);
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x1190); // stack management - push return offset
			// Instruction address 0x1000:0x118c, size: 4
			this.oCPU.CallF(this.oCPU.ReadDWord(this.oCPU.DS.Word, 0xd91a));
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.DX.Word = this.oCPU.PopWord();
			this.oCPU.CX.Word = this.oCPU.PopWord();
			this.oCPU.BX.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb26e);

		L1197:
			this.oCPU.LODSWord();
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xb26e, this.oCPU.SI.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x68e4, this.oCPU.AX.Word);
			this.oCPU.PushWord(0x11a2); // stack management - push return offset
			// Instruction address 0x1000:0x119f, size: 3
			F0_1000_1227();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_108e'");
		}

		public void F0_1000_1208()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_1208'(Cdecl) at 0x1000:0x1208, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.AX.Word = this.oCPU.DS.Word;
			this.oCPU.ES.Word = this.oCPU.AX.Word;
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb26e);
			this.oCPU.DI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.CX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x68e2);
			this.oCPU.PushWord(0x121f); // stack management - push return offset
			// Instruction address 0x1000:0x121c, size: 3
			F0_1000_12a6();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xb26e, this.oCPU.SI.Word);
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_1208'");
		}

		public void F0_1000_1227()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_1227'(Cdecl) at 0x1000:0x1227, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x68e2);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x68e4));
			if (this.oCPU.Flags.NE) goto L1231;
			this.oParent.LogWriteLine("Exiting function 'F0_1000_1227'");
			return;

		L1231:
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x68ec, 0x0);
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x68ed, 0x0);
			// LEA
			this.oCPU.AX.Word = 0x6afb;
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x68e8, this.oCPU.AX.Word);
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb26e);
			this.oCPU.CMPWord(this.oCPU.SI.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5528));
			if (this.oCPU.Flags.B) goto L125a;
			this.oCPU.PushWord(this.oCPU.BX.Word);
			this.oCPU.PushWord(this.oCPU.CX.Word);
			this.oCPU.PushWord(this.oCPU.DX.Word);
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x1253); // stack management - push return offset
			// Instruction address 0x1000:0x124f, size: 4
			this.oCPU.CallF(this.oCPU.ReadDWord(this.oCPU.DS.Word, 0xd91a));
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.DX.Word = this.oCPU.PopWord();
			this.oCPU.CX.Word = this.oCPU.PopWord();
			this.oCPU.BX.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb26e);

		L125a:
			this.oCPU.LODSWord();
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xb26e, this.oCPU.SI.Word);
			this.oCPU.CMPByte(this.oCPU.AX.Low, 0xb);
			if (this.oCPU.Flags.BE) goto L1265;
			this.oCPU.AX.Low = 0xb;

		L1265:
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x68ef, this.oCPU.AX.Low);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x68f4, this.oCPU.AX.Word);
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x68f6, 0x8);
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x68ee, 0x9);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x68f0, 0x1ff);
			this.oCPU.DX.Word = 0x100;
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x68f2, this.oCPU.DX.Word);
			this.oCPU.AX.Word = 0xffff;
			this.oCPU.BX.Word = 0x0;
			this.oCPU.CX.Word = 0x800;

		L128a:
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x45fa), this.oCPU.AX.Word);
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, 0x3);
			if (this.oCPU.Loop(this.oCPU.CX)) goto L128a;
			this.oCPU.AX.Low = 0x0;
			this.oCPU.BX.Word = 0x0;
			this.oCPU.CX.Word = 0x100;

		L129a:
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x45f8), this.oCPU.AX.Low);
			this.oCPU.AX.Low = this.oCPU.INCByte(this.oCPU.AX.Low);
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, 0x3);
			if (this.oCPU.Loop(this.oCPU.CX)) goto L129a;
			this.oParent.LogWriteLine("Exiting function 'F0_1000_1227'");
		}

		public void F0_1000_1270()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_1270'(Cdecl) at 0x1000:0x1270, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x68ee, 0x9);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x68f0, 0x1ff);
			this.oCPU.DX.Word = 0x100;
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x68f2, this.oCPU.DX.Word);
			this.oCPU.AX.Word = 0xffff;
			this.oCPU.BX.Word = 0x0;
			this.oCPU.CX.Word = 0x800;

		L128a:
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x45fa), this.oCPU.AX.Word);
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, 0x3);
			if (this.oCPU.Loop(this.oCPU.CX)) goto L128a;
			this.oCPU.AX.Low = 0x0;
			this.oCPU.BX.Word = 0x0;
			this.oCPU.CX.Word = 0x100;

		L129a:
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x45f8), this.oCPU.AX.Low);
			this.oCPU.AX.Low = this.oCPU.INCByte(this.oCPU.AX.Low);
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, 0x3);
			if (this.oCPU.Loop(this.oCPU.CX)) goto L129a;
			this.oParent.LogWriteLine("Exiting function 'F0_1000_1270'");
		}

		public void F0_1000_12a6()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_12a6'(Cdecl) at 0x1000:0x12a6, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, 0x68f7), 0x0);
			if (this.oCPU.Flags.E) goto L12b0;
			this.oCPU.CX.Word = this.oCPU.INCWord(this.oCPU.CX.Word);
			this.oCPU.CX.Word = this.oCPU.SHRWord(this.oCPU.CX.Word, 0x1);

		L12b0:
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x68ea, this.oCPU.CX.Word);
			this.oCPU.DX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x68f2);
			this.oCPU.Temp.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x68e8);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x68e8, this.oCPU.SP.Word);
			this.oCPU.SP.Word = this.oCPU.Temp.Word;

		L12bc:
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, 0x68ec), 0x0);
			if (this.oCPU.Flags.NE) goto L12e4;
			this.oCPU.PushWord(0x12c6); // stack management - push return offset
			// Instruction address 0x1000:0x12c3, size: 3
			F0_1000_1318(0x12c6);
			//this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.CMPByte(this.oCPU.AX.Low, 0x90);
			if (this.oCPU.Flags.E) goto L12d0;
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x68ed, this.oCPU.AX.Low);
			goto L12eb;

		L12d0:
			this.oCPU.PushWord(0x12d3); // stack management - push return offset
			// Instruction address 0x1000:0x12d0, size: 3
			F0_1000_1318(0x12d3);
			//this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.AX.Low = this.oCPU.ORByte(this.oCPU.AX.Low, this.oCPU.AX.Low);
			if (this.oCPU.Flags.NE) goto L12df;
			this.oCPU.AX.Low = 0x90;
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x68ed, this.oCPU.AX.Low);
			goto L12eb;

		L12df:
			this.oCPU.AX.Low = this.oCPU.DECByte(this.oCPU.AX.Low);
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x68ec, this.oCPU.AX.Low);

		L12e4:
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, 0x68ed);
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x68ec, this.oCPU.DECByte(this.oCPU.ReadByte(this.oCPU.DS.Word, 0x68ec)));

		L12eb:
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, 0x68f7), 0x0);
			if (this.oCPU.Flags.E) goto L1308;
			this.oCPU.AX.High = this.oCPU.AX.Low;
			this.oCPU.AX.Low = this.oCPU.ANDByte(this.oCPU.AX.Low, 0xf);
			this.oCPU.AX.High = this.oCPU.SHRByte(this.oCPU.AX.High, 0x1);
			this.oCPU.AX.High = this.oCPU.SHRByte(this.oCPU.AX.High, 0x1);
			this.oCPU.AX.High = this.oCPU.SHRByte(this.oCPU.AX.High, 0x1);
			this.oCPU.AX.High = this.oCPU.SHRByte(this.oCPU.AX.High, 0x1);
			this.oCPU.STOSWord();
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x68ea, this.oCPU.DECWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x68ea)));
			if (this.oCPU.Flags.NE) goto L12bc;
			goto L130f;

		L1308:
			this.oCPU.STOSByte();
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x68ea, this.oCPU.DECWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x68ea)));
			if (this.oCPU.Flags.NE) goto L12bc;

		L130f:
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x68f2, this.oCPU.DX.Word);
			this.oCPU.Temp.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x68e8);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x68e8, this.oCPU.SP.Word);
			this.oCPU.SP.Word = this.oCPU.Temp.Word;
			this.oParent.LogWriteLine("Exiting function 'F0_1000_12a6'");
		}

		public void F0_1000_1318(ushort value)
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_1318'(Undefined) at 0x1000:0x1318, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oCPU.CMPWord(this.oCPU.SP.Word, 0x6afb);
			if (this.oCPU.Flags.E) goto L1322;

			L131f:
			this.oCPU.AX.Word = this.oCPU.PopWord();
			if (this.oCPU.BP.Word != value)
				throw new Exception($"Return address doesn't match. Should return to 0x{value:x4}, but instead returns to 0x{this.oCPU.BP.Word:x4}");
			// returns to the next instruction
			// this.oCPU.Jmp(this.oCPU.BP.Word);
			return;

		L1322:
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x68f4);
			this.oCPU.CX.Low = 0x10;
			this.oCPU.CX.High = this.oCPU.ReadByte(this.oCPU.DS.Word, 0x68f6);
			this.oCPU.CX.Low = this.oCPU.SUBByte(this.oCPU.CX.Low, this.oCPU.CX.High);
			this.oCPU.BX.Word = this.oCPU.SHRWord(this.oCPU.BX.Word, this.oCPU.CX.Low);
			this.oCPU.CX.Low = this.oCPU.CX.High;

		L1332:
			this.oCPU.CMPByte(this.oCPU.CX.Low, this.oCPU.ReadByte(this.oCPU.DS.Word, 0x68ee));
			if (this.oCPU.Flags.GE) goto L1359;
			this.oCPU.CMPWord(this.oCPU.SI.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5528));
			if (this.oCPU.Flags.B) goto L134c;
			this.oCPU.PushWord(this.oCPU.BX.Word);
			this.oCPU.PushWord(this.oCPU.CX.Word);
			this.oCPU.PushWord(this.oCPU.DX.Word);
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x1345); // stack management - push return offset
			// Instruction address 0x1000:0x1341, size: 4
			this.oCPU.CallF(this.oCPU.ReadDWord(this.oCPU.DS.Word, 0xd91a));
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.DX.Word = this.oCPU.PopWord();
			this.oCPU.CX.Word = this.oCPU.PopWord();
			this.oCPU.BX.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb26e);

		L134c:
			this.oCPU.LODSWord();
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x68f4, this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.SHLWord(this.oCPU.AX.Word, this.oCPU.CX.Low);
			this.oCPU.BX.Word = this.oCPU.ORWord(this.oCPU.BX.Word, this.oCPU.AX.Word);
			this.oCPU.CX.Low = this.oCPU.ADDByte(this.oCPU.CX.Low, 0x10);
			goto L1332;

		L1359:
			this.oCPU.CX.Low = this.oCPU.SUBByte(this.oCPU.CX.Low, this.oCPU.ReadByte(this.oCPU.DS.Word, 0x68ee));
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x68f6, this.oCPU.CX.Low);
			this.oCPU.AX.Word = this.oCPU.BX.Word;
			this.oCPU.AX.Word = this.oCPU.ANDWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x68f0));
			this.oCPU.CX.Word = this.oCPU.AX.Word;
			this.oCPU.CMPWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			if (this.oCPU.Flags.L) goto L1377;
			this.oCPU.CX.Word = this.oCPU.DX.Word;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x68f8);
			this.oCPU.BX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, 0x68fa);
			this.oCPU.PushWord(this.oCPU.BX.Word);

		L1377:
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, this.oCPU.AX.Word);
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x45fa));
			this.oCPU.AX.Word = this.oCPU.INCWord(this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L138c;
			this.oCPU.AX.Word = this.oCPU.DECWord(this.oCPU.AX.Word);
			this.oCPU.BX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x45f8));
			this.oCPU.PushWord(this.oCPU.BX.Word);
			goto L1377;

		L138c:
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x45f8));
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x68fa, this.oCPU.AX.Low);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.BX.Word = this.oCPU.DX.Word;
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, this.oCPU.DX.Word);
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, this.oCPU.DX.Word);
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x45f8), this.oCPU.AX.Low);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x68f8);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x45fa), this.oCPU.AX.Word);
			this.oCPU.DX.Word = this.oCPU.INCWord(this.oCPU.DX.Word);
			this.oCPU.CMPWord(this.oCPU.DX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x68f0));
			if (this.oCPU.Flags.LE) goto L13b5;
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x68ee, this.oCPU.INCByte(this.oCPU.ReadByte(this.oCPU.DS.Word, 0x68ee)));
			this.oCPU.Flags.C = true;
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x68f0, this.oCPU.RCLWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x68f0), 0x1));

		L13b5:
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, 0x68ee);
			this.oCPU.CMPByte(this.oCPU.AX.Low, this.oCPU.ReadByte(this.oCPU.DS.Word, 0x68ef));
			if (this.oCPU.Flags.LE) goto L13c1;
			this.oCPU.PushWord(0x13c1); // stack management - push return offset
			// Instruction address 0x1000:0x13be, size: 3
			F0_1000_1270();
			this.oCPU.PopWord(); // stack management - pop return offset

		L13c1:
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x68f8, this.oCPU.CX.Word);
			goto L131f;
		}

		public void F0_1000_13c8()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_13c8'(Cdecl) at 0x1000:0x13c8, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.AX.High = 0x3c;
			this.oCPU.CX.Word = 0x0;
			this.oCPU.DX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.INT(0x21);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6afe, this.oCPU.AX.Word);
			if (this.oCPU.Flags.B) goto L1411;
			this.oCPU.AX.High = 0x48;
			this.oCPU.BX.Word = 0x5ff;
			this.oCPU.INT(0x21);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6b04, this.oCPU.AX.Word);
			if (this.oCPU.Flags.B) goto L1411;
			// LEA
			this.oCPU.DI.Word = 0xd936;
			this.oCPU.AX.Word = this.oCPU.DS.Word;
			this.oCPU.ES.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = 0x3058;
			this.oCPU.STOSWord();
			this.oCPU.AX.Word = 0x0;
			this.oCPU.STOSWord();
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.STOSWord();
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xa));
			this.oCPU.STOSWord();
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xb26e, this.oCPU.DI.Word);
			this.oCPU.AX.Word = 0x0;
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x6b08, this.oCPU.AX.Low);
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x6b09, this.oCPU.AX.Low);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6b06, 0xffff);

		L1411:
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_13c8'");
		}

		public void F0_1000_1414()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_1414'(Cdecl) at 0x1000:0x1414, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6b02);
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, this.oCPU.AX.Word);
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, this.oCPU.AX.Word);
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.ES.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6b04);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.ES.Word, (ushort)(this.oCPU.BX.Word + 0x4));
			this.oCPU.PushWord(0x142a); // stack management - push return offset
			// Instruction address 0x1000:0x1427, size: 3
			F0_1000_15cd();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.PushWord(0x142d); // stack management - push return offset
			// Instruction address 0x1000:0x142a, size: 3
			F0_1000_1620();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6b06, 0x0);
			this.oCPU.AX.High = 0x49;
			this.oCPU.ES.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6b04);
			this.oCPU.INT(0x21);
			if (this.oCPU.Flags.AE) goto L1440;
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6b06, this.oCPU.AX.Word);

		L1440:
			this.oCPU.AX.High = 0x42;
			this.oCPU.AX.Low = 0x1;
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6afe);
			this.oCPU.CX.Word = 0x0;
			this.oCPU.DX.Word = 0x0;
			this.oCPU.INT(0x21);
			if (this.oCPU.Flags.AE) goto L1453;
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6b06, this.oCPU.AX.Word);

		L1453:
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, 0x4);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.High = 0x42;
			this.oCPU.AX.Low = 0x0;
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6afe);
			this.oCPU.CX.Word = 0x0;
			this.oCPU.DX.Word = 0x2;
			this.oCPU.INT(0x21);
			if (this.oCPU.Flags.AE) goto L146b;
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6b06, this.oCPU.AX.Word);

		L146b:
			this.oCPU.AX.High = 0x40;
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6afe);
			this.oCPU.CX.Word = 0x2;
			this.oCPU.DX.Word = this.oCPU.SP.Word;
			this.oCPU.INT(0x21);
			if (this.oCPU.Flags.AE) goto L147d;
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6b06, this.oCPU.AX.Word);

		L147d:
			this.oCPU.AX.Word = this.oCPU.PopWord();
			this.oCPU.AX.High = 0x3e;
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6afe);
			this.oCPU.INT(0x21);
			if (this.oCPU.Flags.AE) goto L148b;
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6b06, this.oCPU.AX.Word);

		L148b:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6b06);
			this.oParent.LogWriteLine("Exiting function 'F0_1000_1414'");
		}

		public void F0_1000_148f()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_148f'(Cdecl) at 0x1000:0x148f, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.AX.Word = this.oCPU.DS.Word;
			this.oCPU.ES.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BP.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6b02);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6b06), 0xffff);
			if (this.oCPU.Flags.E) goto L1500;
			this.oCPU.DI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6b00);
			this.oCPU.STOSByte();
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6b00, this.oCPU.DI.Word);
			this.oCPU.PushWord(0x14b2); // stack management - push return offset
			// Instruction address 0x1000:0x14af, size: 3
			F0_1000_1565();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.CMPWord(this.oCPU.BX.Word, 0xffff);
			if (this.oCPU.Flags.E) goto L14bf;
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6b02, this.oCPU.BX.Word);
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_148f'");
			return;

		L14bf:
			// LEA
			this.oCPU.SI.Word = 0xba06;
			this.oCPU.WriteByte(this.oCPU.DS.Word, this.oCPU.SI.Word, this.oCPU.AX.Low);
			this.oCPU.SI.Word = this.oCPU.INCWord(this.oCPU.SI.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6b00, this.oCPU.SI.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6b02, this.oCPU.AX.Word);
			this.oCPU.PushWord(0x14d0); // stack management - push return offset
			// Instruction address 0x1000:0x14cd, size: 3
			F0_1000_1558();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.BX.Word = this.oCPU.BP.Word;
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, this.oCPU.BP.Word);
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, this.oCPU.BP.Word);
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.ES.Word, (ushort)(this.oCPU.BX.Word + 0x4));
			this.oCPU.PushWord(0x14df); // stack management - push return offset
			// Instruction address 0x1000:0x14dc, size: 3
			F0_1000_15cd();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.AX.Word = 0x1;
			this.oCPU.CX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, 0x6b0a);
			this.oCPU.AX.Word = this.oCPU.SHLWord(this.oCPU.AX.Word, this.oCPU.CX.Low);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6afc), this.oCPU.AX.Word);
			if (this.oCPU.Flags.BE) goto L14fc;
			this.oCPU.CX.Low = this.oCPU.INCByte(this.oCPU.CX.Low);
			this.oCPU.CMPByte(this.oCPU.CX.Low, 0xb);
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x6b0a, this.oCPU.CX.Low);
			if (this.oCPU.Flags.BE) goto L14fc;
			this.oCPU.PushWord(0x14fc); // stack management - push return offset
			// Instruction address 0x1000:0x14f9, size: 3
			F0_1000_1524();
			this.oCPU.PopWord(); // stack management - pop return offset

		L14fc:
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_148f'");
			return;

		L1500:
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6b06, 0x0);
			// LEA
			this.oCPU.DI.Word = 0xba06;
			this.oCPU.STOSByte();
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6b00, this.oCPU.DI.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6b02, this.oCPU.AX.Word);
			this.oCPU.AX.Low = 0xb;
			this.oCPU.DI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb26e);
			this.oCPU.STOSByte();
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xb26e, this.oCPU.DI.Word);
			this.oCPU.PushWord(0x1520); // stack management - push return offset
			// Instruction address 0x1000:0x151d, size: 3
			F0_1000_1524();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_148f'");
		}

		public void F0_1000_1524()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_1524'(Cdecl) at 0x1000:0x1524, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.ES.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6b04);
			this.oCPU.DI.Word = 0x0;
			this.oCPU.BX.Word = 0xffff;
			this.oCPU.CX.Word = 0x0;

		L152f:
			this.oCPU.AX.Word = this.oCPU.CX.Word;
			this.oCPU.STOSWord();
			this.oCPU.AX.Word = this.oCPU.BX.Word;
			this.oCPU.STOSWord();
			this.oCPU.AX.Word = this.oCPU.CX.Word;
			this.oCPU.STOSWord();
			this.oCPU.CX.Word = this.oCPU.INCWord(this.oCPU.CX.Word);
			this.oCPU.CMPWord(this.oCPU.CX.Word, 0x100);
			if (this.oCPU.Flags.B) goto L152f;
			this.oCPU.AX.Word = this.oCPU.BX.Word;

		L1541:
			this.oCPU.STOSWord();
			this.oCPU.DI.Word = this.oCPU.ADDWord(this.oCPU.DI.Word, 0x4);
			this.oCPU.CX.Word = this.oCPU.INCWord(this.oCPU.CX.Word);
			this.oCPU.CMPWord(this.oCPU.CX.Word, 0xffb);
			if (this.oCPU.Flags.B) goto L1541;
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x6b0a, 0x9);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6afc, 0x101);
			this.oParent.LogWriteLine("Exiting function 'F0_1000_1524'");
		}

		public void F0_1000_1558()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_1558'(Cdecl) at 0x1000:0x1558, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.STOSWord();
			this.oCPU.AX.Word = this.oCPU.BP.Word;
			this.oCPU.STOSWord();
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6afc);
			this.oCPU.STOSWord();
			this.oCPU.AX.Word = this.oCPU.INCWord(this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6afc, this.oCPU.AX.Word);
			this.oParent.LogWriteLine("Exiting function 'F0_1000_1558'");
		}

		public void F0_1000_1565()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_1565'(Cdecl) at 0x1000:0x1565, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.BX.Word = 0x0;
			// LEA
			this.oCPU.DI.Word = 0xba06;
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6b00);
			this.oCPU.WriteByte(this.oCPU.DS.Word, this.oCPU.SI.Word, this.oCPU.BX.Low);

		L1571:
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, this.oCPU.DI.Word));
			this.oCPU.DI.Word = this.oCPU.ADDWord(this.oCPU.DI.Word, 0x2);
			this.oCPU.CMPWord(this.oCPU.DI.Word, this.oCPU.SI.Word);
			if (this.oCPU.Flags.B) goto L1571;
			this.oCPU.BX.Word = this.oCPU.ANDWord(this.oCPU.BX.Word, 0x7fff);
			if (this.oCPU.Flags.NE) goto L1593;
			// LEA
			this.oCPU.DI.Word = 0xba06;
			this.oCPU.SI.Word = this.oCPU.SUBWord(this.oCPU.SI.Word, this.oCPU.DI.Word);
			this.oCPU.CX.Word = this.oCPU.SI.Word;
			this.oCPU.DX.Word = 0x25;

		L158b:
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, this.oCPU.DX.Word);
			if (this.oCPU.Loop(this.oCPU.CX)) goto L158b;
			this.oCPU.BX.Word = this.oCPU.ANDWord(this.oCPU.BX.Word, 0x7fff);

		L1593:
			this.oCPU.DX.Word = this.oCPU.BX.Word;
			this.oCPU.SI.Word = 0xff9;

		L1598:
			this.oCPU.DX.Word = this.oCPU.SUBWord(this.oCPU.DX.Word, this.oCPU.SI.Word);
			if (this.oCPU.Flags.AE) goto L1598;
			this.oCPU.DX.Word = this.oCPU.NEGWord(this.oCPU.DX.Word);
			this.oCPU.SI.Word = 0xffb;
			this.oCPU.ES.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6b04);

		L15a5:
			this.oCPU.BX.Word = this.oCPU.SUBWord(this.oCPU.BX.Word, this.oCPU.SI.Word);
			if (this.oCPU.Flags.AE) goto L15a5;
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, this.oCPU.SI.Word);
			this.oCPU.DI.Word = this.oCPU.BX.Word;
			this.oCPU.DI.Word = this.oCPU.ADDWord(this.oCPU.DI.Word, this.oCPU.BX.Word);
			this.oCPU.DI.Word = this.oCPU.ADDWord(this.oCPU.DI.Word, this.oCPU.BX.Word);
			this.oCPU.DI.Word = this.oCPU.SHLWord(this.oCPU.DI.Word, 0x1);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.ES.Word, this.oCPU.DI.Word), 0xffff);
			if (this.oCPU.Flags.NE) goto L15bd;
			this.oCPU.BX.Word = 0xffff;
			this.oParent.LogWriteLine("Exiting function 'F0_1000_1565'");
			return;

		L15bd:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.ES.Word, this.oCPU.DI.Word), this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L15c9;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.ES.Word, (ushort)(this.oCPU.DI.Word + 0x2)), this.oCPU.BP.Word);
			if (this.oCPU.Flags.NE) goto L15c9;
			this.oParent.LogWriteLine("Exiting function 'F0_1000_1565'");
			return;

		L15c9:
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, this.oCPU.DX.Word);
			goto L15a5;
		}

		public void F0_1000_15cd()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_15cd'(Cdecl) at 0x1000:0x15cd, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.CX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, 0x6b0a);
			this.oCPU.DX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, 0x6b08);
			this.oCPU.DX.High = this.oCPU.ReadByte(this.oCPU.DS.Word, 0x6b09);

		L15d9:
			this.oCPU.CX.Low = this.oCPU.DECByte(this.oCPU.CX.Low);
			if (this.oCPU.Flags.S) goto L1617;
			this.oCPU.CMPByte(this.oCPU.DX.Low, 0x8);
			if (this.oCPU.Flags.B) goto L160f;
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb26e);
			this.oCPU.WriteByte(this.oCPU.DS.Word, this.oCPU.BX.Word, this.oCPU.DX.High);
			this.oCPU.BX.Word = this.oCPU.INCWord(this.oCPU.BX.Word);
			this.oCPU.DX.Word = 0x0;
			this.oCPU.CMPWord(this.oCPU.BX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5528));
			if (this.oCPU.Flags.B) goto L160b;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CX.Word);
			this.oCPU.PushWord(this.oCPU.DX.Word);
			this.oCPU.AX.High = 0x40;
			this.oCPU.CX.Word = this.oCPU.BX.Word;
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6afe);
			// LEA
			this.oCPU.DX.Word = 0xd936;
			this.oCPU.CX.Word = this.oCPU.SUBWord(this.oCPU.CX.Word, this.oCPU.DX.Word);
			this.oCPU.INT(0x21);
			this.oCPU.DX.Word = this.oCPU.PopWord();
			this.oCPU.CX.Word = this.oCPU.PopWord();
			this.oCPU.AX.Word = this.oCPU.PopWord();
			// LEA
			this.oCPU.BX.Word = 0xd936;

		L160b:
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xb26e, this.oCPU.BX.Word);

		L160f:
			this.oCPU.AX.Word = this.oCPU.SHRWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.DX.High = this.oCPU.RCRByte(this.oCPU.DX.High, 0x1);
			this.oCPU.DX.Low = this.oCPU.INCByte(this.oCPU.DX.Low);
			goto L15d9;

		L1617:
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x6b08, this.oCPU.DX.Low);
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x6b09, this.oCPU.DX.High);
			this.oParent.LogWriteLine("Exiting function 'F0_1000_15cd'");
		}

		public void F0_1000_1620()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_1620'(Cdecl) at 0x1000:0x1620, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x6b0a, 0x8);
			this.oCPU.AX.Word = 0x0;
			this.oCPU.PushWord(0x162a); // stack management - push return offset
			// Instruction address 0x1000:0x1627, size: 3
			F0_1000_15cd();
			this.oCPU.PopWord(); // stack management - pop return offset
			this.oCPU.AX.High = 0x40;
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6afe);
			this.oCPU.CX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb26e);
			// LEA
			this.oCPU.DX.Word = 0xd936;
			this.oCPU.CX.Word = this.oCPU.SUBWord(this.oCPU.CX.Word, this.oCPU.DX.Word);
			this.oCPU.INT(0x21);
			this.oParent.LogWriteLine("Exiting function 'F0_1000_1620'");
		}

		public void F0_1000_163e()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_163e'(Cdecl) at 0x1000:0x163e, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.AX.Word = 0x0;
			this.oCPU.ES.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.ES.Word, 0xcc);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.ES.Word, 0xce));
			if (this.oCPU.Flags.E) goto L1683;
			this.oCPU.AX.Word = 0x0;
			this.oCPU.INT(0x33);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L1683;
			this.oCPU.AX.Word = 0xc;
			this.oCPU.CX.Word = 0x1f;
			this.oCPU.DX.Word = this.oCPU.CS.Word;
			this.oCPU.ES.Word = this.oCPU.DX.Word;
			// LEA
			this.oCPU.DX.Word = 0x17db;
			this.oCPU.INT(0x33);
			this.oCPU.AX.Word = 0x3;
			this.oCPU.INT(0x33);
			this.oCPU.AX.Word = this.oCPU.CX.Word;
			this.oCPU.CX.Low = this.oCPU.CX.High;
			this.oCPU.AX.Word = this.oCPU.SHRWord(this.oCPU.AX.Word, this.oCPU.CX.Low);
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x587c, this.oCPU.CX.Low);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x586e, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5870, this.oCPU.DX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5872, this.oCPU.BX.Word);
			this.oCPU.AX.Word = 0xffff;

		L1683:
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x587d, this.oCPU.AX.Low);
			this.oParent.LogWriteLine("Exiting function 'F0_1000_163e'");
		}

		public void F0_1000_1687()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_1687'(Cdecl) at 0x1000:0x1687, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.AX.Low = 0x0;
			this.oCPU.Temp.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, 0x587d);
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x587d, this.oCPU.AX.Low);
			this.oCPU.AX.Low = this.oCPU.Temp.Low;
			this.oCPU.AX.Low = this.oCPU.ORByte(this.oCPU.AX.Low, this.oCPU.AX.Low);
			if (this.oCPU.Flags.E) goto L1696;
			this.oCPU.AX.Word = 0x0;
			this.oCPU.INT(0x33);

		L1696:
			this.oParent.LogWriteLine("Exiting function 'F0_1000_1687'");
		}

		public void F0_1000_1697()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_1697'(Cdecl) at 0x1000:0x1697, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5878, this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x587a, this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xa));
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5876, this.oCPU.AX.Word);
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_1697'");
		}

		public void F0_1000_16ae()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_16ae'(Cdecl) at 0x1000:0x16ae, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.DX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x586e, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5870, this.oCPU.DX.Word);
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, 0x587d), 0x0);
			if (this.oCPU.Flags.E) goto L16d2;
			this.oCPU.CX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, 0x587c);
			this.oCPU.AX.Word = this.oCPU.SHLWord(this.oCPU.AX.Word, this.oCPU.CX.Low);
			this.oCPU.CX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = 0x4;
			this.oCPU.INT(0x33);

		L16d2:
			this.oCPU.BP.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_16ae'");
		}

		public void F0_1000_16d4()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_16d4'(Cdecl) at 0x1000:0x16d4, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.AX.Word = 0x0;
			this.oCPU.Temp.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5874);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x5874, this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.Temp.Word;
			this.oParent.LogWriteLine("Exiting function 'F0_1000_16d4'");
		}

		public void F0_1000_16db()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_16db'(Cdecl) at 0x1000:0x16db, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5876), 0x0);
			if (this.oCPU.Flags.E) goto L170a;
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, 0x5403), 0x0);
			if (this.oCPU.Flags.NE) goto L170a;
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5876));
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5870);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x587a));
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x586e);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5878));
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x1702); // stack management - push return offset
			// Instruction address 0x1000:0x16fd, size: 5
			F0_1000_083f();
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x5403, 0x1);

		L170a:
			this.oParent.LogWriteLine("Exiting function 'F0_1000_16db'");
		}

		public void F0_1000_170b()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_170b'(Cdecl) at 0x1000:0x170b, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5876), 0x0);
			if (this.oCPU.Flags.E) goto L1723;
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, 0x5403), 0x0);
			if (this.oCPU.Flags.E) goto L1723;
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0x5403, 0x0);
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x1723); // stack management - push return offset
			// Instruction address 0x1000:0x171e, size: 5
			F0_1000_07d6();
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment

		L1723:
			this.oParent.LogWriteLine("Exiting function 'F0_1000_170b'");
		}

		public void F0_1000_179a()
		{
			this.oParent.LogWriteLine("Entering function 'F0_1000_179a'(Cdecl) at 0x1000:0x179a, stack: 0x0");
			this.oCPU.CS.Word = 0x1000; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.DX.Word);
			this.oCPU.PushWord(this.oCPU.ES.Word);
			this.oCPU.AX.Word = 0x1000;
			this.oCPU.ES.Word = this.oCPU.AX.Word;
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x17a7); // stack management - push return offset
			// Instruction address 0x1000:0x17a2, size: 5
			this.oCPU.CallF(this.oCPU.ReadDWord(this.oCPU.ES.Word, 0x7d9));
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5876));
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5870);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x587a));
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x586e);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x5878));
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x1000;
			this.oCPU.ES.Word = this.oCPU.AX.Word;
			this.oCPU.PushWord(0x1000); // stack management - push return segment
			this.oCPU.PushWord(0x17c5); // stack management - push return offset
			// Instruction address 0x1000:0x17c0, size: 5
			this.oCPU.CallF(this.oCPU.ReadDWord(this.oCPU.ES.Word, 0x842));
			this.oCPU.PopDWord(); // stack management - pop return offset, segment
			this.oCPU.CS.Word = 0x1000; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.ES.Word = this.oCPU.PopWord();
			this.oCPU.DX.Word = this.oCPU.PopWord();
			this.oCPU.AX.Word = this.oCPU.PopWord();
			this.oParent.LogWriteLine("Exiting function 'F0_1000_179a'");
		}
	}
}