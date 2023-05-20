using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//日本語対応
public abstract class ItemDataBase : ScriptableObject
{
    public string _itemName = default;

    public int _rareNum = default;

    public ItemType _itemType = default;
}
