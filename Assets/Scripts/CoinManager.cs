using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public int NumberOfCoins;
    [SerializeField] TextMeshProUGUI _text;

    private void Start()
    {
        NumberOfCoins = Progress.Instance.PlayerInfo.Coins;
        _text.text = NumberOfCoins.ToString();
    }

    private void Update()
    {
        _text.text = NumberOfCoins.ToString();
    }

    public void SaveToProgress()
    {
        Progress.Instance.PlayerInfo.Coins = NumberOfCoins;
    }
}
