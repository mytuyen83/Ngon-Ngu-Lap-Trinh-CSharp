
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 10:0:0:0
}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 10:0:0:0
}
.assembly ThucHanh1
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 19 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 31 30 2E 30 01 00 54 0E   // ersion=v10.0..T.
                                                                                                              14 46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61   // .FrameworkDispla
                                                                                                              79 4E 61 6D 65 09 2E 4E 45 54 20 31 30 2E 30 )    // yName..NET 10.0
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 09 54 68 75 63 48 61 6E 68 31 00 00 )       // ...ThucHanh1..
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 05 44 65 62 75 67 00 00 )                   // ...Debug..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 2E 31 2E 30 2E 30 2B 36 36 31 36 61 34 65   // ...1.0.0+6616a4e
                                                                                                                   66 65 33 64 39 32 36 65 66 65 37 34 62 65 61 37   // fe3d926efe74bea7
                                                                                                                   30 35 65 62 39 63 61 32 35 35 37 62 66 34 63 62   // 05eb9ca2557bf4cb
                                                                                                                   33 00 00 )                                        // 3..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 09 54 68 75 63 48 61 6E 68 31 00 00 )       // ...ThucHanh1..
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 09 54 68 75 63 48 61 6E 68 31 00 00 )       // ...ThucHanh1..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module ThucHanh1.dll
// MVID: {8D493013-B91B-41CD-A8B0-3898C6207A9C}
.custom instance void [System.Runtime]System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x00000207DC480000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit Lab02.ThucHanh1.HoTen
       extends [System.Runtime]System.Object
{
  .method public hidebysig static void  Bai1() cil managed
  {
    // Code size       36 (0x24)
    .maxstack  2
    .locals init (string V_0)
    IL_0000:  nop
    IL_0001:  ldstr      "Nhap ho ten: "
    IL_0006:  call       void [System.Console]System.Console::Write(string)
    IL_000b:  nop
    IL_000c:  call       string [System.Console]System.Console::ReadLine()
    IL_0011:  stloc.0
    IL_0012:  ldstr      "Ho ten vua nhap: "
    IL_0017:  ldloc.0
    IL_0018:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string)
    IL_001d:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0022:  nop
    IL_0023:  ret
  } // end of method HoTen::Bai1

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method HoTen::.ctor

} // end of class Lab02.ThucHanh1.HoTen

.class private auto ansi beforefieldinit Lab02.ThucHanh1.LoiChao
       extends [System.Runtime]System.Object
{
  .method public hidebysig static void  Bai2() cil managed
  {
    // Code size       41 (0x29)
    .maxstack  3
    .locals init (string V_0)
    IL_0000:  nop
    IL_0001:  ldstr      "Nhap ho ten cua ban: "
    IL_0006:  call       void [System.Console]System.Console::Write(string)
    IL_000b:  nop
    IL_000c:  call       string [System.Console]System.Console::ReadLine()
    IL_0011:  stloc.0
    IL_0012:  ldstr      "Chao ban "
    IL_0017:  ldloc.0
    IL_0018:  ldstr      "!"
    IL_001d:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string,
                                                                      string)
    IL_0022:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0027:  nop
    IL_0028:  ret
  } // end of method LoiChao::Bai2

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method LoiChao::.ctor

} // end of class Lab02.ThucHanh1.LoiChao

