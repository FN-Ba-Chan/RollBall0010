using TMPro;
using UnityEngine;

public class StageOut : MonoBehaviour
{
    public int Life = 3;
    public TextMeshProUGUI LifeText;
    //  このコードをアタッチしたオブジェクトに他のオブジェクトがすり抜けた時
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log($"{other.name}がすり抜けた");
        //すり抜けたオブジェクトを破壊
        Destroy(other.gameObject);
        Life = Life - 1 ;
        //　変数scoreTextのtextプロパティに
        //　現在の全財産{Score}円;を代入（表示する）
        LifeText.text = $"残り星{Life}つ";

        
    }
}
