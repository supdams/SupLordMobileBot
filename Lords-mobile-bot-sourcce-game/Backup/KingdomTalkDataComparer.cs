﻿// Decompiled with JetBrains decompiler
// Type: KingdomTalkDataComparer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4857610B-EF43-43B0-884E-D10225C3A26E
// Assembly location: C:\Users\supdams\Desktop\Assembly-CSharp.dll.dll

using System.Collections.Generic;

#nullable disable
public class KingdomTalkDataComparer : IComparer<TalkDataType>
{
  public int Compare(TalkDataType x, TalkDataType y)
  {
    if (x == null)
      return y == null ? 0 : -1;
    if (y == null || x.TalkTime > y.TalkTime)
      return 1;
    if (x.TalkTime < y.TalkTime)
      return -1;
    if (x.TalkID > y.TalkID)
      return 1;
    return x.TalkID < y.TalkID ? -1 : 0;
  }
}
