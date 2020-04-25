
using UnityEngine;
using UnityEngine.UI; 

// Regelt de score die op de UI wordt weergegeven.


public class Score : MonoBehaviour
{

    public Transform Player;
    public Transform Eind;
    public Text scoreText;

    float weergave = 0f;

    void Update()
    {
        weergave = Eind.position.z - Player.position.z;
        scoreText.text = weergave.ToString("0");
    }
}