.class private auto ansi beforefieldinit Lab02.ThucHanh1.LuyThua
       extends [System.Runtime]System.Object
{
  .method public hidebysig static void  Bai3() cil managed
  {
    // Code size       146 (0x92)
    .maxstack  4
    .locals init (int32 V_0,
             int32 V_1,
             int32 V_2,
             int32 V_3,
             bool V_4)
    IL_0000:  nop
    IL_0001:  ldc.i4.1
    IL_0002:  stloc.2
    IL_0003:  ldstr      "Nhap so nguyen x: "
    IL_0008:  call       void [System.Console]System.Console::Write(string)
    IL_000d:  nop
    IL_000e:  call       string [System.Console]System.Console::ReadLine()
    IL_0013:  call       int32 [System.Runtime]System.Int32::Parse(string)
    IL_0018:  stloc.0
    IL_0019:  ldstr      "Nhap so nguyen y: "
    IL_001e:  call       void [System.Console]System.Console::Write(string)
    IL_0023:  nop
    IL_0024:  call       string [System.Console]System.Console::ReadLine()
    IL_0029:  call       int32 [System.Runtime]System.Int32::Parse(string)
    IL_002e:  stloc.1
    IL_002f:  ldc.i4.1
    IL_0030:  stloc.3
    IL_0031:  br.s       IL_003d

    IL_0033:  nop
    IL_0034:  ldloc.2
    IL_0035:  ldloc.0
    IL_0036:  mul
    IL_0037:  stloc.2
    IL_0038:  nop
    IL_0039:  ldloc.3
    IL_003a:  ldc.i4.1
    IL_003b:  add
    IL_003c:  stloc.3
    IL_003d:  ldloc.3
    IL_003e:  ldloc.1
    IL_003f:  cgt
    IL_0041:  ldc.i4.0
    IL_0042:  ceq
    IL_0044:  stloc.s    V_4
    IL_0046:  ldloc.s    V_4
    IL_0048:  brtrue.s   IL_0033

    IL_004a:  ldc.i4.6
    IL_004b:  newarr     [System.Runtime]System.String
    IL_0050:  dup
    IL_0051:  ldc.i4.0
    IL_0052:  ldstr      "Ket qua "
    IL_0057:  stelem.ref
    IL_0058:  dup
    IL_0059:  ldc.i4.1
    IL_005a:  ldloca.s   V_0
    IL_005c:  call       instance string [System.Runtime]System.Int32::ToString()
    IL_0061:  stelem.ref
    IL_0062:  dup
    IL_0063:  ldc.i4.2
    IL_0064:  ldstr      " mu "
    IL_0069:  stelem.ref
    IL_006a:  dup
    IL_006b:  ldc.i4.3
    IL_006c:  ldloca.s   V_1
    IL_006e:  call       instance string [System.Runtime]System.Int32::ToString()
    IL_0073:  stelem.ref
    IL_0074:  dup
    IL_0075:  ldc.i4.4
    IL_0076:  ldstr      " la: "
    IL_007b:  stelem.ref
    IL_007c:  dup
    IL_007d:  ldc.i4.5
    IL_007e:  ldloca.s   V_2
    IL_0080:  call       instance string [System.Runtime]System.Int32::ToString()
    IL_0085:  stelem.ref
    IL_0086:  call       string [System.Runtime]System.String::Concat(string[])
    IL_008b:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0090:  nop
    IL_0091:  ret
  } // end of method LuyThua::Bai3

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method LuyThua::.ctor

} // end of class Lab02.ThucHanh1.LuyThua

