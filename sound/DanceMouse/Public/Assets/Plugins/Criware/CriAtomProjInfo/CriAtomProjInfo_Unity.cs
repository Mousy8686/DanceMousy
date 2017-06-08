/****************************************************************************
*
* CRI Middleware SDK
*
* Copyright (c) 2011-2012 CRI Middleware Co., Ltd.
*
* Library  : CRI Atom
* Module   : CRI Atom for Unity
* File     : CriAtomProjInfo_Unity.cs
* Tool Ver.          : CRI Atom Craft LE Ver.2.19.02
* Date Time          : 2017/06/08 17:58
* Project Name       : DanceMouse
* Project Comment    : 
*
****************************************************************************/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public partial class CriAtomAcfInfo
{
    static partial void GetCueInfoInternal()
    {
        acfInfo = new AcfInfo("ACF", 0, "", "DanceMouse.acf","b1a559c1-9c4a-4904-b103-4bf3cd76ae2c","DspBusSetting_0");
        acfInfo.aisacControlNameList.Add("Any");
        acfInfo.aisacControlNameList.Add("Distance");
        acfInfo.aisacControlNameList.Add("AisacControl02");
        acfInfo.aisacControlNameList.Add("AisacControl03");
        acfInfo.aisacControlNameList.Add("AisacControl04");
        acfInfo.aisacControlNameList.Add("AisacControl05");
        acfInfo.aisacControlNameList.Add("AisacControl06");
        acfInfo.aisacControlNameList.Add("AisacControl07");
        acfInfo.aisacControlNameList.Add("AisacControl08");
        acfInfo.aisacControlNameList.Add("AisacControl09");
        acfInfo.aisacControlNameList.Add("AisacControl10");
        acfInfo.aisacControlNameList.Add("AisacControl11");
        acfInfo.aisacControlNameList.Add("AisacControl12");
        acfInfo.aisacControlNameList.Add("AisacControl13");
        acfInfo.aisacControlNameList.Add("AisacControl14");
        acfInfo.aisacControlNameList.Add("AisacControl15");
        acfInfo.acbInfoList.Clear();
        AcbInfo newAcbInfo = null;
        newAcbInfo = new AcbInfo("CueSheet_0", 0, "", "CueSheet_0.acb", "CueSheet_0.awb","3ca9479a-905a-4b7f-a7f6-28868ff84c6a");
        acfInfo.acbInfoList.Add(newAcbInfo);
        newAcbInfo.cueInfoList.Add(0, new CueInfo("bgm_title", 0, ""));
        newAcbInfo.cueInfoList.Add(2, new CueInfo("se_maoudamashii_onepoint15", 2, ""));
        newAcbInfo.cueInfoList.Add(3, new CueInfo("logo", 3, ""));
        newAcbInfo.cueInfoList.Add(4, new CueInfo("action_hahaha", 4, ""));
        newAcbInfo.cueInfoList.Add(5, new CueInfo("action_joy1", 5, ""));
        newAcbInfo.cueInfoList.Add(6, new CueInfo("action_joy2", 6, ""));
        newAcbInfo.cueInfoList.Add(7, new CueInfo("action_joy3", 7, ""));
        newAcbInfo.cueInfoList.Add(8, new CueInfo("action_shobon1", 8, ""));
    }
}
