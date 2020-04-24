
using UnityEngine;

public class Botsing : MonoBehaviour
{

    public PlayerMovement movement;


    void OnCollisionEnter(Collision BotsingInfo) 
    {
        if (BotsingInfo.collider.tag == "Hindernis")
        {
            movement.enabled = false;
            FindObjectOfType<Gamemanager>().EndGame();

        }
    
    
    }


}
