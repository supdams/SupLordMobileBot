﻿// Decompiled with JetBrains decompiler
// Type: ShowColor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4857610B-EF43-43B0-884E-D10225C3A26E
// Assembly location: C:\Users\supdams\Desktop\Assembly-CSharp.dll.dll

using System.Runtime.InteropServices;

#nullable disable
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct ShowColor
{
  [MarshalAs(UnmanagedType.U2)]
  public ushort ShowColorID;
  [MarshalAs(UnmanagedType.U1)]
  public byte ColorR;
  [MarshalAs(UnmanagedType.U1)]
  public byte ColorG;
  [MarshalAs(UnmanagedType.U1)]
  public byte ColorB;
  [MarshalAs(UnmanagedType.U1)]
  public ushort ColorA;
}
