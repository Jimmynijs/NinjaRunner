
using UnityEngine;
using UnityEngine.UI; 

public class Score : MonoBehaviour
{

    public Transform Player;
    public Transform Eind;
    public Text scoreText;

    float weergave = 0f;

    // Update is called once per frame
    void Update()
    {
        weergave = Eind.position.z - Player.position.z;
        scoreText.text = weergave.ToString("0");
    }
}
