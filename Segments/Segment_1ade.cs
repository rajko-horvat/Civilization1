using Disassembler;

namespace Civilization1
{
	public class Segment_1ade
	{
		private Civilization oParent;
		private CPU oCPU;

		public Segment_1ade(Civilization parent)
		{
			this.oParent = parent;
			this.oCPU = parent.CPU;
		}

		public void F0_1ade_0006()
		{
			this.oCPU.Log.EnterBlock("'F0_1ade_0006'(Cdecl, Far) at 0x1ade:0x0006");
			this.oCPU.CS.Word = 0x1ade; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.SP.Word = this.oCPU.SUBWord(this.oCPU.SP.Word, 0xa);
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xdb42, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xe3c2, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8), this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2), this.oCPU.AX.Word);
			goto L0027;

		L001e:
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xb1e8, 0x0);

		L0024:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2))));

		L0027:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2)), 0x80);
			if (this.oCPU.Flags.L) goto L0031;
			goto L00b2;

		L0031:
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f2)), 0xff);
			if (this.oCPU.Flags.E) goto L0024;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f7));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.CMPWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			if (this.oCPU.Flags.NE) goto L0024;

		L004a:
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0056); // stack management - push return offset
			// Instruction address 0x1ade:0x0051, size: 5
			this.oParent.Segment_1d12.F0_1d12_0045();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L0070;
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f3)), 0x5);
			if (this.oCPU.Flags.LE) goto L0070;
			this.oCPU.WriteByte(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8), this.oCPU.ORByte(this.oCPU.ReadByte(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8)), 0x1));

		L0070:
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f2)), 0x1);
			if (this.oCPU.Flags.E) goto L0083;
			this.oCPU.WriteByte(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8), this.oCPU.ORByte(this.oCPU.ReadByte(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8)), 0x2));

		L0083:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb1e8), 0x0);
			if (this.oCPU.Flags.E) goto L0024;
			this.oCPU.AX.Word = 0x1;
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.PushWord(this.oCPU.DX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0098); // stack management - push return offset
			// Instruction address 0x1ade:0x0093, size: 5
			this.oParent.Segment_1d12.F0_1d12_0045();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x00a0); // stack management - push return offset
			// Instruction address 0x1ade:0x009b, size: 5
			this.oParent.Segment_1238.F0_1238_1b44();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb1e8), 0x2);
			if (this.oCPU.Flags.E) goto L00aa;
			goto L001e;

		L00aa:
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xb1e8, 0x0);
			goto L004a;

		L00b2:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L00bd;
			goto L0188;

		L00bd:
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, 0xe3c4), 0x4);
			if (this.oCPU.Flags.NE) goto L00c7;
			goto L0188;

		L00c7:
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.DI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x4df0));
			this.oCPU.DI.Word = this.oCPU.ADDWord(this.oCPU.DI.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x20f2)));
			this.oCPU.AX.Word = 0xa;
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DI.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6), this.oCPU.AX.Word);
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8)), 0x2);
			if (this.oCPU.Flags.E) goto L00ea;
			this.oCPU.CMPWord(this.oCPU.DI.Word, 0x6);
			if (this.oCPU.Flags.LE) goto L00ea;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6))));

		L00ea:
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, 0x81d2), 0x3);
			if (this.oCPU.Flags.NE) goto L010c;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8)), 0x0);
			if (this.oCPU.Flags.NE) goto L010c;
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x20f2));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x4df0)));
			this.oCPU.CMPWord(this.oCPU.AX.Word, 0x8);
			if (this.oCPU.Flags.GE) goto L010c;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6), this.oCPU.DECWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6))));

		L010c:
			this.oCPU.AX.Word = 0x4;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x011b); // stack management - push return offset
			// Instruction address 0x1ade:0x0116, size: 5
			this.oParent.Segment_2dc4.F0_2dc4_007c();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6), this.oCPU.AX.Word);
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.AX.Word = 0x3a;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x280c)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x1516));
			this.oCPU.CX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = 0xa;
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6)));
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.SARWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.CX.Word = this.oCPU.ADDWord(this.oCPU.CX.Word, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x4df0), this.oCPU.CX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x81d2);
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0x64);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x4e2a)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.LE) goto L0156;
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x4df0), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x4df0))));

		L0156:
			this.oCPU.AX.Word = 0x3f; // Segment
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0161); // stack management - push return offset
			// Instruction address 0x1ade:0x015e, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L0173;
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x4df0), 0x0);

		L0173:
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x4df0));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6)));
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, 0xa);
			this.oCPU.AX.Word = this.oCPU.NEGWord(this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x20f2), this.oCPU.AX.Word);

		L0188:
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.SP.Word = this.oCPU.BP.Word;
			this.oCPU.BP.Word = this.oCPU.PopWord();
			// Far return
			this.oCPU.Log.ExitBlock("'F0_1ade_0006'");
		}

		public void F0_1ade_018e()
		{
			this.oCPU.Log.EnterBlock("'F0_1ade_018e'(Cdecl, Far) at 0x1ade:0x018e");
			this.oCPU.CS.Word = 0x1ade; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.SP.Word = this.oCPU.SUBWord(this.oCPU.SP.Word, 0xa);
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xa)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x7102));
			this.oCPU.AX.High = this.oCPU.SUBByte(this.oCPU.AX.High, this.oCPU.AX.High);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xffff;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x4;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x1;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x01bc); // stack management - push return offset
			// Instruction address 0x1ade:0x01b7, size: 5
			this.oParent.Segment_1866.F0_1866_250e();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0xc);
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f5)), 0x0);
			if (this.oCPU.Flags.L) goto L01db;
			this.oCPU.AX.Low = 0x38;
			this.oCPU.IMULByte(this.oCPU.AX, this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f7)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f5));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.DI.Word = this.oCPU.AX.Word;
			this.oCPU.DI.Word = this.oCPU.SHLWord(this.oCPU.DI.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.DI.Word - 0x2cf8), this.oCPU.DECWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.DI.Word - 0x2cf8))));

		L01db:
			this.oCPU.AX.Word = 0x1c; // Segment
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f7));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x6b66), this.oCPU.DECWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x6b66))));
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f2), 0xff);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xa)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0203); // stack management - push return offset
			// Instruction address 0x1ade:0x01fe, size: 5
			this.oParent.Segment_2aea.F0_2aea_1653();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.AX.Word = 0x32;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xa)));
			this.oCPU.ES.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x63ec);
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.ES.Word, (ushort)(this.oCPU.BX.Word + 0x740));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.DX.Word = 0x1;
			this.oCPU.CX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, 0xd7ee);
			this.oCPU.DX.Word = this.oCPU.SHLWord(this.oCPU.DX.Word, this.oCPU.CX.Low);
			this.oCPU.TESTWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			if (this.oCPU.Flags.E) goto L0236;
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xa)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0233); // stack management - push return offset
			// Instruction address 0x1ade:0x022e, size: 5
			this.oParent.Segment_2aea.F0_2aea_1601();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);

		L0236:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2), 0x0);
			goto L0266;

		L023d:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa))));

		L0240:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa)), 0x3);
			if (this.oCPU.Flags.GE) goto L0263;
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.SI.Word = this.oCPU.ADDWord(this.oCPU.SI.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa)));
			this.oCPU.SI.Word = this.oCPU.ADDWord(this.oCPU.SI.Word, 0x7103);
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, this.oCPU.SI.Word);
			this.oCPU.AX.High = this.oCPU.SUBByte(this.oCPU.AX.High, this.oCPU.AX.High);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L023d;
			this.oCPU.WriteByte(this.oCPU.DS.Word, this.oCPU.SI.Word, 0xff);
			goto L023d;

		L0263:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2))));

		L0266:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2)), 0x80);
			if (this.oCPU.Flags.GE) goto L0274;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa), 0x0);
			goto L0240;

		L0274:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa), 0x1);

		L0279:
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.SI.Word = this.oCPU.ADDWord(this.oCPU.SI.Word, 0x6ea8);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, this.oCPU.SI.Word);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L028d;
			this.oCPU.WriteWord(this.oCPU.DS.Word, this.oCPU.SI.Word, 0x80);

		L028d:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa))));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa)), 0x15);
			if (this.oCPU.Flags.LE) goto L0279;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa), 0x0);

		L029b:
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f7));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = 0xc;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa)));
			this.oCPU.DI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = 0x600;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.SI.Word);
			this.oCPU.DI.Word = this.oCPU.ADDWord(this.oCPU.DI.Word, this.oCPU.AX.Word);
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.DI.Word - 0x7e29)), 0xff);
			if (this.oCPU.Flags.E) goto L02d6;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.DI.Word - 0x7e21));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.CMPWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			if (this.oCPU.Flags.NE) goto L02d6;
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa)));
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x02d3); // stack management - push return offset
			// Instruction address 0x1ade:0x02ce, size: 5
			this.oParent.Segment_1866.F0_1866_0f10();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);

		L02d6:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa))));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa)), 0x80);
			if (this.oCPU.Flags.L) goto L029b;
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xa)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x02eb); // stack management - push return offset
			// Instruction address 0x1ade:0x02e6, size: 5
			this.oParent.Segment_2aea.F0_2aea_1458();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4), this.oCPU.AX.Word);
			this.oCPU.CMPWord(this.oCPU.AX.Word, 0xffff);
			if (this.oCPU.Flags.E) goto L0317;
			this.oCPU.AX.Word = 0x1643; // Segment
			this.oCPU.DX.Word = 0x1866;
			this.oCPU.PushWord(this.oCPU.DX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4)));
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f7));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0314); // stack management - push return offset
			// Instruction address 0x1ade:0x030f, size: 5
			this.oParent.Segment_1866.F0_1866_144b();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x8);

		L0317:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa), 0x0);

		L031c:
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x1882));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x032e); // stack management - push return offset
			// Instruction address 0x1ade:0x0329, size: 5
			this.oParent.Segment_2e31.F0_2e31_119b();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x2);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6), this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x18e4));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xa)));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8), this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0347); // stack management - push return offset
			// Instruction address 0x1ade:0x0342, size: 5
			this.oParent.Segment_2dc4.F0_2dc4_0102();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2), this.oCPU.AX.Word);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa)), 0x14);
			if (this.oCPU.Flags.LE) goto L035a;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6c9a), 0x3);
			if (this.oCPU.Flags.LE) goto L0385;

		L035a:
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6));
			this.oCPU.SI.Word = this.oCPU.ADDWord(this.oCPU.SI.Word, 0x50);
			this.oCPU.AX.Word = 0x2;
			this.oCPU.PushWord(this.oCPU.AX.Word);

			// Instruction address 0x1ade:0x0370, size: 5
			this.oParent.VGADriver.F0_VGA_038c_GetPixel(2,
				this.oCPU.SI.Word,
				(ushort)(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8)) + 0x32));

			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8)));
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0382); // stack management - push return offset
			// Instruction address 0x1ade:0x037d, size: 5
			this.oParent.Segment_2aea.F0_2aea_17cf();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x8);

		L0385:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa))));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa)), 0x2d);
			if (this.oCPU.Flags.L) goto L031c;
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.SP.Word = this.oCPU.BP.Word;
			this.oCPU.BP.Word = this.oCPU.PopWord();
			// Far return
			this.oCPU.Log.ExitBlock("'F0_1ade_018e'");
		}

		public void F0_1ade_0394()
		{
			this.oCPU.Log.EnterBlock("'F0_1ade_0394'(Cdecl, Far) at 0x1ade:0x0394");
			this.oCPU.CS.Word = 0x1ade; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0399); // stack management - push return offset
			// Instruction address 0x1ade:0x0394, size: 5
			this.oParent.Segment_11a8.F0_11a8_0268();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x19d4));
			this.oCPU.AX.Word = 0xc8;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x140;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0xaa));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x03b6); // stack management - push return offset
			// Instruction address 0x1ade:0x03b1, size: 5
			this.oParent.VGADriver.F0_VGA_07d8();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x10);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x03be); // stack management - push return offset
			// Instruction address 0x1ade:0x03b9, size: 5
			this.oParent.Segment_11a8.F0_11a8_0250();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			// Far return
			this.oCPU.Log.ExitBlock("'F0_1ade_0394'");
		}

		public void F0_1ade_03bf()
		{
			this.oCPU.Log.EnterBlock("'F0_1ade_03bf'(Cdecl, Far) at 0x1ade:0x03bf");
			this.oCPU.CS.Word = 0x1ade; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x03c4); // stack management - push return offset
			// Instruction address 0x1ade:0x03bf, size: 5
			this.oParent.Segment_11a8.F0_11a8_0268();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0xaa));
			this.oCPU.AX.Word = 0xc8;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x140;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x19d4));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x03e1); // stack management - push return offset
			// Instruction address 0x1ade:0x03dc, size: 5
			this.oParent.VGADriver.F0_VGA_07d8();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x10);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x03e9); // stack management - push return offset
			// Instruction address 0x1ade:0x03e4, size: 5
			this.oParent.Segment_11a8.F0_11a8_0250();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			// Far return
			this.oCPU.Log.ExitBlock("'F0_1ade_03bf'");
		}

		public void F0_1ade_03ea()
		{
			this.oCPU.Log.EnterBlock("'F0_1ade_03ea'(Cdecl, Far) at 0x1ade:0x03ea");
			this.oCPU.CS.Word = 0x1ade; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.SP.Word = this.oCPU.SUBWord(this.oCPU.SP.Word, 0x2);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x03f4); // stack management - push return offset
			// Instruction address 0x1ade:0x03f1, size: 3
			F0_1ade_0394();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6b64, 0x0);
			this.oCPU.AX.Word = 0x1;
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.PushWord(this.oCPU.DX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0408); // stack management - push return offset
			// Instruction address 0x1ade:0x0403, size: 5
			this.oParent.Segment_1d12.F0_1d12_0045();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6b64), 0x0);
			if (this.oCPU.Flags.E) goto L0419;
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0417); // stack management - push return offset
			// Instruction address 0x1ade:0x0412, size: 5
			this.oParent.Segment_1238.F0_1238_1b44();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			goto L041d;

		L0419:
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x041d); // stack management - push return offset
			// Instruction address 0x1ade:0x041a, size: 3
			F0_1ade_03bf();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment

		L041d:
			this.oCPU.SP.Word = this.oCPU.BP.Word;
			this.oCPU.BP.Word = this.oCPU.PopWord();
			// Far return
			this.oCPU.Log.ExitBlock("'F0_1ade_03ea'");
		}

		public void F0_1ade_0421()
		{
			this.oCPU.Log.EnterBlock("'F0_1ade_0421'(Cdecl, Far) at 0x1ade:0x0421");
			this.oCPU.CS.Word = 0x1ade; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.SP.Word = this.oCPU.SUBWord(this.oCPU.SP.Word, 0x14a);
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.WriteByte(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12e), 0x2a);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x13a), this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4), this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xffff;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0444); // stack management - push return offset
			// Instruction address 0x1ade:0x043f, size: 5
			this.oParent.Segment_1d12.F0_1d12_0045();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);

		L0447:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa), 0x1);
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f5));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xde), this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x222a;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x046a); // stack management - push return offset
			// Instruction address 0x1ade:0x0465, size: 5
			this.oParent.MSCAPI.strcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0475); // stack management - push return offset
			// Instruction address 0x1ade:0x0470, size: 5
			this.oParent.Segment_2459.F0_2459_08c6();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x2);
			this.oCPU.AX.Word = 0x2242;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0485); // stack management - push return offset
			// Instruction address 0x1ade:0x0480, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x13a)), 0x2);
			if (this.oCPU.Flags.NE) goto L0492;
			goto L05f4;

		L0492:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0), 0x0);
			goto L05c5;

		L049b:
			this.oCPU.AX.Word = 0x22;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x114a)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x04af); // stack management - push return offset
			// Instruction address 0x1ade:0x04ac, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L04b9;
			goto L05c1;

		L04b9:
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x1136)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x04c4); // stack management - push return offset
			// Instruction address 0x1ade:0x04c1, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L04ce;
			goto L05c1;

		L04ce:
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f2)), 0x2);
			if (this.oCPU.Flags.NE) goto L04e7;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x1138)), 0x2);
			if (this.oCPU.Flags.NE) goto L04e7;
			goto L05c1;

		L04e7:
			this.oCPU.AX.Word = 0x22;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0x112a);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x04fd); // stack management - push return offset
			// Instruction address 0x1ade:0x04f8, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x1142)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x050b); // stack management - push return offset
			// Instruction address 0x1ade:0x0508, size: 3
			F0_1ade_14ed();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x2246;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x051b); // stack management - push return offset
			// Instruction address 0x1ade:0x0516, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0xa;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xd80a;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x113e)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x052f); // stack management - push return offset
			// Instruction address 0x1ade:0x052a, size: 5
			this.oParent.MSCAPI.itoa();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x053c); // stack management - push return offset
			// Instruction address 0x1ade:0x0537, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x224d;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x054c); // stack management - push return offset
			// Instruction address 0x1ade:0x0547, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0xa;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xd80a;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x1140)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0560); // stack management - push return offset
			// Instruction address 0x1ade:0x055b, size: 5
			this.oParent.MSCAPI.itoa();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x056d); // stack management - push return offset
			// Instruction address 0x1ade:0x0568, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x224f;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x057d); // stack management - push return offset
			// Instruction address 0x1ade:0x0578, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0xa;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xd80a;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x113a)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0591); // stack management - push return offset
			// Instruction address 0x1ade:0x058c, size: 5
			this.oParent.MSCAPI.itoa();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x059e); // stack management - push return offset
			// Instruction address 0x1ade:0x0599, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x2251;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x05ae); // stack management - push return offset
			// Instruction address 0x1ade:0x05a9, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.DI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa))));
			this.oCPU.DI.Word = this.oCPU.SHLWord(this.oCPU.DI.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + this.oCPU.DI.Word - 0xde), this.oCPU.AX.Word);

		L05c1:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0))));

		L05c5:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)), 0x1c);
			if (this.oCPU.Flags.GE) goto L05f4;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)), 0x19);
			if (this.oCPU.Flags.E) goto L05d6;
			goto L049b;

		L05d6:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6eca), 0xffff);
			if (this.oCPU.Flags.E) goto L05c1;
			this.oCPU.AX.Word = 0x1b;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x05e8); // stack management - push return offset
			// Instruction address 0x1ade:0x05e5, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L05f2;
			goto L049b;

		L05f2:
			goto L05c1;

		L05f4:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x136), this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0604); // stack management - push return offset
			// Instruction address 0x1ade:0x05ff, size: 5
			this.oParent.MSCAPI.strlen();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x2);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x138), this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6), 0x0);
			this.oCPU.AX.Word = 0xf;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x061c); // stack management - push return offset
			// Instruction address 0x1ade:0x0617, size: 5
			this.oParent.Segment_1d12.F0_1d12_6c97();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L066b;
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6ec6));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.DI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f1));
			this.oCPU.AX.High = this.oCPU.SUBByte(this.oCPU.AX.High, this.oCPU.AX.High);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f0));
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0645); // stack management - push return offset
			// Instruction address 0x1ade:0x0640, size: 5
			this.oParent.Segment_2aea.F0_2aea_1942();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.CX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.DI.Word + 0x70f1));
			this.oCPU.CX.High = this.oCPU.SUBByte(this.oCPU.CX.High, this.oCPU.CX.High);
			this.oCPU.PushWord(this.oCPU.CX.Word);
			this.oCPU.CX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.DI.Word + 0x70f0));
			this.oCPU.PushWord(this.oCPU.CX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x146), this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x065d); // stack management - push return offset
			// Instruction address 0x1ade:0x0658, size: 5
			this.oParent.Segment_2aea.F0_2aea_1942();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.CMPWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x146)));
			if (this.oCPU.Flags.NE) goto L066b;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6), 0x1);

		L066b:
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, 0xe3c4), 0x4);
			if (this.oCPU.Flags.NE) goto L0675;
			goto L082f;

		L0675:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0), 0x1);
			goto L06a3;

		L067d:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)), 0x15);
			if (this.oCPU.Flags.G) goto L0687;
			goto L07e3;

		L0687:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6ece), 0xffff);
			if (this.oCPU.Flags.E) goto L069f;
			this.oCPU.AX.Word = 0x1;
			this.oCPU.CX.Low = this.oCPU.ReadByte(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.AX.Word = this.oCPU.SHLWord(this.oCPU.AX.Word, this.oCPU.CX.Low);
			this.oCPU.TESTWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x4cd8));
			if (this.oCPU.Flags.NE) goto L069f;
			goto L07e3;

		L069f:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0))));

		L06a3:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)), 0x18);
			if (this.oCPU.Flags.LE) goto L06ad;
			goto L082f;

		L06ad:
			this.oCPU.AX.Word = 0x1e;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0xbb6)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x06c1); // stack management - push return offset
			// Instruction address 0x1ade:0x06be, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L069f;
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70ec));
			this.oCPU.DX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70ee));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x14a), this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x148), this.oCPU.DX.Word);
			this.oCPU.AX.Word = 0x1;
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.CX.Low = this.oCPU.ReadByte(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0));
			this.oCPU.CX.Low = this.oCPU.DECByte(this.oCPU.CX.Low);
			// Instruction address 0x1ade:0x06ea, size: 5
			this.oParent.MSCAPI._aFlshl();

			this.oCPU.AX.Word = this.oCPU.ANDWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x14a)));
			this.oCPU.DX.Word = this.oCPU.ANDWord(this.oCPU.DX.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x148)));
			this.oCPU.DX.Word = this.oCPU.ORWord(this.oCPU.DX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L069f;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)), 0x7);
			if (this.oCPU.Flags.NE) goto L0709;
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x14a)), 0x1);
			if (this.oCPU.Flags.NE) goto L069f;

		L0709:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)), 0xf);
			if (this.oCPU.Flags.NE) goto L0723;
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.TESTWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70ec)), 0x8000);
			if (this.oCPU.Flags.E) goto L0723;
			goto L069f;

		L0723:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)), 0xa);
			if (this.oCPU.Flags.NE) goto L074e;
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70ec)), 0x10);
			if (this.oCPU.Flags.NE) goto L074e;
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0xc4c));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0744); // stack management - push return offset
			// Instruction address 0x1ade:0x0741, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L074e;
			goto L069f;

		L074e:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)), 0xc);
			if (this.oCPU.Flags.NE) goto L0779;
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70ec)), 0x20);
			if (this.oCPU.Flags.NE) goto L0779;
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0xc6a));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x076f); // stack management - push return offset
			// Instruction address 0x1ade:0x076c, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L0779;
			goto L069f;

		L0779:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)), 0x14);
			if (this.oCPU.Flags.NE) goto L0792;
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f2)), 0x8);
			if (this.oCPU.Flags.NE) goto L0792;
			goto L069f;

		L0792:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)), 0x13);
			if (this.oCPU.Flags.NE) goto L07ac;
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.TESTWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70ec)), 0x4000);
			if (this.oCPU.Flags.NE) goto L07ac;
			goto L069f;

		L07ac:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)), 0x13);
			if (this.oCPU.Flags.E) goto L07c4;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)), 0x14);
			if (this.oCPU.Flags.E) goto L07c4;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)), 0x15);
			if (this.oCPU.Flags.E) goto L07c4;
			goto L067d;

		L07c4:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6)), 0x0);
			if (this.oCPU.Flags.E) goto L07cd;
			goto L069f;

		L07cd:
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.TESTWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70ee)), 0x1c);
			if (this.oCPU.Flags.NE) goto L07e0;
			goto L067d;

		L07e0:
			goto L069f;

		L07e3:
			this.oCPU.AX.Word = 0x1e;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0xb9a);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x07f9); // stack management - push return offset
			// Instruction address 0x1ade:0x07f4, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0xbb2)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0807); // stack management - push return offset
			// Instruction address 0x1ade:0x0804, size: 3
			F0_1ade_14ed();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x2255; // Segment
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0817); // stack management - push return offset
			// Instruction address 0x1ade:0x0812, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.DI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa))));
			this.oCPU.DI.Word = this.oCPU.SHLWord(this.oCPU.DI.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0));
			this.oCPU.AX.Word = this.oCPU.NEGWord(this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + this.oCPU.DI.Word - 0xde), this.oCPU.AX.Word);
			goto L069f;

		L082f:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0), 0x19);

		L0835:
			this.oCPU.AX.Word = 0x1e;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0xbb6)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0849); // stack management - push return offset
			// Instruction address 0x1ade:0x0846, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L08cf;
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x6e78)), 0xffff);
			if (this.oCPU.Flags.NE) goto L08cf;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x10ce)), 0x7f);
			if (this.oCPU.Flags.E) goto L0886;
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x10ce));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.ES.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x63ee);
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.ES.Word, (ushort)(this.oCPU.BX.Word + 0x4b0)), 0x7);
			if (this.oCPU.Flags.E) goto L0886;
			this.oCPU.AX.Word = 0x2259;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0883); // stack management - push return offset
			// Instruction address 0x1ade:0x087e, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);

		L0886:
			this.oCPU.AX.Word = 0x1e;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0xb9a);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x089c); // stack management - push return offset
			// Instruction address 0x1ade:0x0897, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0xbb2)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x08aa); // stack management - push return offset
			// Instruction address 0x1ade:0x08a7, size: 3
			F0_1ade_14ed();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x225b;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x08ba); // stack management - push return offset
			// Instruction address 0x1ade:0x08b5, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.DI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa))));
			this.oCPU.DI.Word = this.oCPU.SHLWord(this.oCPU.DI.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0));
			this.oCPU.AX.Word = this.oCPU.NEGWord(this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + this.oCPU.DI.Word - 0xde), this.oCPU.AX.Word);

		L08cf:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0))));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)), 0x2d);
			if (this.oCPU.Flags.G) goto L08dd;
			goto L0835;

		L08dd:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L092a;
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f2)), 0x10);
			if (this.oCPU.Flags.NE) goto L092a;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa)), 0x1e);
			if (this.oCPU.Flags.LE) goto L092a;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x13a)), 0x0);
			if (this.oCPU.Flags.NE) goto L090a;

		L0901:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x13a), 0x1);
			goto L0447;

		L090a:
			this.oCPU.AX.Word = 0x225f;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x138));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0xba06);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x091b); // stack management - push return offset
			// Instruction address 0x1ade:0x0916, size: 5
			this.oParent.MSCAPI.strcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x136));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + this.oCPU.SI.Word - 0xde), 0x63); // Segment

		L092a:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x13a)), 0x2);
			if (this.oCPU.Flags.NE) goto L094f;
			this.oCPU.AX.Word = 0x2268;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x093e); // stack management - push return offset
			// Instruction address 0x1ade:0x0939, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa))));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + this.oCPU.SI.Word - 0xde), 0x62);

		L094f:
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f1));
			this.oCPU.AX.High = this.oCPU.SUBByte(this.oCPU.AX.High, this.oCPU.AX.High);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f0));
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0968); // stack management - push return offset
			// Instruction address 0x1ade:0x0963, size: 5
			this.oParent.Segment_2aea.F0_2aea_1942();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x13e), this.oCPU.AX.Word);
			this.oCPU.DI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.CX.Low = 0x5;
			this.oCPU.DI.Word = this.oCPU.SHLWord(this.oCPU.DI.Word, this.oCPU.CX.Low);
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.DI.Word - 0x1968));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x142), this.oCPU.AX.Word);
			this.oCPU.CMPWord(this.oCPU.AX.Word, 0x1);
			if (this.oCPU.Flags.E) goto L098c;
			this.oCPU.CMPWord(this.oCPU.AX.Word, 0x2);
			if (this.oCPU.Flags.NE) goto L0991;

		L098c:
			this.oCPU.AX.Word = 0x1; // Segment
			goto L0993;

		L0991:
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);

		L0993:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x13c), this.oCPU.AX.Word);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x8078), 0x0);
			if (this.oCPU.Flags.E) goto L09ab;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x142)), 0x5);
			if (this.oCPU.Flags.NE) goto L09ab;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x13c), 0x1);

		L09ab:
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x2104)), 0x1);
			if (this.oCPU.Flags.LE) goto L09bc;
			this.oCPU.AX.Word = 0x2;
			goto L09bf;

		L09bc:
			this.oCPU.AX.Word = 0x1;

		L09bf:
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.DS.Word, 0xe3c6));
			this.oCPU.CX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x70da);
			this.oCPU.CX.Word = this.oCPU.SUBWord(this.oCPU.CX.Word, this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f3));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.AX.Word = this.oCPU.SHLWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.CX.Word = this.oCPU.SUBWord(this.oCPU.CX.Word, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2), this.oCPU.CX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0), 0x0); // Segment

		L09e3:
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.SI.Word = this.oCPU.ADDWord(this.oCPU.SI.Word, this.oCPU.BP.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x11a), 0x1);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x44), 0x0);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0))));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)), 0x1c);
			if (this.oCPU.Flags.L) goto L09e3;
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.SI.Word = this.oCPU.ADDWord(this.oCPU.SI.Word, 0x6b76);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, this.oCPU.SI.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x140), this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, this.oCPU.SI.Word, 0x0);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4a), 0x0);

		L0a19:
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4a)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f2)), 0xff);
			if (this.oCPU.Flags.E) goto L0aa5;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f7));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.CMPWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			if (this.oCPU.Flags.NE) goto L0aa5;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f1));
			this.oCPU.AX.High = this.oCPU.SUBByte(this.oCPU.AX.High, this.oCPU.AX.High);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f0));
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0a43); // stack management - push return offset
			// Instruction address 0x1ade:0x0a3e, size: 5
			this.oParent.Segment_2aea.F0_2aea_1942();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.CMPWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x13e)));
			if (this.oCPU.Flags.NE) goto L0aa5;
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f5)), 0x0);
			if (this.oCPU.Flags.L) goto L0a68;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4a)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L0a68;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f5));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.DI.Word = this.oCPU.AX.Word;
			this.oCPU.DI.Word = this.oCPU.SHLWord(this.oCPU.DI.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + this.oCPU.DI.Word - 0x11a), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + this.oCPU.DI.Word - 0x11a))));

		L0a68:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x11c), 0x0);

		L0a6e:
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4a)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x11c));
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word + 0x7106));
			this.oCPU.WriteByte(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x14a), this.oCPU.AX.Low);
			this.oCPU.CMPByte(this.oCPU.AX.Low, 0xff);
			if (this.oCPU.Flags.E) goto L0a9a;
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x6b76), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x6b76))));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.SI.Word = this.oCPU.ANDWord(this.oCPU.SI.Word, 0x3f);
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + this.oCPU.SI.Word - 0x44), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + this.oCPU.SI.Word - 0x44))));

		L0a9a:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x11c), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x11c))));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x11c)), 0x2);
			if (this.oCPU.Flags.L) goto L0a6e;

		L0aa5:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4a), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4a))));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4a)), 0x80);
			if (this.oCPU.Flags.GE) goto L0ab2;
			goto L0a19;

		L0ab2:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0), 0x0);

		L0ab8:
			this.oCPU.AX.Word = 0x600;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = 0xc;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)));
			this.oCPU.SI.Word = this.oCPU.ADDWord(this.oCPU.SI.Word, this.oCPU.AX.Word);
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x7e29)), 0xff);
			if (this.oCPU.Flags.E) goto L0aff;
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x6b76), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x6b76))));
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x7e2a));
			this.oCPU.AX.High = this.oCPU.SUBByte(this.oCPU.AX.High, this.oCPU.AX.High);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x7e2b));
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0aea); // stack management - push return offset
			// Instruction address 0x1ade:0x0ae5, size: 5
			this.oParent.Segment_2aea.F0_2aea_1942();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.CMPWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x13e)));
			if (this.oCPU.Flags.NE) goto L0aff;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x7e29));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.DI.Word = this.oCPU.AX.Word;
			this.oCPU.DI.Word = this.oCPU.SHLWord(this.oCPU.DI.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + this.oCPU.DI.Word - 0x44), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + this.oCPU.DI.Word - 0x44))));

		L0aff:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0))));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)), 0x80);
			if (this.oCPU.Flags.L) goto L0ab8;
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x6b76)), 0x0);
			if (this.oCPU.Flags.NE) goto L0b2c;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L0b2c;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x2104)), 0x1);
			if (this.oCPU.Flags.G) goto L0b2c;
			this.oCPU.AX.Word = 0x1;
			goto L14e7;

		L0b2c:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), 0x0);
			if (this.oCPU.Flags.NE) goto L0b4a;
			this.oCPU.ES.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x63ee);
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.ES.Word, 0x520), 0x7);
			if (this.oCPU.Flags.NE) goto L0b44;
			this.oCPU.AX.Word = 0x3;
			goto L14e7;

		L0b44:
			this.oCPU.AX.Word = 0x7;
			goto L14e7;

		L0b4a:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8), 0x0);
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f1));
			this.oCPU.AX.High = this.oCPU.SUBByte(this.oCPU.AX.High, this.oCPU.AX.High);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f0));
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0b68); // stack management - push return offset
			// Instruction address 0x1ade:0x0b63, size: 5
			this.oParent.Segment_2aea.F0_2aea_1458();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0), this.oCPU.AX.Word);
			this.oCPU.CMPWord(this.oCPU.AX.Word, 0xffff);
			if (this.oCPU.Flags.NE) goto L0b7b;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8), 0x2);
			goto L0baf;

		L0b7b:
			this.oCPU.AX.Word = 0x2;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0b8b); // stack management - push return offset
			// Instruction address 0x1ade:0x0b86, size: 5
			this.oParent.Segment_1866.F0_1866_1380();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.CX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f3));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.DX.Low = 0x4;
			this.oCPU.IDIVByte(this.oCPU.AX, this.oCPU.DX.Low);
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x13c)));
			this.oCPU.CMPWord(this.oCPU.AX.Word, this.oCPU.CX.Word);
			if (this.oCPU.Flags.LE) goto L0baf;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8), 0x1);

		L0baf:
			this.oCPU.AX.Word = 0x3e7;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x11e), this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x130), this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4c), this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xffff;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xc), this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x48), this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0), 0x1);
			goto L0f57;

		L0bcf:
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f2)), 0x1);
			if (this.oCPU.Flags.NE) goto L0be1;
			goto L0ed5;

		L0be1:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), 0xfffc);
			goto L0ed5;

		L0bea:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd2e0);
			this.oCPU.AX.Word = this.oCPU.SHLWord(this.oCPU.AX.Word, 0x1);

		L0bef:
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, 0xc);

		L0bf2:
			this.oCPU.AX.Word = this.oCPU.NEGWord(this.oCPU.AX.Word);

		L0bf4:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.AX.Word);
			goto L0ed5;

		L0bfb:
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f2)), 0x1);
			if (this.oCPU.Flags.NE) goto L0c0d;
			goto L0ed5;

		L0c0d:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), 0xfffe); // Segment
			goto L0ed5;

		L0c16:
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f2)), 0x1);
			if (this.oCPU.Flags.NE) goto L0c28;
			goto L0ed5;

		L0c28:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), 0xffff); // Segment
			goto L0ed5;

		L0c31:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), 0x5);

		L0c37:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x132), 0x1);
			goto L0ed5;

		L0c40:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x70dc), 0x3);
			if (this.oCPU.Flags.L) goto L0c4c;

		L0c47:
			this.oCPU.AX.Word = 0x4;
			goto L0bf4;

		L0c4c:
			this.oCPU.AX.Word = 0x8;
			goto L0bf4;

		L0c51:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x70dc);
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.SARWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, 0xd);
			goto L0bf2;

		L0c5e:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x70dc);
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.CX.Word = 0x5;
			this.oCPU.IDIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			goto L0bef;

		L0c69:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x70dc);
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.AX.Word = this.oCPU.XORWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.CX.Word = 0x3;
			this.oCPU.AX.Word = this.oCPU.SARWord(this.oCPU.AX.Word, this.oCPU.CX.Low);
			this.oCPU.AX.Word = this.oCPU.XORWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			goto L0bef;

		L0c7d:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x70de);
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.SARWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, 0xa);
			this.oCPU.AX.Word = this.oCPU.NEGWord(this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f2)), 0x1);
			if (this.oCPU.Flags.NE) goto L0ca0;
			goto L0ed5;

		L0ca0:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), 0xfffd);
			goto L0ed5;

		L0ca9:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x70de);
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.CX.Word = 0x3;
			this.oCPU.IDIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);

		L0cb2:
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, 0xa);
			goto L0bf2;

		L0cb8:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x70de);
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.AX.Word = this.oCPU.XORWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.CX.Word = 0x2;
			this.oCPU.AX.Word = this.oCPU.SARWord(this.oCPU.AX.Word, this.oCPU.CX.Low);
			this.oCPU.AX.Word = this.oCPU.XORWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			goto L0cb2;

		L0ccb:
			this.oCPU.AX.Word = 0x1c; // Segment
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f3));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.CX.Low = 0x2;
			this.oCPU.IDIVByte(this.oCPU.AX, this.oCPU.CX.Low);
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, 0xa);
			this.oCPU.AX.Word = this.oCPU.NEGWord(this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.AX.Word);
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70ec)), 0x1);
			if (this.oCPU.Flags.NE) goto L0cf0;
			goto L0c37;

		L0cf0:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.SUBWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)), 0x4));
			goto L0c37;

		L0cf8:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2));
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.SARWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f3));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.DI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = 0xa;
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.SI.Word);
			this.oCPU.CMPWord(this.oCPU.AX.Word, this.oCPU.DI.Word);
			if (this.oCPU.Flags.LE) goto L0d1d;
			goto L0ed5;

		L0d1d:
			this.oCPU.AX.Word = this.oCPU.DI.Word;
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, this.oCPU.SI.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, 0xe);
			goto L0bf2;

		L0d27:
			this.oCPU.AX.Word = 0x1;
			this.oCPU.CX.Low = this.oCPU.ReadByte(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.AX.Word = this.oCPU.SHLWord(this.oCPU.AX.Word, this.oCPU.CX.Low);
			this.oCPU.DX.Word = 0x1;
			this.oCPU.CX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, 0xd7ee);
			this.oCPU.DX.Word = this.oCPU.SHLWord(this.oCPU.DX.Word, this.oCPU.CX.Low);
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.TESTWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x4cd8));
			if (this.oCPU.Flags.E) goto L0d43;
			goto L0ed5;

		L0d43:
			this.oCPU.AX.Word = 0x1;
			this.oCPU.CX.Low = this.oCPU.ADDByte(this.oCPU.CX.Low, 0x8);
			this.oCPU.AX.Word = this.oCPU.SHLWord(this.oCPU.AX.Word, this.oCPU.CX.Low);
			this.oCPU.TESTWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x4cd8));
			if (this.oCPU.Flags.NE) goto L0d54;
			goto L0c47;

		L0d54:
			this.oCPU.AX.Word = 0x2;
			goto L0bf4;

		L0d5a:
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x7105)), 0xff);
			if (this.oCPU.Flags.NE) goto L0da7;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x70de);
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.SARWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, 0xa);
			this.oCPU.AX.Word = this.oCPU.NEGWord(this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.AX.Word);
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x7103)), 0xff);
			if (this.oCPU.Flags.E) goto L0d86;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.ADDWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)), 0x2));

		L0d86:
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x7104)), 0xff);
			if (this.oCPU.Flags.E) goto L0d9a;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.ADDWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)), 0x2));

		L0d9a:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)), 0x3);
			if (this.oCPU.Flags.GE) goto L0da7;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), 0x3);

		L0da7:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L0db2;
			goto L0ed5;

		L0db2:
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f2)), 0x10);
			if (this.oCPU.Flags.NE) goto L0dc4;
			goto L0ed5;

		L0dc4:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), 0x3e7);
			goto L0ed5;

		L0dcd:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee), 0x0);
			if (this.oCPU.Flags.G) goto L0dd7;
			goto L0ed5;

		L0dd7:
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.CX.Low = 0x4;
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, this.oCPU.CX.Low);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee);
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word - 0x1b68)), 0x2);
			if (this.oCPU.Flags.E) goto L0dee;
			goto L0ed5;

		L0dee:
			this.oCPU.AX.Word = 0x38;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x2cc4)), 0x0);
			if (this.oCPU.Flags.LE) goto L0e00;
			goto L0ed5;

		L0e00:
			// Instruction address 0x1ade:0x0e04, size: 5
			this.oParent.Segment_2dc4.F0_2dc4_005d_GetRandomNumber(5);

			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4a), this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x1;
			this.oCPU.CX.Low = this.oCPU.ReadByte(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.AX.Word = this.oCPU.SHLWord(this.oCPU.AX.Word, this.oCPU.CX.Low);
			this.oCPU.TESTWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x2a6e));
			if (this.oCPU.Flags.NE) goto L0e20;
			goto L0ed5;

		L0e20:
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4a));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.AX.Word = 0xa;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.DI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word - 0x1c38));
			this.oCPU.AX.Word = 0xa;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word - 0x1c38));
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.DI.Word);
			this.oCPU.CMPWord(this.oCPU.AX.Word, this.oCPU.DI.Word);
			if (this.oCPU.Flags.NE) goto L0e47;
			goto L0ed5;

		L0e47:
			this.oCPU.AX.Word = 0xa;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x5;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x1768));
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee);
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x1768)));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0xa);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x0e6b); // stack management - push return offset
			// Instruction address 0x1ade:0x0e66, size: 5
			this.oParent.Segment_2dc4.F0_2dc4_007c();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			goto L0bf4;

		L0ed5:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)), 0x190);
			if (this.oCPU.Flags.GE) goto L0f1c;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x132));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x13c)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L0eec;
			this.oCPU.AX.Word = 0x14;
			goto L0eef;

		L0eec:
			this.oCPU.AX.Word = 0xa;

		L0eef:
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.AX.Word);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.AX.Word = 0x3a;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x280c)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.CX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x1516));
			this.oCPU.CX.Word = this.oCPU.ADDWord(this.oCPU.CX.Word, 0x3);
			this.oCPU.AX.Word = 0x3;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)));
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.IDIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.AX.Word);
			goto L0f22;

		L0f1c:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), 0x3fff);

		L0f22:
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70ec)), 0x2);
			if (this.oCPU.Flags.NE) goto L0f34;
			goto L1206;

		L0f34:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134));
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.AX.Word = this.oCPU.XORWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.CX.Word = 0x2;
			this.oCPU.AX.Word = this.oCPU.SARWord(this.oCPU.AX.Word, this.oCPU.CX.Low);
			this.oCPU.AX.Word = this.oCPU.XORWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.ADDWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)), this.oCPU.AX.Word));
			goto L1206;

		L0f4d:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)), 0x17);
			if (this.oCPU.Flags.NE) goto L0f9d;

		L0f53:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0))));

		L0f57:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.L) goto L0f63;
			goto L1268;

		L0f63:
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + this.oCPU.SI.Word - 0xde));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46), this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.L) goto L0f79;
			this.oCPU.CMPWord(this.oCPU.AX.Word, 0x1a);
			if (this.oCPU.Flags.L) goto L0f4d;

		L0f79:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), 0x3e7);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x132), 0x0);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46));
			this.oCPU.AX.Word = this.oCPU.NEGWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, 0xffe5);
			this.oCPU.CMPWord(this.oCPU.AX.Word, 0x31);
			if (this.oCPU.Flags.BE) goto L0f95;
			goto L0ed5;

		L0f95:
			switch(this.oCPU.AX.Word)
			{
				case 0:
					goto L0d5a;
				case 1:
					goto L0dcd;
				case 2:
					goto L0ed5;
				case 3:
					goto L0ed5;
				case 4:
					goto L0ed5;
				case 5:
					goto L0ed5;
				case 6:
					goto L0ed5;
				case 7:
					goto L0ed5;
				case 8:
					goto L0ed5;
				case 9:
					goto L0ed5;
				case 10:
					goto L0ed5;
				case 11:
					goto L0ed5;
				case 12:
					goto L0ed5;
				case 13:
					goto L0ed5;
				case 14:
					goto L0ed5;
				case 15:
					goto L0ed5;
				case 16:
					goto L0ed5;
				case 17:
					goto L0ed5;
				case 18:
					goto L0ed5;
				case 19:
					goto L0ed5;
				case 20:
					goto L0ed5;
				case 21:
					goto L0ed5;
				case 22:
					goto L0ed5;
				case 23:
					goto L0ed5;
				case 24:
					goto L0ed5;
				case 25:
					goto L0ed5;
				case 26:
					goto L0ed5;
				case 27:
					goto L0ed5;
				case 28:
					goto L0ed5;
				case 29:
					goto L0c31;
				case 30:
					goto L0c40;
				case 31:
					goto L0bcf;
				case 32:
					goto L0c7d;
				case 33:
					goto L0ca9;
				case 34:
					goto L0bea;
				case 35:
					goto L0ccb;
				case 36:
					goto L0cf8;
				case 37:
					goto L0ca9;
				case 38:
					goto L0bfb;
				case 39:
					goto L0cb8;
				case 40:
					goto L0ed5;
				case 41:
					goto L0c16;
				case 42:
					goto L0c51;
				case 43:
					goto L0c69;
				case 44:
					goto L0ed5;
				case 45:
					goto L0c69;
				case 46:
					goto L0c5e;
				case 47:
					goto L0c51;
				case 48:
					goto L0c69;
				case 49:
					goto L0d27;
			}

		L0f9d:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)), 0x0);
			if (this.oCPU.Flags.NE) goto L0fd2;
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x2104)), 0x1);
			if (this.oCPU.Flags.LE) goto L0fb4;
			this.oCPU.AX.Word = 0x2;
			goto L0fb7;

		L0fb4:
			this.oCPU.AX.Word = 0x1;

		L0fb7:
			this.oCPU.CMPWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2)));
			if (this.oCPU.Flags.L) goto L0fd2;
			this.oCPU.AX.Word = 0x38;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x4c42)), 0x0);
			if (this.oCPU.Flags.NE) goto L0f53;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x11a)), 0x1);
			if (this.oCPU.Flags.G) goto L0f53;

		L0fd2:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)), 0x1);
			if (this.oCPU.Flags.NE) goto L0fe7;
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x2104)), 0x1);
			if (this.oCPU.Flags.LE) goto L0fe7;
			goto L0f53;

		L0fe7:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)), 0x19);
			if (this.oCPU.Flags.NE) goto L1009;
			this.oCPU.AX.Word = 0x38;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x4c10)), 0x4);
			if (this.oCPU.Flags.L) goto L0fff;
			goto L0f53;

		L0fff:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x2cc6)), 0x2);
			if (this.oCPU.Flags.L) goto L1009;
			goto L0f53;

		L1009:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)), 0xe);
			if (this.oCPU.Flags.NE) goto L1054;
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.AX.Word = 0x38;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.SI.Word = this.oCPU.ADDWord(this.oCPU.SI.Word, this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x38;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x4c24));
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.SARWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.CX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x4c42));
			this.oCPU.CX.Word = this.oCPU.ADDWord(this.oCPU.CX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x2cf8)));
			this.oCPU.CMPWord(this.oCPU.CX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.L) goto L103d;
			goto L0f53;

		L103d:
			this.oCPU.DI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.CX.Low = 0x4;
			this.oCPU.DI.Word = this.oCPU.SHLWord(this.oCPU.DI.Word, this.oCPU.CX.Low);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee);
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.DI.Word - 0x1b68)), 0x2);
			if (this.oCPU.Flags.E) goto L1054;
			goto L0f53;

		L1054:
			this.oCPU.AX.Word = 0x22;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x1138)), 0x0);
			if (this.oCPU.Flags.NE) goto L1075;
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.SI.Word = this.oCPU.ADDWord(this.oCPU.SI.Word, this.oCPU.BP.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x11a));
			this.oCPU.AX.Word = this.oCPU.SHLWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x44)));
			goto L10c7;

		L1075:
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.CX.Low = 0x5;
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, this.oCPU.CX.Low);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x13e));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word + 0x6cac)), 0x8);
			if (this.oCPU.Flags.GE) goto L108c;
			goto L0f53;

		L108c:
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.AX.Word = 0x38;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.SI.Word = this.oCPU.ADDWord(this.oCPU.SI.Word, this.oCPU.AX.Word);
			this.oCPU.CX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x2cf8));
			this.oCPU.CX.Word = this.oCPU.SHLWord(this.oCPU.CX.Word, 0x1);
			this.oCPU.CX.Word = this.oCPU.ADDWord(this.oCPU.CX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word - 0x4c42)));
			this.oCPU.DI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.DX.Word = this.oCPU.CX.Word;
			this.oCPU.CX.Low = 0x5;
			this.oCPU.DI.Word = this.oCPU.SHLWord(this.oCPU.DI.Word, this.oCPU.CX.Low);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x13e));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.DI.Word + 0x6cac));
			this.oCPU.CX.Word = this.oCPU.DX.Word;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.CX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x6b76));
			this.oCPU.CX.Word = this.oCPU.INCWord(this.oCPU.CX.Word);
			this.oCPU.IDIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);

		L10c7:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.AX.Word);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8)), 0x0);
			if (this.oCPU.Flags.E) goto L10f0;
			this.oCPU.AX.Word = 0x22;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x1148)), 0x2);
			if (this.oCPU.Flags.E) goto L10e3;
			goto L0f53;

		L10e3:
			this.oCPU.AX.Word = 0x2;
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.CX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8));
			this.oCPU.IDIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.AX.Word);

		L10f0:
			this.oCPU.AX.Word = 0x22;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x1148));
			this.oCPU.CMPWord(this.oCPU.SI.Word, 0x2);
			if (this.oCPU.Flags.E) goto L1113;
			this.oCPU.SI.Word = this.oCPU.ORWord(this.oCPU.SI.Word, this.oCPU.SI.Word);
			if (this.oCPU.Flags.E) goto L1113;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.SHLWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)), 0x1));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x142)), this.oCPU.SI.Word);
			if (this.oCPU.Flags.E) goto L1113;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.SHLWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)), 0x1));

		L1113:
			this.oCPU.AX.Word = 0x22;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x1148)), 0x5);
			if (this.oCPU.Flags.NE) goto L113c;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x142)), 0x5);
			if (this.oCPU.Flags.E) goto L112c;
			goto L0f53;

		L112c:
			this.oCPU.AX.Word = 0x3;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)));
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.SARWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.AX.Word);

		L113c:
			this.oCPU.AX.Word = 0x22;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)), 0x0);
			if (this.oCPU.Flags.NE) goto L1179;
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70ec)), 0x4);
			if (this.oCPU.Flags.E) goto L115e;
			this.oCPU.AX.Word = 0x4;
			goto L1161;

		L115e:
			this.oCPU.AX.Word = 0x6;

		L1161:
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.CX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = 0x3a;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x280c)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.CX.Word;
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x1516)));
			goto L117c;

		L1179:
			this.oCPU.AX.Word = 0x10;

		L117c:
			this.oCPU.CX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x1142));
			this.oCPU.CX.Word = this.oCPU.INCWord(this.oCPU.CX.Word);
			this.oCPU.CX.Word = this.oCPU.INCWord(this.oCPU.CX.Word);
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)));
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.CX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x113e));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x1140)));
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x113a));
			this.oCPU.BX.Word = this.oCPU.INCWord(this.oCPU.BX.Word);
			this.oCPU.DI.Word = this.oCPU.DX.Word;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.BX.Word);
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.CX.Word;
			this.oCPU.DX.Word = this.oCPU.DI.Word;
			this.oCPU.IDIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.BX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.AX.Word);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x1148)), 0x3);
			if (this.oCPU.Flags.NE) goto L11c6;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x13c)), 0x0);
			if (this.oCPU.Flags.E) goto L11bb;
			this.oCPU.AX.Word = 0x4;
			goto L11be;

		L11bb:
			this.oCPU.AX.Word = 0x2;

		L11be:
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.AX.Word);

		L11c6:
			this.oCPU.AX.Word = 0x22;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x1138)), 0x1);
			if (this.oCPU.Flags.NE) goto L11d9;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.SHLWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)), 0x1));

		L11d9:
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x6b76)), 0x78);
			if (this.oCPU.Flags.LE) goto L11eb;
			this.oCPU.CX.Low = 0x2;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.SHLWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)), this.oCPU.CX.Low));

		L11eb:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x13c)), 0x0);
			if (this.oCPU.Flags.NE) goto L11fb;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xdeb8);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x70dc), this.oCPU.AX.Word);
			if (this.oCPU.Flags.LE) goto L1202;

		L11fb:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6ed4), 0x0);
			if (this.oCPU.Flags.NE) goto L1206;

		L1202:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.SHLWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)), 0x1));

		L1206:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4c));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.GE) goto L121e;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x144), this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4c), this.oCPU.AX.Word);

		L121e:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)), 0x0);
			if (this.oCPU.Flags.L) goto L122a;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)), 0x1a);
			if (this.oCPU.Flags.L) goto L1249;

		L122a:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x130));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.L) goto L1237;
			goto L0f53;

		L1237:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x130), this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x48), this.oCPU.AX.Word);
			goto L0f53;

		L1249:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x11e));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.L) goto L1256;
			goto L0f53;

		L1256:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x11e), this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xe0));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xc), this.oCPU.AX.Word);
			goto L0f53;

		L1268:
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x140));
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x6b76), this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x1;
			this.oCPU.CX.Low = this.oCPU.ReadByte(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.AX.Word = this.oCPU.SHLWord(this.oCPU.AX.Word, this.oCPU.CX.Low);
			this.oCPU.TESTWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x7f36));
			if (this.oCPU.Flags.NE) goto L12a5;
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f5)), 0xff);
			if (this.oCPU.Flags.NE) goto L1298;
			this.oCPU.AX.Word = 0xffff;
			goto L14e7;

		L1298:
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x144));

		L129c:
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + this.oCPU.SI.Word - 0xde));
			goto L14e7;

		L12a5:
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f2)), 0x10);
			if (this.oCPU.Flags.E) goto L12cd;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x48)), 0xffff);
			if (this.oCPU.Flags.E) goto L12c7;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x130)), 0x1f4);
			if (this.oCPU.Flags.G) goto L12c7;
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x48));
			goto L129c;

		L12c7:
			this.oCPU.AX.Word = 0x63;
			goto L14e7;

		L12cd:
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, 0x19c0), 0x1);
			if (this.oCPU.Flags.NE) goto L12d7;
			goto L1438;

		L12d7:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4)), 0x0);
			if (this.oCPU.Flags.E) goto L12e0;
			goto L1438;

		L12e0:
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xaa);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x10), 0x2);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xc)), 0xffff);
			if (this.oCPU.Flags.NE) goto L12f2;
			goto L1388;

		L12f2:
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xc));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + this.oCPU.SI.Word - 0xde));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.L) goto L130f;
			this.oCPU.AX.Word = 0x22;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0x112a);
			goto L131d;

		L130f:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134));
			this.oCPU.AX.Word = this.oCPU.NEGWord(this.oCPU.AX.Word);
			this.oCPU.CX.Word = 0x1e;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0xb9a);

		L131d:
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord((ushort)(this.oCPU.BP.Word - 0x12d));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1328); // stack management - push return offset
			// Instruction address 0x1ade:0x1323, size: 5
			this.oParent.MSCAPI.strcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x2271;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1338); // stack management - push return offset
			// Instruction address 0x1ade:0x1333, size: 5
			this.oParent.MSCAPI.strcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.PushWord((ushort)(this.oCPU.BP.Word - 0x12e));
			this.oCPU.AX.Word = 0x2284;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1349); // stack management - push return offset
			// Instruction address 0x1ade:0x1344, size: 5
			this.oParent.Segment_2f4d.F0_2f4d_01ad();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.PushWord((ushort)(this.oCPU.BP.Word - 0x12d));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x30be));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x135a); // stack management - push return offset
			// Instruction address 0x1ade:0x1355, size: 5
			this.oParent.MSCAPI.strcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1362); // stack management - push return offset
			// Instruction address 0x1ade:0x135d, size: 5
			this.oParent.Segment_2f4d.F0_2f4d_0471();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.AX.Word = 0x32;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x136b); // stack management - push return offset
			// Instruction address 0x1ade:0x1366, size: 5
			this.oParent.Segment_2f4d.F0_2f4d_0000();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x2);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xdb38, 0x1);
			this.oCPU.AX.Word = 0xa0;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x8;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1385); // stack management - push return offset
			// Instruction address 0x1ade:0x1380, size: 5
			this.oParent.Segment_1238.F0_1238_0008();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);

		L1388:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x48)), 0xffff);
			if (this.oCPU.Flags.NE) goto L1391;
			goto L1427;

		L1391:
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x48));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + this.oCPU.SI.Word - 0xde));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.L) goto L13ae;
			this.oCPU.AX.Word = 0x22;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0x112a);
			goto L13bc;

		L13ae:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134));
			this.oCPU.AX.Word = this.oCPU.NEGWord(this.oCPU.AX.Word);
			this.oCPU.CX.Word = 0x1e;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0xb9a);

		L13bc:
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord((ushort)(this.oCPU.BP.Word - 0x12d));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x13c7); // stack management - push return offset
			// Instruction address 0x1ade:0x13c2, size: 5
			this.oParent.MSCAPI.strcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x2290;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x13d7); // stack management - push return offset
			// Instruction address 0x1ade:0x13d2, size: 5
			this.oParent.MSCAPI.strcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.PushWord((ushort)(this.oCPU.BP.Word - 0x12e));
			this.oCPU.AX.Word = 0x22a3;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x13e8); // stack management - push return offset
			// Instruction address 0x1ade:0x13e3, size: 5
			this.oParent.Segment_2f4d.F0_2f4d_01ad();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.PushWord((ushort)(this.oCPU.BP.Word - 0x12d));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x30be));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x13f9); // stack management - push return offset
			// Instruction address 0x1ade:0x13f4, size: 5
			this.oParent.MSCAPI.strcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1401); // stack management - push return offset
			// Instruction address 0x1ade:0x13fc, size: 5
			this.oParent.Segment_2f4d.F0_2f4d_0471();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.AX.Word = 0x32;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x140a); // stack management - push return offset
			// Instruction address 0x1ade:0x1405, size: 5
			this.oParent.Segment_2f4d.F0_2f4d_0000();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x2);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xdb38, 0x1);
			this.oCPU.AX.Word = 0xa0;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xa4;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1424); // stack management - push return offset
			// Instruction address 0x1ade:0x141f, size: 5
			this.oParent.Segment_1238.F0_1238_0008();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);

		L1427:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4), 0x1);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xaa);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x10), 0x1);
			goto L0447;

		L1438:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0xa)), 0x14);
			if (this.oCPU.Flags.G) goto L1445;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x13a)), 0x0);
			if (this.oCPU.Flags.E) goto L144e;

		L1445:
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xaa);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x10), 0x2);

		L144e:
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x2fa0, 0x1);
			this.oCPU.AX.Word = 0x8;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x50;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1465); // stack management - push return offset
			// Instruction address 0x1ade:0x1460, size: 5
			this.oParent.Segment_1238.F0_1238_0008();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + this.oCPU.SI.Word - 0xdc));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134), this.oCPU.AX.Word);
			this.oCPU.CMPWord(this.oCPU.AX.Word, 0x63);
			if (this.oCPU.Flags.NE) goto L1482;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x13a), 0x2);
			goto L0447;

		L1482:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)), 0x62);
			if (this.oCPU.Flags.NE) goto L148c;
			goto L0901;

		L148c:
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xaa);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x10), 0x1);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x2f9c), 0x0);
			if (this.oCPU.Flags.E) goto L14e3;
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x14a1); // stack management - push return offset
			// Instruction address 0x1ade:0x149c, size: 5
			this.oParent.Segment_11a8.F0_11a8_0268();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x14a6); // stack management - push return offset
			// Instruction address 0x1ade:0x14a1, size: 5
			this.oParent.Segment_1866.F0_1866_25b6();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x3c62, 0x1);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)), 0x0);
			if (this.oCPU.Flags.L) goto L14bd;
			this.oCPU.AX.Word = 0x2;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134)));
			goto L14c8;

		L14bd:
			this.oCPU.AX.Word = 0x1;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134));
			this.oCPU.AX.Word = this.oCPU.NEGWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);

		L14c8:
			// Call to overlay
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x14cd); // stack management - push return offset
			this.oParent.Overlay_8.F8_0000_062a();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x14d5); // stack management - push return offset
			// Instruction address 0x1ade:0x14d0, size: 5
			this.oParent.Segment_1866.F0_1866_25d7();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x14da); // stack management - push return offset
			// Instruction address 0x1ade:0x14d5, size: 5
			this.oParent.Segment_11a8.F0_11a8_0250();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x6b64, 0x1);
			goto L0447;

		L14e3:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x134));

		L14e7:
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.SP.Word = this.oCPU.BP.Word;
			this.oCPU.BP.Word = this.oCPU.PopWord();
			// Far return
			this.oCPU.Log.ExitBlock("'F0_1ade_0421'");
		}

		public void F0_1ade_14ed()
		{
			this.oCPU.Log.EnterBlock("'F0_1ade_14ed'(Cdecl, Far) at 0x1ade:0x14ed");
			this.oCPU.CS.Word = 0x1ade; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.SP.Word = this.oCPU.SUBWord(this.oCPU.SP.Word, 0x2);
			this.oCPU.AX.Word = 0x3e7;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x1;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x63;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x1;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x70dc);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd2f6));
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1510); // stack management - push return offset
			// Instruction address 0x1ade:0x150b, size: 5
			this.oParent.Segment_2dc4.F0_2dc4_007c();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.CX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = 0xa;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70fa)));
			this.oCPU.AX.Word = this.oCPU.DECWord(this.oCPU.AX.Word);
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.IDIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			this.oCPU.AX.Word = this.oCPU.INCWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1532); // stack management - push return offset
			// Instruction address 0x1ade:0x152d, size: 5
			this.oParent.Segment_2dc4.F0_2dc4_007c();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2), this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x22af;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1545); // stack management - push return offset
			// Instruction address 0x1ade:0x1540, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0xa;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xd80a;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1558); // stack management - push return offset
			// Instruction address 0x1ade:0x1553, size: 5
			this.oParent.MSCAPI.itoa();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1565); // stack management - push return offset
			// Instruction address 0x1ade:0x1560, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2)), 0x1);
			if (this.oCPU.Flags.E) goto L1573;
			this.oCPU.AX.Word = 0x22b2;
			goto L1576;

		L1573:
			this.oCPU.AX.Word = 0x22b9;

		L1576:
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1580); // stack management - push return offset
			// Instruction address 0x1ade:0x157b, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.BP.Word;
			this.oCPU.BP.Word = this.oCPU.PopWord();
			// Far return
			this.oCPU.Log.ExitBlock("'F0_1ade_14ed'");
		}

		public void F0_1ade_1584()
		{
			this.oCPU.Log.EnterBlock("'F0_1ade_1584'(Cdecl, Far) at 0x1ade:0x1584");
			this.oCPU.CS.Word = 0x1ade; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.SP.Word = this.oCPU.SUBWord(this.oCPU.SP.Word, 0x46);
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), 0x0);
			if (this.oCPU.Flags.NE) goto L1597;

		L1591:
			this.oCPU.AX.Word = 0xffff;
			goto L1d29;

		L1597:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x16), 0x0);
			this.oCPU.AX.Word = 0xffff;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x14), this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x3c), this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46), 0x0);

		L15aa:
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x15b4); // stack management - push return offset
			// Instruction address 0x1ade:0x15b1, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L162c;
			this.oCPU.AX.Word = 0x16;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x4ee));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x15d0); // stack management - push return offset
			// Instruction address 0x1ade:0x15cd, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L162c;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x4ef));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x15e4); // stack management - push return offset
			// Instruction address 0x1ade:0x15e1, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L162c;
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x15f5); // stack management - push return offset
			// Instruction address 0x1ade:0x15f2, size: 3
			F0_1ade_2317();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.SHLWord(this.oCPU.AX.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.SHLWord(this.oCPU.AX.Word, 0x1);
			
			// Instruction address 0x1ade:0x15fd, size: 5
			this.oParent.Segment_2dc4.F0_2dc4_005d_GetRandomNumber(this.oCPU.AX.Word);

			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x40), this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x3c));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x40)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.LE) goto L162c;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x19be);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L1620;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L162c;

		L1620:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x40));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x3c), this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x14), this.oCPU.AX.Word);

		L162c:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46))));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)), 0x48);
			if (this.oCPU.Flags.GE) goto L1638;
			goto L15aa;

		L1638:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L1647;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x81d2), 0x0);
			if (this.oCPU.Flags.NE) goto L16a5;

		L1647:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x81d2), 0x0);
			if (this.oCPU.Flags.E) goto L167a;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6b86), 0x0);
			if (this.oCPU.Flags.NE) goto L167a;
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x14)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1660); // stack management - push return offset
			// Instruction address 0x1ade:0x165d, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L167a;

			// Instruction address 0x1ade:0x166b, size: 5
			this.oParent.Segment_2dc4.F0_2dc4_005d_GetRandomNumber(2);

			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L167a;
			goto L1591;

		L167a:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x3c)), 0xffff);
			if (this.oCPU.Flags.E) goto L169f;
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x14)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x168d); // stack management - push return offset
			// Instruction address 0x1ade:0x168a, size: 3
			F0_1ade_1d2e();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.AX.Word = 0xffff;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x169c); // stack management - push return offset
			// Instruction address 0x1ade:0x1697, size: 5
			this.oParent.Segment_25fb.F0_25fb_3459();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);

		L169f:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x14));
			goto L1d29;

		L16a5:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x19be), 0xffff);
			if (this.oCPU.Flags.NE) goto L16af;
			goto L19d4;

		L16af:
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x19be));
			// Call to overlay
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x16b8); // stack management - push return offset
			this.oParent.Overlay_8.F8_0000_16c4();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x2);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x44), this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x42), 0x0);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x19be), 0x47);
			if (this.oCPU.Flags.E) goto L16f1;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0xdeba), 0x3);
			if (this.oCPU.Flags.LE) goto L16f1;
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x1;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x16de); // stack management - push return offset
			// Instruction address 0x1ade:0x16d9, size: 5
			this.oParent.Segment_11a8.F0_11a8_02a4();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L16f1;
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, 0x19c0), 0x8);
			if (this.oCPU.Flags.E) goto L16f1;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x42), 0x1);

		L16f1:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x42)), 0x0);
			if (this.oCPU.Flags.NE) goto L16fa;
			goto L178c;

		L16fa:
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x16ff); // stack management - push return offset
			// Instruction address 0x1ade:0x16fa, size: 5
			this.oParent.Segment_11a8.F0_11a8_0268();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.AX.Word = 0x22bf; // Segment
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord((ushort)(this.oCPU.BP.Word - 0x10));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x170c); // stack management - push return offset
			// Instruction address 0x1ade:0x1707, size: 5
			this.oParent.MSCAPI.strcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12), 0x0);
			this.oCPU.AX.Word = 0x36;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1720); // stack management - push return offset
			// Instruction address 0x1ade:0x171d, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L1730;
			this.oCPU.WriteByte(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x9), 0x32);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12), 0x1);

		L1730:
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x173d); // stack management - push return offset
			// Instruction address 0x1ade:0x1738, size: 5
			this.oParent.Segment_2fa1.F0_2fa1_01a2_LoadBitmapOrPalette(1, 0, 0, (ushort)(this.oCPU.BP.Word - 0x10), 0);
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			//this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);

			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xc8;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x140;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0xaa));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1758); // stack management - push return offset
			// Instruction address 0x1ade:0x1753, size: 5
			this.oParent.Segment_1000.F0_1000_0bfa_FillRectangle();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0xc);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1760); // stack management - push return offset
			// Instruction address 0x1ade:0x175b, size: 5
			this.oParent.Segment_2dc4.F0_2dc4_065f();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment

			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1769); // stack management - push return offset
			// Instruction address 0x1ade:0x1764, size: 5
			this.oParent.Segment_2fa1.F0_2fa1_01a2_LoadBitmapOrPalette(-1, 0, 0, (ushort)(this.oCPU.BP.Word - 0x10), 1);
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			//this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x2);

			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0xaa));
			this.oCPU.AX.Word = 0xc8;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x140;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x19d4));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1789); // stack management - push return offset
			// Instruction address 0x1ade:0x1784, size: 5
			this.oParent.VGADriver.F0_VGA_07d8();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x10);

		L178c:
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x1982)));
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x179e); // stack management - push return offset
			// Instruction address 0x1ade:0x1799, size: 5
			this.oParent.MSCAPI.strcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x14;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x17ad); // stack management - push return offset
			// Instruction address 0x1ade:0x17aa, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L17b9;
			this.oCPU.AX.Word = 0x22cc;
			goto L17bc;

		L17b9:
			this.oCPU.AX.Word = 0x22d8;

		L17bc:
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x17c6); // stack management - push return offset
			// Instruction address 0x1ade:0x17c1, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x22e2; // Segment
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x17d6); // stack management - push return offset
			// Instruction address 0x1ade:0x17d1, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x16;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.DS.Word, 0x19be));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0x4da);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x17ed); // stack management - push return offset
			// Instruction address 0x1ade:0x17e8, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x19be), 0x47);
			if (this.oCPU.Flags.NE) goto L182c;
			this.oCPU.AX.Word = 0x22fb;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06; // Segment
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1804); // stack management - push return offset
			// Instruction address 0x1ade:0x17ff, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0xa;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xd80a;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xb23a, this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb23a)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb23a));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x181c); // stack management - push return offset
			// Instruction address 0x1ade:0x1817, size: 5
			this.oParent.MSCAPI.itoa();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1829); // stack management - push return offset
			// Instruction address 0x1ade:0x1824, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);

		L182c:
			this.oCPU.AX.Word = 0x22fd;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1839); // stack management - push return offset
			// Instruction address 0x1ade:0x1834, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.AX.Word = 0x3a;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x280c)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x1518)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1853); // stack management - push return offset
			// Instruction address 0x1ade:0x184e, size: 5
			this.oParent.Segment_11a8.F0_11a8_046c();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x2);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x42)), 0x0);
			if (this.oCPU.Flags.NE) goto L185f;
			goto L19a5;

		L185f:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12)), 0x0);
			if (this.oCPU.Flags.NE) goto L186e;
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xaa);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x10), 0x6);

		L186e:
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xdb38, 0x1);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12)), 0x0);
			if (this.oCPU.Flags.E) goto L187f;
			this.oCPU.AX.Word = 0x19;
			goto L1882;

		L187f:
			this.oCPU.AX.Word = 0x1;

		L1882:
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x60;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1890); // stack management - push return offset
			// Instruction address 0x1ade:0x188b, size: 5
			this.oParent.Segment_1238.F0_1238_0008();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xaa);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x10), 0x1);
			this.oCPU.AX.Word = 0x2300;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x18a9); // stack management - push return offset
			// Instruction address 0x1ade:0x18a4, size: 5
			this.oParent.MSCAPI.strcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x44));
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.CX.Word = 0x9; // Segment
			this.oCPU.IDIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0xba0c, this.oCPU.ADDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, 0xba0c), this.oCPU.AX.Low));
			this.oCPU.AX.Word = 0x1;
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.PushWord(this.oCPU.DX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x3;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x18c8); // stack management - push return offset
			// Instruction address 0x1ade:0x18c3, size: 5
			this.oParent.Segment_11a8.F0_11a8_02a4();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);

			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x1;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x18d8); // stack management - push return offset
			// Instruction address 0x1ade:0x18d3, size: 5
			this.oParent.Segment_2fa1.F0_2fa1_01a2_LoadBitmapOrPalette(1, 0, 0, 0xba06, 0);
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			//this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);

			this.oCPU.AX.Word = 0x1;
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.PushWord(this.oCPU.DX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x18e9); // stack management - push return offset
			// Instruction address 0x1ade:0x18e4, size: 5
			this.oParent.Segment_11a8.F0_11a8_02a4();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12)), 0x0);
			if (this.oCPU.Flags.E) goto L18f7;
			this.oCPU.AX.Word = 0x57;
			goto L18fa;

		L18f7:
			this.oCPU.AX.Word = 0x60;

		L18fa:
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xae;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x44;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x6e;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x44));
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.CX.Word = 0x9;
			this.oCPU.IDIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			this.oCPU.AX.Word = this.oCPU.DX.Word;
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.CX.Word = 0x3;
			this.oCPU.IDIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			this.oCPU.CX.Word = 0x45;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			this.oCPU.AX.Word = this.oCPU.INCWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x44));
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.CX.Word = 0x3;
			this.oCPU.IDIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			this.oCPU.AX.Word = this.oCPU.DX.Word;
			this.oCPU.CX.Word = 0x6f;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			this.oCPU.AX.Word = this.oCPU.INCWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			// Call to overlay
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1936); // stack management - push return offset
			this.oParent.Overlay_8.F8_0000_16f7();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0xc);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd762), 0x0);
			if (this.oCPU.Flags.E) goto L1994;
			this.oCPU.AX.Word = 0x230c;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord((ushort)(this.oCPU.BP.Word - 0x8));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x194d); // stack management - push return offset
			// Instruction address 0x1ade:0x1948, size: 5
			this.oParent.MSCAPI.strcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);

			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x195d); // stack management - push return offset
			// Instruction address 0x1ade:0x1958, size: 5
			this.oParent.Segment_2fa1.F0_2fa1_01a2_LoadBitmapOrPalette(-1, 0, 0, (ushort)(this.oCPU.BP.Word - 0x10), 0xc1d6);
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			//this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);

			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x196d); // stack management - push return offset
			// Instruction address 0x1ade:0x1968, size: 5
			this.oParent.Segment_2fa1.F0_2fa1_01a2_LoadBitmapOrPalette(-1, 0, 0, 0x2311, 0xc5be);
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			//this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);

			this.oCPU.AX.Word = 0xff;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xc1dc;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xc5c4;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1981); // stack management - push return offset
			// Instruction address 0x1ade:0x197c, size: 5
			this.oParent.MSCAPI.memcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.AX.Word = 0xc5be;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x1e;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1991); // stack management - push return offset
			// Instruction address 0x1ade:0x198c, size: 5
			this.oParent.Segment_1000.F0_1000_04aa();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);

		L1994:
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1999); // stack management - push return offset
			// Instruction address 0x1ade:0x1994, size: 5
			this.oParent.Segment_2459.F0_2459_0918();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x199e); // stack management - push return offset
			// Instruction address 0x1ade:0x1999, size: 5
			this.oParent.Segment_11a8.F0_11a8_0250();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x19a3); // stack management - push return offset
			// Instruction address 0x1ade:0x199e, size: 5
			this.oParent.Segment_2dc4.F0_2dc4_0626();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			goto L19b1;

		L19a5:
			this.oCPU.AX.Word = 0xffff;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			// Call to overlay
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x19ae); // stack management - push return offset
			this.oParent.Overlay_21.F21_0000_0000();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x2);

		L19b1:
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x19be));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x19bf); // stack management - push return offset
			// Instruction address 0x1ade:0x19bc, size: 3
			F0_1ade_1d2e();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.AX.Word = 0x1;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x19cb); // stack management - push return offset
			// Instruction address 0x1ade:0x19c6, size: 5
			this.oParent.Segment_11a8.F0_11a8_046c();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x2);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x19be, 0xffff);

		L19d4:
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x1768)), 0x1);
			if (this.oCPU.Flags.G) goto L19ec;
			this.oCPU.AX.Word = 0x231d;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			// Call to overlay
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x19e9); // stack management - push return offset
			this.oParent.Overlay_4.F4_0000_02d3();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x2);

		L19ec:
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x19f1); // stack management - push return offset
			// Instruction address 0x1ade:0x19ec, size: 5
			this.oParent.Segment_11a8.F0_11a8_0268();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x19f6); // stack management - push return offset
			// Instruction address 0x1ade:0x19f1, size: 5
			this.oParent.Segment_1866.F0_1866_25b6();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x19fb); // stack management - push return offset
			// Instruction address 0x1ade:0x19f6, size: 5
			this.oParent.Segment_11a8.F0_11a8_0250();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, 0x19c0), 0x1);
			if (this.oCPU.Flags.NE) goto L1a05;
			goto L1b3d;

		L1a05:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x14)), 0xffff);
			if (this.oCPU.Flags.NE) goto L1a0e;
			goto L1b3d;

		L1a0e:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6b86), 0x0);
			if (this.oCPU.Flags.E) goto L1a18;
			goto L1b3d;

		L1a18:
			this.oCPU.AX.Word = 0x2327;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1a25); // stack management - push return offset
			// Instruction address 0x1ade:0x1a20, size: 5
			this.oParent.MSCAPI.strcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x16;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x14)));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0x4da);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1a3b); // stack management - push return offset
			// Instruction address 0x1ade:0x1a36, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x2350;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1a4b); // stack management - push return offset
			// Instruction address 0x1ade:0x1a46, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1a57); // stack management - push return offset
			// Instruction address 0x1ade:0x1a52, size: 5
			this.oParent.MSCAPI.strlen();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x2);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x40), this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12), 0x0);
			this.oCPU.AX.Word = 0x2353;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1a6f); // stack management - push return offset
			// Instruction address 0x1ade:0x1a6a, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x18), 0x0);

		L1a77:
			this.oCPU.AX.Word = 0x22;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x18)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x14));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x114a)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L1aad;
			this.oCPU.AX.Word = this.oCPU.SI.Word;
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0x112a);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1a97); // stack management - push return offset
			// Instruction address 0x1ade:0x1a92, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x2366;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06; // Segment
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1aa7); // stack management - push return offset
			// Instruction address 0x1ade:0x1aa2, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12))));

		L1aad:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x18), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x18))));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x18)), 0x1c);
			if (this.oCPU.Flags.L) goto L1a77;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x18), 0x0);

		L1abb:
			this.oCPU.AX.Word = 0x1e;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x18)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x14));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0xbb6)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L1af1;
			this.oCPU.AX.Word = this.oCPU.SI.Word;
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0xb9a);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1adb); // stack management - push return offset
			// Instruction address 0x1ade:0x1ad6, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x2369;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1aeb); // stack management - push return offset
			// Instruction address 0x1ade:0x1ae6, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12))));

		L1af1:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x18), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x18))));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x18)), 0x18);
			if (this.oCPU.Flags.L) goto L1abb;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12)), 0x0);
			if (this.oCPU.Flags.NE) goto L1b08;
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x40));
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x45fa), 0x0);

		L1b08:
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xaa);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x10), 0x2);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xdb38, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12));
			this.oCPU.CX.Low = 0x3;
			this.oCPU.AX.Word = this.oCPU.SHLWord(this.oCPU.AX.Word, this.oCPU.CX.Low);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, 0xa8);
			this.oCPU.AX.Word = this.oCPU.NEGWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x8;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1b31); // stack management - push return offset
			// Instruction address 0x1ade:0x1b2c, size: 5
			this.oParent.Segment_1238.F0_1238_0008();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xaa);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x10), 0x1);

		L1b3d:
			this.oCPU.AX.Word = 0x236c;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06; // Segment
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1b4a); // stack management - push return offset
			// Instruction address 0x1ade:0x1b45, size: 5
			this.oParent.MSCAPI.strcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x14;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1b59); // stack management - push return offset
			// Instruction address 0x1ade:0x1b56, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L1b65;
			this.oCPU.AX.Word = 0x2388; // Segment
			goto L1b68;

		L1b65:
			this.oCPU.AX.Word = 0x2393;

		L1b68:
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1b72); // stack management - push return offset
			// Instruction address 0x1ade:0x1b6d, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x239c;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1b82); // stack management - push return offset
			// Instruction address 0x1ade:0x1b7d, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12), 0x0);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46), 0x0);

		L1b8f:
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1b99); // stack management - push return offset
			// Instruction address 0x1ade:0x1b96, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L1ba3;
			goto L1c46;

		L1ba3:
			this.oCPU.AX.Word = 0x16;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x4ee));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1bb8); // stack management - push return offset
			// Instruction address 0x1ade:0x1bb5, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L1bc2;
			goto L1c46;

		L1bc2:
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x4ef));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1bcf); // stack management - push return offset
			// Instruction address 0x1ade:0x1bcc, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L1c46;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x16)), 0x0);
			if (this.oCPU.Flags.NE) goto L1bff;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12)), 0x1);
			if (this.oCPU.Flags.LE) goto L1c12;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46));
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x1768)));
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.CX.Word = 0x3;
			this.oCPU.IDIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			this.oCPU.DX.Word = this.oCPU.ORWord(this.oCPU.DX.Word, this.oCPU.DX.Word);
			if (this.oCPU.Flags.NE) goto L1c12;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6b86), 0x0);
			if (this.oCPU.Flags.E) goto L1c12;

		L1bff:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x16)), 0x0);
			if (this.oCPU.Flags.E) goto L1c46;
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + this.oCPU.SI.Word - 0x3a)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L1c46;

		L1c12:
			this.oCPU.AX.Word = 0x16;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0x4da);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1c25); // stack management - push return offset
			// Instruction address 0x1ade:0x1c20, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x23be;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1c35); // stack management - push return offset
			// Instruction address 0x1ade:0x1c30, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12))));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + this.oCPU.SI.Word - 0x3a), this.oCPU.AX.Word);

		L1c46:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46))));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)), 0x48);
			if (this.oCPU.Flags.GE) goto L1c52;
			goto L1b8f;

		L1c52:
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x2f9e, 0x6);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x12)), 0x0);
			if (this.oCPU.Flags.E) goto L1cca;
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x2fa0, 0x1);
			this.oCPU.AX.Word = 0x40;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x50;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1c75); // stack management - push return offset
			// Instruction address 0x1ade:0x1c70, size: 5
			this.oParent.Segment_1238.F0_1238_0008();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46), this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1c80); // stack management - push return offset
			// Instruction address 0x1ade:0x1c7b, size: 5
			this.oParent.Segment_11a8.F0_11a8_0268();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1c85); // stack management - push return offset
			// Instruction address 0x1ade:0x1c80, size: 5
			this.oParent.Segment_1866.F0_1866_25d7();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1c8a); // stack management - push return offset
			// Instruction address 0x1ade:0x1c85, size: 5
			this.oParent.Segment_11a8.F0_11a8_0250();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)), 0xffff);
			if (this.oCPU.Flags.NE) goto L1c95;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46), 0x0);

		L1c95:
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + this.oCPU.SI.Word - 0x3a));
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46), this.oCPU.AX.Word);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x2f9c), 0x0);
			if (this.oCPU.Flags.E) goto L1cc2;
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46)));
			// Call to overlay
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1cb2); // stack management - push return offset
			this.oParent.Overlay_8.F8_0000_062a();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1cba); // stack management - push return offset
			// Instruction address 0x1ade:0x1cb5, size: 5
			this.oParent.Segment_1238.F0_1238_1b44();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x16), 0x1);
			goto L1638;

		L1cc2:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46));
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x19be, this.oCPU.AX.Word);
			goto L1d26;

		L1cca:
			this.oCPU.AX.Word = 0x23c1;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1cd7); // stack management - push return offset
			// Instruction address 0x1ade:0x1cd2, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0xa;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xd80a;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xb23a);
			this.oCPU.AX.Word = this.oCPU.INCWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1cec); // stack management - push return offset
			// Instruction address 0x1ade:0x1ce7, size: 5
			this.oParent.MSCAPI.itoa();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1cf9); // stack management - push return offset
			// Instruction address 0x1ade:0x1cf4, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x23d5; // Segment
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1d09); // stack management - push return offset
			// Instruction address 0x1ade:0x1d04, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x50;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x64;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1d1d); // stack management - push return offset
			// Instruction address 0x1ade:0x1d18, size: 5
			this.oParent.Segment_1238.F0_1238_001e();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x19be, 0x47);

		L1d26:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x46));

		L1d29:
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.SP.Word = this.oCPU.BP.Word;
			this.oCPU.BP.Word = this.oCPU.PopWord();
			// Far return
			this.oCPU.Log.ExitBlock("'F0_1ade_1584'");
		}

		public void F0_1ade_1d2e()
		{
			this.oCPU.Log.EnterBlock("'F0_1ade_1d2e'(Cdecl, Far) at 0x1ade:0x1d2e");
			this.oCPU.CS.Word = 0x1ade; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.SP.Word = this.oCPU.SUBWord(this.oCPU.SP.Word, 0x8);
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1d40); // stack management - push return offset
			// Instruction address 0x1ade:0x1d3d, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L1d4a;
			goto L22af;

		L1d4a:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)), 0x47);
			if (this.oCPU.Flags.E) goto L1d9e;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.CX.Word = 0x10;
			this.oCPU.IDIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			this.oCPU.CX.Word = this.oCPU.DX.Word;
			this.oCPU.AX.Word = 0x1;
			this.oCPU.AX.Word = this.oCPU.SHLWord(this.oCPU.AX.Word, this.oCPU.CX.Low);
			this.oCPU.CX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = 0xa; // Segment
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.SI.Word = this.oCPU.CX.Word;
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.AX.Word = this.oCPU.XORWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.CX.Word = 0x4;
			this.oCPU.AX.Word = this.oCPU.SARWord(this.oCPU.AX.Word, this.oCPU.CX.Low);
			this.oCPU.AX.Word = this.oCPU.XORWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.DI.Word = this.oCPU.AX.Word;
			this.oCPU.DI.Word = this.oCPU.SHLWord(this.oCPU.DI.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.DI.Word - 0x1c38), this.oCPU.ORWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.DI.Word - 0x1c38)), this.oCPU.SI.Word));
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xa));
			this.oCPU.CX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = 0x48;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.BX.Word = this.oCPU.ADDWord(this.oCPU.BX.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.ES.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x63f0);
			this.oCPU.WriteByte(this.oCPU.ES.Word, (ushort)(this.oCPU.BX.Word + 0x1d48), this.oCPU.CX.Low);

		L1d9e:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x81d2), 0x0);
			if (this.oCPU.Flags.NE) goto L1da8;
			goto L22af;

		L1da8:
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x1768), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word - 0x1768))));
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L1dce;
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.CX.Low = 0x4;
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, this.oCPU.CX.Low);
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word - 0x1b68)), 0x40);
			if (this.oCPU.Flags.NE) goto L1dce;
			goto L1f47;

		L1dce:
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0xba06, 0x0);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x1992)));
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1de5); // stack management - push return offset
			// Instruction address 0x1ade:0x1de0, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xa));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L1df4;
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L1df9;

		L1df4:
			this.oCPU.AX.Word = 0x23d7;
			goto L1dfc;

		L1df9:
			this.oCPU.AX.Word = 0x23e1;

		L1dfc:
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1e06); // stack management - push return offset
			// Instruction address 0x1ade:0x1e01, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x16;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0x4da);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1e1c); // stack management - push return offset
			// Instruction address 0x1ade:0x1e17, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xa));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L1e5c;
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L1e5c;
			this.oCPU.AX.Word = 0x23eb;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1e38); // stack management - push return offset
			// Instruction address 0x1ade:0x1e33, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xa)), 0xfffe);
			if (this.oCPU.Flags.NE) goto L1e47;
			this.oCPU.AX.Word = 0x23f6;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			goto L1e50;

		L1e47:
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xa));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x1992)));

		L1e50:
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1e59); // stack management - push return offset
			// Instruction address 0x1ade:0x1e54, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);

		L1e5c:
			this.oCPU.AX.Word = 0x2404;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1e69); // stack management - push return offset
			// Instruction address 0x1ade:0x1e64, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L1e77;
			goto L1ef9;

		L1e77:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2), 0x0);

		L1e7c:
			this.oCPU.AX.Word = 0x1e; // Segment
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0xbb6)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L1eaf;
			this.oCPU.AX.Word = this.oCPU.SI.Word;
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0xb9a);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1e9c); // stack management - push return offset
			// Instruction address 0x1ade:0x1e97, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x2408;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1eac); // stack management - push return offset
			// Instruction address 0x1ade:0x1ea7, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);

		L1eaf:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2))));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2)), 0x18);
			if (this.oCPU.Flags.L) goto L1e7c;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2), 0x0);

		L1ebd:
			this.oCPU.AX.Word = 0x22; // Segment
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x114a)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L1ef0;
			this.oCPU.AX.Word = this.oCPU.SI.Word;
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0x112a);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1edd); // stack management - push return offset
			// Instruction address 0x1ade:0x1ed8, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x240b;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1eed); // stack management - push return offset
			// Instruction address 0x1ade:0x1ee8, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);

		L1ef0:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2))));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2)), 0x1c);
			if (this.oCPU.Flags.L) goto L1ebd;

		L1ef9:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L1f0a;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0xa)), 0xfffe);
			if (this.oCPU.Flags.E) goto L1f0a;
			goto L2013;

		L1f0a:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x3934), 0xffff);
			if (this.oCPU.Flags.E) goto L1f14;
			goto L2013;

		L1f14:
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xd206, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L1f2a;
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x2f9e, 0x0);
			goto L1f30;

		L1f2a:
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x2f9e, 0x6);

		L1f30:
			this.oCPU.AX.Word = 0x50;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x64;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06; // Segment
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1f41); // stack management - push return offset
			// Instruction address 0x1ade:0x1f3c, size: 5
			this.oParent.Segment_1238.F0_1238_001e();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			goto L2013;

		L1f47:
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.ES.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x63ee);
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.ES.Word, (ushort)(this.oCPU.BX.Word + 0x4b0)), 0x7);
			if (this.oCPU.Flags.E) goto L1f5b;
			goto L2013;

		L1f5b:
			this.oCPU.AX.Word = 0x8;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1f66); // stack management - push return offset
			// Instruction address 0x1ade:0x1f63, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L1f70;
			goto L2013;

		L1f70:
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1f7b); // stack management - push return offset
			// Instruction address 0x1ade:0x1f78, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L1f85;
			goto L2013;

		L1f85:
			// Instruction address 0x1ade:0x1f89, size: 5
			this.oParent.Segment_2dc4.F0_2dc4_005d_GetRandomNumber(3);

			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L2013;
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xffff;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			// Call to overlay
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1fa4); // stack management - push return offset
			this.oParent.Overlay_6.F6_0000_16cd();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			this.oCPU.AX.Word = this.oCPU.INCWord(this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L2013;
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x3934, this.oCPU.AX.Word);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xd804, this.oCPU.AX.Word);
			this.oCPU.WriteByte(this.oCPU.DS.Word, 0xba06, 0x0);
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x1992)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x30b8));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1fc9); // stack management - push return offset
			// Instruction address 0x1ade:0x1fc4, size: 5
			this.oParent.MSCAPI.strcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x16;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0x4da);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x30be));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1fdf); // stack management - push return offset
			// Instruction address 0x1ade:0x1fda, size: 5
			this.oParent.MSCAPI.strcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x240e;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x1feb); // stack management - push return offset
			// Instruction address 0x1ade:0x1fe6, size: 5
			this.oParent.Segment_2f4d.F0_2f4d_044f();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x2);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x3936, 0x2);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0xd76c, 0xc);
			this.oCPU.AX.Word = 0x8b;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x14;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			// Call to overlay
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x200b); // stack management - push return offset
			this.oParent.Overlay_6.F6_0000_251d();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			// Call to overlay
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x2013); // stack management - push return offset
			this.oParent.Overlay_6.F6_0000_16ac();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment

		L2013:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L2065;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)), 0x47);
			if (this.oCPU.Flags.E) goto L202f;
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			// Call to overlay
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x202c); // stack management - push return offset
			this.oParent.Overlay_8.F8_0000_062a();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);

		L202f:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)), 0x14);
			if (this.oCPU.Flags.NE) goto L203f;
			// Call to overlay
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x203a); // stack management - push return offset
			this.oParent.Overlay_5.F5_0000_1af6();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x203f); // stack management - push return offset
			// Instruction address 0x1ade:0x203a, size: 5
			this.oParent.Segment_1238.F0_1238_1b44();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment

		L203f:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x3934), 0xffff);
			if (this.oCPU.Flags.E) goto L2049;
			goto L20d9;

		L2049:
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x204e); // stack management - push return offset
			// Instruction address 0x1ade:0x2049, size: 5
			this.oParent.Segment_1238.F0_1238_1b44();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)), 0x5);
			if (this.oCPU.Flags.E) goto L2057;
			goto L20d9;

		L2057:
			this.oCPU.AX.Word = 0x2414;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			// Call to overlay
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x2060); // stack management - push return offset
			this.oParent.Overlay_4.F4_0000_02d3();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x2);
			goto L20d9;

		L2065:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6b86), 0x0);
			if (this.oCPU.Flags.NE) goto L20d9;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)), 0x16);
			if (this.oCPU.Flags.NE) goto L20d9;
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.DI.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee);
			this.oCPU.CX.Low = 0x4;
			this.oCPU.DI.Word = this.oCPU.SHLWord(this.oCPU.DI.Word, this.oCPU.CX.Low);
			this.oCPU.DI.Word = this.oCPU.ADDWord(this.oCPU.DI.Word, this.oCPU.SI.Word);
			this.oCPU.DI.Word = this.oCPU.ADDWord(this.oCPU.DI.Word, 0xe498);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, this.oCPU.DI.Word), 0x1);
			this.oCPU.AX.Word = this.oCPU.SBBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.NEGWord(this.oCPU.AX.Word);
			this.oCPU.TESTByte(this.oCPU.AX.Low, 0x40);
			if (this.oCPU.Flags.E) goto L20d9;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x3934), 0xffff);
			if (this.oCPU.Flags.NE) goto L20d9;
			this.oCPU.WriteByte(this.oCPU.DS.Word, this.oCPU.DI.Word, this.oCPU.ORByte(this.oCPU.ReadByte(this.oCPU.DS.Word, this.oCPU.DI.Word), 0x40));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x1992)));
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x20a7); // stack management - push return offset
			// Instruction address 0x1ade:0x20a2, size: 5
			this.oParent.MSCAPI.strcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x241e; // Segment
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x20b7); // stack management - push return offset
			// Instruction address 0x1ade:0x20b2, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x2f9e, 0x1); // Segment
			this.oCPU.AX.Word = 0x64;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x50;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x20d1); // stack management - push return offset
			// Instruction address 0x1ade:0x20cc, size: 5
			this.oParent.Segment_1238.F0_1238_001e();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);
			// Call to overlay
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x20d9); // stack management - push return offset
			this.oParent.Overlay_14.F14_0000_0d43();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment

		L20d9:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)), 0x22);
			if (this.oCPU.Flags.E) goto L20e8;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)), 0x25);
			if (this.oCPU.Flags.E) goto L20e8;
			goto L2174;

		L20e8:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6), 0x0);

		L20ed:
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.CMPByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f2)), 0xff);
			if (this.oCPU.Flags.E) goto L210b;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70f7));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.CMPWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			if (this.oCPU.Flags.NE) goto L210b;
			this.oCPU.WriteByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70ec), this.oCPU.ANDByte(this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x70ec)), 0xfd));

		L210b:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6))));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6)), 0x80);
			if (this.oCPU.Flags.L) goto L20ed;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L2174;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, 0x3934), 0xffff);
			if (this.oCPU.Flags.NE) goto L2174;
			this.oCPU.AX.Word = 0x2445;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x2131); // stack management - push return offset
			// Instruction address 0x1ade:0x212c, size: 5
			this.oParent.MSCAPI.strcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x16;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0x4da);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x2147); // stack management - push return offset
			// Instruction address 0x1ade:0x2142, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x2455;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x2157); // stack management - push return offset
			// Instruction address 0x1ade:0x2152, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.WriteWord(this.oCPU.DS.Word, 0x2f9e, 0x3);
			this.oCPU.AX.Word = 0x64;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x50;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x2171); // stack management - push return offset
			// Instruction address 0x1ade:0x216c, size: 5
			this.oParent.Segment_1238.F0_1238_001e();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);

		L2174:
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.ES.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x63ee);
			this.oCPU.TESTByte(this.oCPU.ReadByte(this.oCPU.ES.Word, (ushort)(this.oCPU.BX.Word + 0x4b0)), 0x7);
			if (this.oCPU.Flags.E) goto L2188;
			goto L2234;

		L2188:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.WriteWord(this.oCPU.ES.Word, (ushort)(this.oCPU.BX.Word + 0x4b0), this.oCPU.ORWord(this.oCPU.ReadWord(this.oCPU.ES.Word, (ushort)(this.oCPU.BX.Word + 0x4b0)), this.oCPU.AX.Word));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x2;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0x5;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x21a6); // stack management - push return offset
			// Instruction address 0x1ade:0x21a1, size: 5
			this.oParent.Segment_1866.F0_1866_250e();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x8);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6), 0x1);

		L21ae:
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x10fe)), this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L2228;
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0x6ea8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f7));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.CMPWord(this.oCPU.AX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, 0xd7ee));
			if (this.oCPU.Flags.NE) goto L2228;
			this.oCPU.AX.Word = 0x16;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0x4da);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x21e3); // stack management - push return offset
			// Instruction address 0x1ade:0x21de, size: 5
			this.oParent.MSCAPI.strcpy();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x2479;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x21f3); // stack management - push return offset
			// Instruction address 0x1ade:0x21ee, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x1e;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6)));
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, 0xe6a);
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x2209); // stack management - push return offset
			// Instruction address 0x1ade:0x2204, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0x2491;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.AX.Word = 0xba06;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x2219); // stack management - push return offset
			// Instruction address 0x1ade:0x2214, size: 5
			this.oParent.MSCAPI.strcat();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = 0xffff;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			// Call to overlay
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x2225); // stack management - push return offset
			this.oParent.Overlay_21.F21_0000_0000();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x2);

		L2228:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6))));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6)), 0x15);
			if (this.oCPU.Flags.G) goto L2234;
			goto L21ae;

		L2234:
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, 0x6eb2);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8), this.oCPU.AX.Word);
			this.oCPU.CMPWord(this.oCPU.AX.Word, 0xffff);
			if (this.oCPU.Flags.E) goto L22af;
			this.oCPU.AX.Word = 0x1c;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8)));
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + 0x70f7));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8), this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x2257); // stack management - push return offset
			// Instruction address 0x1ade:0x2254, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.NE) goto L22af;
			this.oCPU.AX.Word = 0x5;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x226a); // stack management - push return offset
			// Instruction address 0x1ade:0x2265, size: 5
			this.oParent.Segment_1d12.F0_1d12_6c97();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L22af;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4), 0x0);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6), 0x1);

		L227b:
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x2285); // stack management - push return offset
			// Instruction address 0x1ade:0x2282, size: 3
			F0_1ade_22b5();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x4);
			this.oCPU.AX.Word = this.oCPU.ORWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			if (this.oCPU.Flags.E) goto L228f;
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4))));

		L228f:
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6), this.oCPU.INCWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6))));
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x6)), 0x8);
			if (this.oCPU.Flags.L) goto L227b;
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x4)), 0x2);
			if (this.oCPU.Flags.L) goto L22af;
			this.oCPU.AX.Word = 0xfffe;
			this.oCPU.PushWord(this.oCPU.AX.Word);
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)));
			this.oCPU.PushWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x8)));
			this.oCPU.PushWord(this.oCPU.CS.Word); // stack management - push return segment
			this.oCPU.PushWord(0x22ac); // stack management - push return offset
			// Instruction address 0x1ade:0x22a9, size: 3
			F0_1ade_1d2e();
			this.oCPU.PopDWord(); // stack management - pop return offset and segment
			this.oCPU.CS.Word = 0x1ade; // restore this function segment
			this.oCPU.SP.Word = this.oCPU.ADDWord(this.oCPU.SP.Word, 0x6);

		L22af:
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.SP.Word = this.oCPU.BP.Word;
			this.oCPU.BP.Word = this.oCPU.PopWord();
			// Far return
			this.oCPU.Log.ExitBlock("'F0_1ade_1d2e'");
		}

		public void F0_1ade_22b5()
		{
			this.oCPU.Log.EnterBlock("'F0_1ade_22b5'(Cdecl, Far) at 0x1ade:0x22b5");
			this.oCPU.CS.Word = 0x1ade; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.SP.Word = this.oCPU.SUBWord(this.oCPU.SP.Word, 0x2);
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)), 0xffff);
			if (this.oCPU.Flags.NE) goto L22c7;

		L22c2:
			this.oCPU.AX.Word = 0x1;
			goto L2312;

		L22c7:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8)), 0x47);
			if (this.oCPU.Flags.L) goto L22d1;

		L22cd:
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.AX.Word);
			goto L2312;

		L22d1:
			this.oCPU.CMPWord(this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)), 0x0);
			if (this.oCPU.Flags.E) goto L22cd;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.AX.Word = this.oCPU.XORWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.CX.Word = 0x4;
			this.oCPU.AX.Word = this.oCPU.SARWord(this.oCPU.AX.Word, this.oCPU.CX.Low);
			this.oCPU.AX.Word = this.oCPU.XORWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.AX.Word = this.oCPU.SUBWord(this.oCPU.AX.Word, this.oCPU.DX.Word);
			this.oCPU.WriteWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2), this.oCPU.AX.Word);
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.CWD(this.oCPU.AX, this.oCPU.DX);
			this.oCPU.CX.Word = 0x10;
			this.oCPU.IDIVWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.CX.Word);
			this.oCPU.CX.Word = this.oCPU.DX.Word;
			this.oCPU.AX.Word = 0x1;
			this.oCPU.AX.Word = this.oCPU.SHLWord(this.oCPU.AX.Word, this.oCPU.CX.Low);
			this.oCPU.CX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = 0xa;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6)));
			this.oCPU.SI.Word = this.oCPU.AX.Word;
			this.oCPU.BX.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word - 0x2));
			this.oCPU.BX.Word = this.oCPU.SHLWord(this.oCPU.BX.Word, 0x1);
			this.oCPU.TESTWord(this.oCPU.CX.Word, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.BX.Word + this.oCPU.SI.Word - 0x1c38)));
			if (this.oCPU.Flags.E) goto L22cd;
			goto L22c2;

		L2312:
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.SP.Word = this.oCPU.BP.Word;
			this.oCPU.BP.Word = this.oCPU.PopWord();
			// Far return
			this.oCPU.Log.ExitBlock("'F0_1ade_22b5'");
		}

		public void F0_1ade_2317()
		{
			this.oCPU.Log.EnterBlock("'F0_1ade_2317'(Cdecl, Far) at 0x1ade:0x2317");
			this.oCPU.CS.Word = 0x1ade; // set this function segment

			// function body
			this.oCPU.PushWord(this.oCPU.BP.Word);
			this.oCPU.BP.Word = this.oCPU.SP.Word;
			this.oCPU.PushWord(this.oCPU.DI.Word);
			this.oCPU.PushWord(this.oCPU.SI.Word);
			this.oCPU.SI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x8));
			this.oCPU.SI.Word = this.oCPU.SHLWord(this.oCPU.SI.Word, 0x1);
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0xb0a));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.CX.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Low = this.oCPU.ReadByte(this.oCPU.DS.Word, (ushort)(this.oCPU.SI.Word + 0xb0b));
			this.oCPU.CBW(this.oCPU.AX);
			this.oCPU.BX.Word = this.oCPU.AX.Word;
			this.oCPU.DI.Word = this.oCPU.ReadWord(this.oCPU.SS.Word, (ushort)(this.oCPU.BP.Word + 0x6));
			this.oCPU.DI.Word = this.oCPU.SHLWord(this.oCPU.DI.Word, 0x1);
			this.oCPU.AX.Word = 0x3a;
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.DI.Word - 0x280c)));
			this.oCPU.DI.Word = this.oCPU.AX.Word;
			this.oCPU.AX.Word = this.oCPU.ReadWord(this.oCPU.DS.Word, (ushort)(this.oCPU.DI.Word + 0x1516));
			this.oCPU.IMULWord(this.oCPU.AX, this.oCPU.DX, this.oCPU.BX.Word);
			this.oCPU.AX.Word = this.oCPU.ADDWord(this.oCPU.AX.Word, this.oCPU.CX.Word);
			this.oCPU.SI.Word = this.oCPU.PopWord();
			this.oCPU.DI.Word = this.oCPU.PopWord();
			this.oCPU.BP.Word = this.oCPU.PopWord();
			// Far return
			this.oCPU.Log.ExitBlock("'F0_1ade_2317'");
		}
	}
}
