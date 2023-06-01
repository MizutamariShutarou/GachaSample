using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System.Threading;

//日本語対応
public class GachaStagingScreen : MonoBehaviour, IScreenController
{
    [SerializeField]
    GameObject _mainUI = default;
    private void OnEnable()
    {
        Initialize();
    }
    public void Initialize()
    {
        _mainUI.SetActive(false);

        gameObject.SetActive(true);
    }
    public void BackPrevious()
    {
        throw new System.NotImplementedException();
    }
    public void GoNext()
    {
        throw new System.NotImplementedException();
    }
    public void Subscribe()
    {
        throw new System.NotImplementedException();
    }

    public void Release()
    {
        throw new System.NotImplementedException();
    }
}