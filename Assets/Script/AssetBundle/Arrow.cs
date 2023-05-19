using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//日本語対応
public static class Arrow
{
    public const string ARROWA = "BattleBow";
    public const string ARROWB = "HunterBow";
    public const string ARROWC = "MarauderBow";
    public const string ARROWD = "RedwoodBow";
    public const string ARROWE = "VikingShortBow";
    public const string ARROWF = "WyvernHornBow";

    public static List<string> _arrowList = new List<string>()
    {
        ARROWA, ARROWB, ARROWC, ARROWD, ARROWE, ARROWF
    };
}
