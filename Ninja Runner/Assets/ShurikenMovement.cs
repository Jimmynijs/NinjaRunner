using UnityEngine;

public class ShurikenMovement : MonoBehaviour
{
    public Rigidbody ShurikenRB;
    public float ShurikenSpeed = 10000f;

    void FixedUpdate()
    {
        ShurikenRB.AddForce(0, 0, ShurikenSpeed * Time.deltaTime, ForceMode.VelocityChange);         //Kracht naar voren
    }
        
}