.class private auto ansi beforefieldinit Lab02.ThucHanh1.KTSoNguyen
       extends [System.Runtime]System.Object
{
  .method public hidebysig static void  Bai4() cil managed
  {
    // Code size       205 (0xcd)
    .maxstack  4
    .locals init (int32 V_0,
             int32 V_1,
             int32 V_2,
             string V_3,
             bool V_4,
             bool V_5,
             int32 V_6,
             bool V_7)
    IL_0000:  nop
    IL_0001:  ldc.i4.1
    IL_0002:  stloc.2
    IL_0003:  ldstr      "Nhap so nguyen x: "
    IL_0008:  call       void [System.Console]System.Console::Write(string)
    IL_000d:  nop
    IL_000e:  call       string [System.Console]System.Console::ReadLine()
    IL_0013:  stloc.3
    IL_0014:  ldloc.3
    IL_0015:  ldloca.s   V_0
    IL_0017:  call       bool [System.Runtime]System.Int32::TryParse(string,
                                                                     int32&)
    IL_001c:  ldc.i4.0
    IL_001d:  ceq
    IL_001f:  stloc.s    V_4
    IL_0021:  ldloc.s    V_4
    IL_0023:  brfalse.s  IL_0036

    IL_0025:  nop
    IL_0026:  ldstr      "x khong phai la so nguyen!"
    IL_002b:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0030:  nop
    IL_0031:  br         IL_00cc

    IL_0036:  ldstr      "Nhap so nguyen y: "
    IL_003b:  call       void [System.Console]System.Console::Write(string)
    IL_0040:  nop
    IL_0041:  call       string [System.Console]System.Console::ReadLine()
    IL_0046:  stloc.3
    IL_0047:  ldloc.3
    IL_0048:  ldloca.s   V_1
    IL_004a:  call       bool [System.Runtime]System.Int32::TryParse(string,
                                                                     int32&)
    IL_004f:  ldc.i4.0
    IL_0050:  ceq
    IL_0052:  stloc.s    V_5
    IL_0054:  ldloc.s    V_5
    IL_0056:  brfalse.s  IL_0066

    IL_0058:  nop
    IL_0059:  ldstr      "y khong phai la so nguyen!"
    IL_005e:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0063:  nop
    IL_0064:  br.s       IL_00cc

    IL_0066:  ldc.i4.1
    IL_0067:  stloc.s    V_6
    IL_0069:  br.s       IL_0077

    IL_006b:  nop
    IL_006c:  ldloc.2
    IL_006d:  ldloc.0
    IL_006e:  mul
    IL_006f:  stloc.2
    IL_0070:  nop
    IL_0071:  ldloc.s    V_6
    IL_0073:  ldc.i4.1
    IL_0074:  add
    IL_0075:  stloc.s    V_6
    IL_0077:  ldloc.s    V_6
    IL_0079:  ldloc.1
    IL_007a:  cgt
    IL_007c:  ldc.i4.0
    IL_007d:  ceq
    IL_007f:  stloc.s    V_7
    IL_0081:  ldloc.s    V_7
    IL_0083:  brtrue.s   IL_006b

    IL_0085:  ldc.i4.6
    IL_0086:  newarr     [System.Runtime]System.String
    IL_008b:  dup
    IL_008c:  ldc.i4.0
    IL_008d:  ldstr      "Ket qua "
    IL_0092:  stelem.ref
    IL_0093:  dup
    IL_0094:  ldc.i4.1
    IL_0095:  ldloca.s   V_0
    IL_0097:  call       instance string [System.Runtime]System.Int32::ToString()
    IL_009c:  stelem.ref
    IL_009d:  dup
    IL_009e:  ldc.i4.2
    IL_009f:  ldstr      " mu "
    IL_00a4:  stelem.ref
    IL_00a5:  dup
    IL_00a6:  ldc.i4.3
    IL_00a7:  ldloca.s   V_1
    IL_00a9:  call       instance string [System.Runtime]System.Int32::ToString()
    IL_00ae:  stelem.ref
    IL_00af:  dup
    IL_00b0:  ldc.i4.4
    IL_00b1:  ldstr      " la: "
    IL_00b6:  stelem.ref
    IL_00b7:  dup
    IL_00b8:  ldc.i4.5
    IL_00b9:  ldloca.s   V_2
    IL_00bb:  call       instance string [System.Runtime]System.Int32::ToString()
    IL_00c0:  stelem.ref
    IL_00c1:  call       string [System.Runtime]System.String::Concat(string[])
    IL_00c6:  call       void [System.Console]System.Console::WriteLine(string)
    IL_00cb:  nop
    IL_00cc:  ret
  } // end of method KTSoNguyen::Bai4

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method KTSoNguyen::.ctor

} // end of class Lab02.ThucHanh1.KTSoNguyen

