using UnityEngine;

public class CoinPickupScript : MonoBehaviour
{
    public PlayerMovement Player;
    public int PointOnPickup = 10;
    public GameObject CoinPickupEffect;

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
        Instantiate(CoinPickupEffect, transform.position, transform.rotation);
        FindObjectOfType<AudioManager>().Play("CoinPickup");
        Destroy(gameObject);
    }
}
