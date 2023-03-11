using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class resetPrefs : MonoBehaviour
{
    
    public TMP_Text coinText;
    CoinCounterScript coins;
    public void Awake()
    {
        ResetScore();
    }


    public void ResetScore()
    {
       PlayerPrefs.DeleteAll();
        coins.currentCoins = 0;
        coinText.text = "SCORE: " + coins.currentCoins.ToString();


    }
   
}
