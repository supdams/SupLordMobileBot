﻿// Decompiled with JetBrains decompiler
// Type: LordEquipMaterial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4857610B-EF43-43B0-884E-D10225C3A26E
// Assembly location: C:\Users\supdams\Desktop\Assembly-CSharp.dll.dll

#nullable disable
public struct LordEquipMaterial
{
  public ushort ItemID;
  public byte Color;
  public ushort Quantity;

  public void Clear()
  {
    this.ItemID = (ushort) 0;
    this.Color = (byte) 0;
    this.Quantity = (ushort) 0;
  }
}
