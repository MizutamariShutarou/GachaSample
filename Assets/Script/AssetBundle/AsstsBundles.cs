using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using StoringPlace;

//日本語対応
public class AsstsBundles
{
    private AssetBundle _armor = default;
    private AssetBundle _arrow = default;
    private AssetBundle _boots = default;
    private AssetBundle _bow = default;
    private AssetBundle _gloves = default;
    private AssetBundle _helmet = default;
    private AssetBundle _normalWeapon = default;
    private AssetBundle _rareWeapon = default;
    public AssetBundle Armor => _armor;
    public AssetBundle Arrow => _arrow;
    public AssetBundle Boots => _boots;
    public AssetBundle Bow => _bow;
    public AssetBundle Gloves => _gloves;
    public AssetBundle Helmet => _helmet;
    public AssetBundle NormalWeapon => _normalWeapon;
    public AssetBundle RoseWeapon => _rareWeapon;

    public AsstsBundles()
    {
        _armor = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, AssetBundleName.ARMOR));
        _arrow = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, AssetBundleName.ARROW));
        _boots = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, AssetBundleName.BOOTS));
        _bow = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, AssetBundleName.BOW));
        _gloves = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, AssetBundleName.GLOVES));
        _helmet = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, AssetBundleName.HELMET));
        _normalWeapon = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, AssetBundleName.NORMALWEAPON));
        _rareWeapon = AssetBundle.LoadFromFile(Path.Combine(Application.streamingAssetsPath, AssetBundleName.RAREWEAPON));
    }
}
