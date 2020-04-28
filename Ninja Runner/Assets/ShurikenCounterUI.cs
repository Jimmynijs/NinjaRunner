using UnityEngine.UI;
using UnityEngine;

public class ShurikenCounterUI : MonoBehaviour
{
    public PlayerMovement player;
    int Shurikens = 0;
    public Text Shurikenstext;


    void Update()
    {
        Shurikens = player.ShurikenCount;
        Shurikenstext.text = Shurikens.ToString();
    }

}
