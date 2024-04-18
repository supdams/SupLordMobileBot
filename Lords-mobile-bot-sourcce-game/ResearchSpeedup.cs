﻿// Decompiled with JetBrains decompiler
// Type: ResearchSpeedup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4857610B-EF43-43B0-884E-D10225C3A26E
// Assembly location: C:\Users\supdams\Desktop\Assembly-CSharp.dll.dll

using System.Collections.Generic;

#nullable disable
public class ResearchSpeedup : SpeedupBase
{
  public ResearchSpeedup(EQueueBarIndex QueueBar)
  {
    StringTable mStringTable = DataManager.Instance.mStringTable;
    this.MainTitleStr = mStringTable.GetStringByID(289U);
    this.CompleteImmContStr = mStringTable.GetStringByID(202U);
    this.CompleteImmBntStr = mStringTable.GetStringByID(215U);
    this.bFreeSpeedup = true;
    this.bImmediate = true;
    this.QueueBar = (byte) QueueBar;
    this.UseTarget = _UseItemTarget.Research;
    this.FilterType = (byte) 1;
    this.FilterType2 = (byte) 12;
  }

  public override void SendImmediate()
  {
    DataManager.Instance.sendTechnologyResearchCompleteImmediate((ushort) 0);
  }

  public override void SendImmediateFree() => DataManager.Instance.sendTechnologyCompleteFree();

  public override void CustomSort(List<ushort> Data, int BagCount)
  {
    if (this.CustomList == null)
      this.CustomList = new List<ushort>();
    this.CustomList.Clear();
    this.CustomList.AddRange((IEnumerable<ushort>) Data);
    Data.Clear();
    DataManager instance = DataManager.Instance;
    for (int index = 0; index < BagCount; ++index)
    {
      if (this.CustomList[index] == (ushort) 0)
      {
        Data.Add(this.CustomList[index]);
        this.CustomList.RemoveAt(index);
        --BagCount;
        --index;
      }
      else if ((byte) instance.EquipTable.GetRecordByKey(this.CustomList[index]).PropertiesInfo[0].Propertieskey == (byte) 12)
      {
        Data.Add(this.CustomList[index]);
        this.CustomList.RemoveAt(index);
        --BagCount;
        --index;
      }
    }
    Data.AddRange((IEnumerable<ushort>) this.CustomList);
  }
}
