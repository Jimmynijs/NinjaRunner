
using UnityEngine;

//Hierin worden de belangrijkste dingen bijgehouden m.b.t. de speler.
//Bijvoorbeeld De controls, of de speler de grond raakt, de krachten die op de speler werken, etc.

public class PlayerMovement : MonoBehaviour
{
    //Variabelen
    public Rigidbody rb;

    public Transform ShurikenSpawn;
    public GameObject ShurikenThrowPrefab;

    public float Speedvoren = 2000f;
    public float Speedstuur = 200f;
    public float Springkracht = 1000f;
    public float DoubleJumpKracht = 1000f;
    public float Zwaartekracht = 500f;
    public int DoubleJumpCount = 0;
    public int ShurikenCount = 0;

    public int PlayerScore = 0;

    bool BewegingLinks = false;
    bool BewegingRechts = false;
    bool Spring = false;
    bool RaaktGrond = false;
    bool DoubleJump = false;
    bool Shuriken = false;

    void Update()
    {
        if (Input.GetKey("d"))
        {
            BewegingRechts = true;
        }
        else
        {
            BewegingRechts = false;
        }

        if (Input.GetKey("a"))
        {
            BewegingLinks = true;
        }
        else
        {
            BewegingLinks = false;
        }

        if (Input.GetKey("w"))
        {
            Spring = true;
        }
        else
        {
            Spring = false;
        }

        if (Input.GetKeyDown("w") & RaaktGrond == false & DoubleJumpCount > 0)
        {
            DoubleJump = true;
            DoubleJumpCount = DoubleJumpCount - 1;
        }
        else
        {
            DoubleJump = false;
        }

        if (Input.GetKeyDown("e") & ShurikenCount >= 1)
        {
            Shuriken = true;
            ShurikenCount = ShurikenCount - 1;
        }
        else
        {
            Shuriken = false;
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, Speedvoren * Time.deltaTime);         //Kracht naar voren
        rb.AddForce(0, -Zwaartekracht * Time.deltaTime, 0, ForceMode.VelocityChange);     //Kracht naar beneden

        if (BewegingRechts == true)
        {
            rb.AddForce(Speedstuur * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (BewegingLinks == true)
        {
            rb.AddForce(-Speedstuur * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (RaaktGrond == true & Spring == true)
        {
            FindObjectOfType<AudioManager>().Play("Spring");
            rb.AddForce(0, Springkracht * Time.deltaTime, 0, ForceMode.Impulse);
        }

        if (DoubleJump == true)
        {
            FindObjectOfType<AudioManager>().Play("Spring");
            rb.AddForce(0, DoubleJumpKracht * Time.deltaTime, 0, ForceMode.Impulse);
        }

        if (Shuriken == true)
        {
            Instantiate(ShurikenThrowPrefab, ShurikenSpawn.position, Quaternion.identity);
        }
    }

    //Checkt of de speler iets beloopbaars raakt
    void OnCollisionExit(Collision LoopInfo)
    {
        if (LoopInfo.collider.tag == "Loopbaar")
        {
            RaaktGrond = false;
            FindObjectOfType<AudioManager>().Stop("Lopen");
        }
    }
    void OnCollisionEnter(Collision LoopInfo)
    {
        if (LoopInfo.collider.tag == "Loopbaar")
        {
            RaaktGrond = true;
            FindObjectOfType<AudioManager>().Play("Lopen");
        }
    }
   
}
