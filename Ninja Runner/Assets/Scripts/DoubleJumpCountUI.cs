using UnityEngine.UI;
using UnityEngine;

public class DoubleJumpCountUI : MonoBehaviour
{
    public PlayerMovement player;
    float DoubleJumps = 0;
    public Text DoubleJumpstext;

    
    void Update()
    {
        DoubleJumps = player.DoubleJumpCount;
        DoubleJumpstext.text = DoubleJumps.ToString();
    }
    
}
