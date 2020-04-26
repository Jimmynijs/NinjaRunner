
using UnityEngine;

//Regelt de grondspawner.

public class GrondSpawner : MonoBehaviour

{
    public Transform Player;

    public Transform GrondSpawn;

    public GameObject GroundinfPrefab;

    private float StartSpawning = 490f;
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
     Instantiate(GroundinfPrefab, GrondSpawn.position, Quaternion.identity);   
    }
}
