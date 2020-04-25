
using UnityEngine;

//Regelt dat de grondspawner een afstand heeft tot de speler en mee beweegt met de speler.

public class OffsetGround : MonoBehaviour
{
 
    public Transform Player;
    public Transform SpawnGrond;


    void Start()
    {
        SpawnGrond.position = new Vector3(0, 0, Player.position.z + 1000);
    }

    void Update()
    {
        SpawnGrond.position = new Vector3(0, 0, Player.position.z + 1000);
    }
    
}

