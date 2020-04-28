using UnityEngine;

public class DoubleJumpExtra : MonoBehaviour
{
    public PlayerMovement player;
    public int ExtraJumps = 3;
    public GameObject DoubleJumpEffect;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Speler"))
        {
            PickUp();
        }
    }

    void PickUp()
    {
        FindObjectOfType<AudioManager>().Play("DoubleJumpPickup");
        Instantiate(DoubleJumpEffect, transform.position, transform.rotation);
        player.DoubleJumpCount = player.DoubleJumpCount + ExtraJumps;
        Destroy(gameObject);
    }
}
