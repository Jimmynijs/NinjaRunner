
using UnityEngine;
using UnityEngine.UI;

public class Score2 : MonoBehaviour
{

    public Transform Player;
    public Text scoreText;

  
    void Update()
    {
        scoreText.text = Player.position.z.ToString("0");
    }
}
