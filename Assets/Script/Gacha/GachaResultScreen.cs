using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//日本語対応
public class GachaResultScreen : MonoBehaviour, IScreenController
{
    private void OnEnable()
    {
        Initialize();
    }
    public void Initialize()
    {

    }
    public void Subscribe()
    {

    }

    public void Release()
    {

    }

    public void BackPrevious()
    {
        Destroy(gameObject);
    }

    public void GoNext()
    {
        gameObject.SetActive(false);
    }

}
