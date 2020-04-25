
using UnityEngine;
using UnityEngine.UI;

//Regels de score in het infinitylevel.

public class Score2 : MonoBehaviour
{

    public Transform Player;
    public Text scoreText;

  
    void Update()
    {
        scoreText.text = Player.position.z.ToString("0");
    }
}
