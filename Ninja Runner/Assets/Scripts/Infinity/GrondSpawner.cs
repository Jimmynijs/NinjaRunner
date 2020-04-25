
using UnityEngine;

//Regelt de grondspawner.

public class GrondSpawner : MonoBehaviour

{
    public Transform Player;

    public Transform GrondSpawn;

    public GameObject GroundPrefab;

    private float StartSpawning = 500f;
    private float SpawnRate = 950f;


    void Update()
    {
        if (Player.position.z >= StartSpawning)
        {
            GroundSpawn();
            StartSpawning = Player.position.z + SpawnRate;
        }
    }



    void GroundSpawn()
    {      
     Instantiate(GroundPrefab, GrondSpawn.position, Quaternion.identity);   
    }
}
