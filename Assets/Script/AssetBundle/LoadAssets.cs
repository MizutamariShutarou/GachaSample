using System.IO;
using UnityEngine;
using UnityEngine.UI;
using StoringPlace;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;

//日本語対応
public class LoadAssets : MonoBehaviour
{
    [SerializeField]
    private List<Image> _imageList = default;

    AsstsBundles _assetsBundle;

    private void Start()
    {
        _assetsBundle = new AsstsBundles();

        if (_assetsBundle == null)
        {
            Debug.Log("AssetBundleのロードに失敗しました");

            return;
        }
    }

    private async void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            for (int i = 0; i < 10; i++)
            {
                var randomNom = Random.Range(0, Armor._armorList.Count - 1);
                
                var sprite = _assetsBundle.Armor.LoadAsset<Sprite>(Armor._armorList[randomNom]);

                Debug.Log(Armor._armorList[randomNom]);
                _imageList[i].sprite = sprite;
                await UniTask.DelayFrame(200);
            }
            _assetsBundle.Armor.Unload(false);
        }
    }
}
