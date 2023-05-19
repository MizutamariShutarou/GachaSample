using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//日本語対応
public static class Armor
{
    public const string ARMORA = "BanditLightArmor [Paint]";
    public const string ARMORB = "BattleguardArmor";
    public const string ARMORC = "DarkMountain";
    public const string ARMORD = "GreyKnight";
    public const string ARMORE = "ManticoreArmor";
    public const string ARMORF = "RoyalTunic";
    public const string ARMORG = "Scout [Paint]";

    public static List<string> _armorList = new List<string>() 
    {
        ARMORA, ARMORB, ARMORC, ARMORD, ARMORE, ARMORF, ARMORG
    };
}
