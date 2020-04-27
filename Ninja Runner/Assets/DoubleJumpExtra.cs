using UnityEngine;

public class DoubleJumpExtra : MonoBehaviour
{
    public PlayerMovement player;
    public int ExtraJumps = 3;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Speler"))
        {
            PickUp();
        }
    }

    void PickUp()
    {
        Debug.Log("Opgepakt!");
    }
}
