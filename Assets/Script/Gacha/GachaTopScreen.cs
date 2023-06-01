using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//日本語対応
public class GachaTopScreen : MonoBehaviour, IScreenController
{
    [SerializeField]
    private Button _showCheckGachaButton = default;

    [SerializeField]
    private Button _doGachaButton = default;

    [SerializeField]
    private GameObject _gachaStagingScreen = default;

    [SerializeField]
    private Image _checkDoGachaPanel = default;

    private void OnEnable()
    {
        Initialize();
    }
    private void OnDisable()
    {
        Release();
        _checkDoGachaPanel.gameObject.SetActive(false);
    }
    public void Initialize()
    {
        gameObject.SetActive(true);

        _checkDoGachaPanel.gameObject.SetActive(false);
        Subscribe();
    }
    public void Subscribe()
    {
        _showCheckGachaButton.onClick.AddListener(ShowCheckGachaPanel);
        _doGachaButton.onClick.AddListener(GoNext);
    }

    public void Release()
    {
        _showCheckGachaButton.onClick.RemoveAllListeners();
        _doGachaButton.onClick.RemoveAllListeners();
    }

    public void BackPrevious()
    {

    }
    private void ShowCheckGachaPanel()
    {
        _checkDoGachaPanel.gameObject.SetActive(true);
    }

    public void GoNext()
    {
        gameObject.SetActive(false);
        _gachaStagingScreen.SetActive(true);
    }

}