.class private auto ansi beforefieldinit Lab02.ThucHanh1.MenuTinhToan
       extends [System.Runtime]System.Object
{
  .method public hidebysig static void  Bai5() cil managed
  {
    // Code size       479 (0x1df)
    .maxstack  5
    .locals init (float64 V_0,
             float64 V_1,
             int32 V_2,
             int32 V_3,
             int32 V_4,
             int32 V_5,
             bool V_6,
             float64 V_7,
             bool V_8,
             bool V_9,
             bool V_10)
    IL_0000:  nop
    IL_0001:  ldc.r8     0.0
    IL_000a:  stloc.0
    IL_000b:  ldc.r8     0.0
    IL_0014:  stloc.1
    IL_0015:  ldc.i4.0
    IL_0016:  stloc.3
    IL_0017:  nop
    IL_0018:  call       void [System.Console]System.Console::WriteLine()
    IL_001d:  nop
    IL_001e:  ldstr      "MENU"
    IL_0023:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0028:  nop
    IL_0029:  ldstr      "1. Nhap hai gia tri so thuc cho x, y"
    IL_002e:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0033:  nop
    IL_0034:  ldstr      "2. Tinh x^y"
    IL_0039:  call       void [System.Console]System.Console::WriteLine(string)
    IL_003e:  nop
    IL_003f:  ldstr      "3. Tinh can bac 2 cua x va y"
    IL_0044:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0049:  nop
    IL_004a:  ldstr      "4. Thoat"
    IL_004f:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0054:  nop
    IL_0055:  ldstr      "Chon chuc nang: "
    IL_005a:  call       void [System.Console]System.Console::Write(string)
    IL_005f:  nop
    IL_0060:  call       string [System.Console]System.Console::ReadLine()
    IL_0065:  call       int32 [System.Runtime]System.Int32::Parse(string)
    IL_006a:  stloc.2
    IL_006b:  ldloc.2
    IL_006c:  stloc.s    V_5
    IL_006e:  ldloc.s    V_5
    IL_0070:  stloc.s    V_4
    IL_0072:  ldloc.s    V_4
    IL_0074:  ldc.i4.1
    IL_0075:  sub
    IL_0076:  switch     ( 
                          IL_0090,
                          IL_00c3,
                          IL_0133,
                          IL_01be)
    IL_008b:  br         IL_01c0

    IL_0090:  ldstr      "Nhap x: "
    IL_0095:  call       void [System.Console]System.Console::Write(string)
    IL_009a:  nop
    IL_009b:  call       string [System.Console]System.Console::ReadLine()
    IL_00a0:  call       float64 [System.Runtime]System.Double::Parse(string)
    IL_00a5:  stloc.0
    IL_00a6:  ldstr      "Nhap y: "
    IL_00ab:  call       void [System.Console]System.Console::Write(string)
    IL_00b0:  nop
    IL_00b1:  call       string [System.Console]System.Console::ReadLine()
    IL_00b6:  call       float64 [System.Runtime]System.Double::Parse(string)
    IL_00bb:  stloc.1
    IL_00bc:  ldc.i4.1
    IL_00bd:  stloc.3
    IL_00be:  br         IL_01cd

    IL_00c3:  ldloc.3
    IL_00c4:  ldc.i4.0
    IL_00c5:  ceq
    IL_00c7:  stloc.s    V_6
    IL_00c9:  ldloc.s    V_6
    IL_00cb:  brfalse.s  IL_00dc

    IL_00cd:  nop
    IL_00ce:  ldstr      "Chon 1 de nhap x, y truoc!"
    IL_00d3:  call       void [System.Console]System.Console::WriteLine(string)
    IL_00d8:  nop
    IL_00d9:  nop
    IL_00da:  br.s       IL_012e

    IL_00dc:  nop
    IL_00dd:  ldc.i4.6
    IL_00de:  newarr     [System.Runtime]System.String
    IL_00e3:  dup
    IL_00e4:  ldc.i4.0
    IL_00e5:  ldstr      "Ket qua "
    IL_00ea:  stelem.ref
    IL_00eb:  dup
    IL_00ec:  ldc.i4.1
    IL_00ed:  ldloca.s   V_0
    IL_00ef:  call       instance string [System.Runtime]System.Double::ToString()
    IL_00f4:  stelem.ref
    IL_00f5:  dup
    IL_00f6:  ldc.i4.2
    IL_00f7:  ldstr      "^"
    IL_00fc:  stelem.ref
    IL_00fd:  dup
    IL_00fe:  ldc.i4.3
    IL_00ff:  ldloca.s   V_1
    IL_0101:  call       instance string [System.Runtime]System.Double::ToString()
    IL_0106:  stelem.ref
    IL_0107:  dup
    IL_0108:  ldc.i4.4
    IL_0109:  ldstr      " = "
    IL_010e:  stelem.ref
    IL_010f:  dup
    IL_0110:  ldc.i4.5
    IL_0111:  ldloc.0
    IL_0112:  ldloc.1
    IL_0113:  call       float64 [System.Runtime]System.Math::Pow(float64,
                                                                  float64)
    IL_0118:  stloc.s    V_7
    IL_011a:  ldloca.s   V_7
    IL_011c:  call       instance string [System.Runtime]System.Double::ToString()
    IL_0121:  stelem.ref
    IL_0122:  call       string [System.Runtime]System.String::Concat(string[])
    IL_0127:  call       void [System.Console]System.Console::WriteLine(string)
    IL_012c:  nop
    IL_012d:  nop
    IL_012e:  br         IL_01cd

    IL_0133:  ldloc.3
    IL_0134:  ldc.i4.0
    IL_0135:  ceq
    IL_0137:  stloc.s    V_8
    IL_0139:  ldloc.s    V_8
    IL_013b:  brfalse.s  IL_014c

    IL_013d:  nop
    IL_013e:  ldstr      "Chon 1 de nhap x, y truoc!"
    IL_0143:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0148:  nop
    IL_0149:  nop
    IL_014a:  br.s       IL_01bc

    IL_014c:  ldloc.0
    IL_014d:  ldc.r8     0.0
    IL_0156:  blt.s      IL_0166

    IL_0158:  ldloc.1
    IL_0159:  ldc.r8     0.0
    IL_0162:  clt
    IL_0164:  br.s       IL_0167

    IL_0166:  ldc.i4.1
    IL_0167:  stloc.s    V_9
    IL_0169:  ldloc.s    V_9
    IL_016b:  brfalse.s  IL_017c

    IL_016d:  nop
    IL_016e:  ldstr      "Khong the tinh can bac 2 cua so am!"
    IL_0173:  call       void [System.Console]System.Console::WriteLine(string)
    IL_0178:  nop
    IL_0179:  nop
    IL_017a:  br.s       IL_01bc

    IL_017c:  nop
    IL_017d:  ldstr      "Can bac 2 cua x = "
    IL_0182:  ldloc.0
    IL_0183:  call       float64 [System.Runtime]System.Math::Sqrt(float64)
    IL_0188:  stloc.s    V_7
    IL_018a:  ldloca.s   V_7
    IL_018c:  call       instance string [System.Runtime]System.Double::ToString()
    IL_0191:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string)
    IL_0196:  call       void [System.Console]System.Console::WriteLine(string)
    IL_019b:  nop
    IL_019c:  ldstr      "Can bac 2 cua y = "
    IL_01a1:  ldloc.1
    IL_01a2:  call       float64 [System.Runtime]System.Math::Sqrt(float64)
    IL_01a7:  stloc.s    V_7
    IL_01a9:  ldloca.s   V_7
    IL_01ab:  call       instance string [System.Runtime]System.Double::ToString()
    IL_01b0:  call       string [System.Runtime]System.String::Concat(string,
                                                                      string)
    IL_01b5:  call       void [System.Console]System.Console::WriteLine(string)
    IL_01ba:  nop
    IL_01bb:  nop
    IL_01bc:  br.s       IL_01cd

    IL_01be:  br.s       IL_01cd

    IL_01c0:  ldstr      "Chuc nang khong hop le!"
    IL_01c5:  call       void [System.Console]System.Console::WriteLine(string)
    IL_01ca:  nop
    IL_01cb:  br.s       IL_01cd

    IL_01cd:  nop
    IL_01ce:  ldloc.2
    IL_01cf:  ldc.i4.4
    IL_01d0:  ceq
    IL_01d2:  ldc.i4.0
    IL_01d3:  ceq
    IL_01d5:  stloc.s    V_10
    IL_01d7:  ldloc.s    V_10
    IL_01d9:  brtrue     IL_0017

    IL_01de:  ret
  } // end of method MenuTinhToan::Bai5

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method MenuTinhToan::.ctor

} // end of class Lab02.ThucHanh1.MenuTinhToan

.class private auto ansi beforefieldinit Lab02.ThucHanh1.TH1_Main
       extends [System.Runtime]System.Object
{
  .method public hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    .custom instance void [System.Runtime]System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = ( 01 00 01 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  call       void Lab02.ThucHanh1.HoTen::Bai1()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method TH1_Main::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method TH1_Main::.ctor

} // end of class Lab02.ThucHanh1.TH1_Main


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file C:\NNLTCSharp\Lab02\ThucHanh1\ThucHanh1.res
