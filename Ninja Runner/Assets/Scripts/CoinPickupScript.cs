using UnityEngine;

public class CoinPickupScript : MonoBehaviour
{
    public PlayerMovement Player;
    public int PointOnPickup = 10;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Speler"))
        {
            PickUpCoin();           
        }
    }

    void PickUpCoin()
    {      
        Player.PlayerScore = Player.PlayerScore + PointOnPickup;
        FindObjectOfType<AudioManager>().Play("CoinPickup");
    }
}
