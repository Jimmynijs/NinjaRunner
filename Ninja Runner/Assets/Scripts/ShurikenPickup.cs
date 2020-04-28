using UnityEngine;

public class ShurikenPickup : MonoBehaviour

{
    public PlayerMovement Player;
    public int ShurikenOnPickup = 3;
    public GameObject ShurikenPickupEffect;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Speler"))
        {
            PickUpShuriken();
        }
    }

    void PickUpShuriken()
    {
        Player.ShurikenCount = Player.ShurikenCount + ShurikenOnPickup;
        Instantiate(ShurikenPickupEffect, transform.position, transform.rotation);
        FindObjectOfType<AudioManager>().Play("ShurikenPickup");
        Destroy(gameObject);
    }
}
