using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SinAddCoin : MonoBehaviour
{
    public int coin;
    public TextMeshProUGUI textCoin;

    public void Start()
    {
        TestSingleton.instance.StartDebug();
        Bank.instance.StartDebug();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Bank.instance.AddCoin(1);
            coin = Bank.instance.coin;
            textCoin.text = Bank.instance.coin.ToString();
        }
    }
}
