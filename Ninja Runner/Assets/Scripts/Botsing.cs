
using UnityEngine;

public class Botsing : MonoBehaviour
{

    public PlayerMovement movement;

    //Stukje code zet de besturen van de speler uit op een botsing.
    //Kan later ook bij PlayerMovement worden geplaatst.
    //Ga ik later aanpassen.

    void OnCollisionEnter(Collision BotsingInfo) 
    {
        if (BotsingInfo.collider.tag == "Hindernis")
        {
            movement.enabled = false;
            FindObjectOfType<AudioManager>().Stop("Lopen");
            FindObjectOfType<AudioManager>().Play("Botsing");
            FindObjectOfType<Gamemanager>().EndGame();

        }
    
    
    }


}
