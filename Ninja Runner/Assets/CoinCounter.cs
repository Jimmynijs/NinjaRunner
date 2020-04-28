using UnityEngine.UI;
using UnityEngine;

public class CoinCounter : MonoBehaviour

{
    public PlayerMovement player;
    float TotalCoins = 0;
    public Text CoinCountertext;


    void Update()
    {
        TotalCoins = player.PlayerScore;
        CoinCountertext.text = TotalCoins.ToString();
    }
    
}