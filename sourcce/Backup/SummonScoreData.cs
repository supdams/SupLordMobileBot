﻿// Decompiled with JetBrains decompiler
// Type: SummonScoreData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4857610B-EF43-43B0-884E-D10225C3A26E
// Assembly location: C:\Users\supdams\Desktop\Assembly-CSharp.dll.dll

using System.Runtime.InteropServices;

#nullable disable
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct SummonScoreData
{
  [MarshalAs(UnmanagedType.U2)]
  public ushort ID;
  [MarshalAs(UnmanagedType.U1)]
  public byte ScoreFactor;
  [MarshalAs(UnmanagedType.U1)]
  public byte Level;
  [MarshalAs(UnmanagedType.U4)]
  public uint Score1;
  [MarshalAs(UnmanagedType.U4)]
  public uint Score2;
  [MarshalAs(UnmanagedType.U4)]
  public uint Reserve1;
  [MarshalAs(UnmanagedType.U4)]
  public uint Reserve2;
  [MarshalAs(UnmanagedType.U4)]
  public uint Reserve3;
  [MarshalAs(UnmanagedType.U4)]
  public uint Reserve4;
}
