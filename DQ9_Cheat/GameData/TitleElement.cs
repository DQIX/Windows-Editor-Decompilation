﻿// Decompiled with JetBrains decompiler
// Type: DQ9_Cheat.GameData.TitleElement
// Assembly: DQ9_Cheat, Version=0.7.0.57, Culture=neutral, PublicKeyToken=null
// MVID: 9E5BE672-CBE6-45FB-AC35-96531044560E
// Assembly location: dq9_save_editor_0.7\DQCheat.Patched.0.7.exe

namespace DQ9_Cheat.GameData;

public class TitleElement
{
    public TitleElement(string maleTitleName, string ladyTitleName, int index)
    {
        MaleTitleName = maleTitleName;
        LadyTitleName = ladyTitleName;
        DataIndex = index;
    }

    public string MaleTitleName { get; }

    public string LadyTitleName { get; }

    public int DataIndex { get; }
}