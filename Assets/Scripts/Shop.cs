using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] CoinManager _coinManager;
    [SerializeField] GameObject _buttonChartersGirl;
    [SerializeField] GameObject _buttonChartersBoy;
    [SerializeField] GameObject _buttonChartersPolice;
    [SerializeField] GameObject _buttonChartersSolder;
    [SerializeField] GameObject _buttonChartersHero;

    public void BueGirl()
    {
        if (_coinManager.NumberOfCoins >= 120)
        {
            _coinManager.NumberOfCoins -= 120;
            Progress.Instance.PlayerInfo.Coins = _coinManager.NumberOfCoins;
            Destroy(_buttonChartersGirl);
        }
    }

        public void BueBoy()
        {
            if (_coinManager.NumberOfCoins >= 240)
            {
                _coinManager.NumberOfCoins -= 240;
                Progress.Instance.PlayerInfo.Coins = _coinManager.NumberOfCoins;
                Destroy(_buttonChartersBoy);
            }
        }

        public void BuePolice()
        {
            if (_coinManager.NumberOfCoins >= 350)
            {
                _coinManager.NumberOfCoins -= 350;
                Progress.Instance.PlayerInfo.Coins = _coinManager.NumberOfCoins;
                Destroy(_buttonChartersPolice);
            }
        }

        public void BueSolder()
        {
            if (_coinManager.NumberOfCoins >= 500)
            {
                _coinManager.NumberOfCoins -= 500;
                Progress.Instance.PlayerInfo.Coins = _coinManager.NumberOfCoins;
                Destroy(_buttonChartersSolder);
            }
        }

        public void BueHero()
        {
            if (_coinManager.NumberOfCoins >= 700)
            {
                _coinManager.NumberOfCoins -= 700;
                Progress.Instance.PlayerInfo.Coins = _coinManager.NumberOfCoins;
                Destroy(_buttonChartersHero);
            }
        }
    
}
