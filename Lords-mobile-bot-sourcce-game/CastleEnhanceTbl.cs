﻿// Decompiled with JetBrains decompiler
// Type: CastleEnhanceTbl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4857610B-EF43-43B0-884E-D10225C3A26E
// Assembly location: C:\Users\supdams\Desktop\Assembly-CSharp.dll.dll

using System.Runtime.InteropServices;

#nullable disable
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct CastleEnhanceTbl
{
  [MarshalAs(UnmanagedType.U2)]
  public ushort ID;
  [MarshalAs(UnmanagedType.U2)]
  public ushort CastleID;
  [MarshalAs(UnmanagedType.U1)]
  public byte Rank;
  [MarshalAs(UnmanagedType.U2)]
  public ushort EnhanceTotalNum;
  [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
  public ushort[] Value;
  [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
  public ushort[] Reserve;
}