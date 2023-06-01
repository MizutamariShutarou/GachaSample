using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//日本語対応
public abstract class ItemDataBase : ScriptableObject
{
    public string _itemName = default;

    public int _rareNum = default;

    public Image _iconmage;

    public GameObject _itemObject;

    public ItemType _itemType = default;
}
