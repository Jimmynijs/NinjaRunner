using UnityEngine;

//Het stuk code dat de blokken laat spawnen uit de spawners.

public class BlokSpawner : MonoBehaviour
{
    public Transform Player;

    public Transform[] SpawnPoints;
    public Transform[] SpawnPointsGroot;

    public GameObject ObstakelPrefab;
    public GameObject ObstakelGrootPrefab;

    private float StartSpawning = 10f;

    [Range(20, 100)]
    public float SpawnRate;


    void Update()
    {
        if (Player.position.z >= StartSpawning)
        {
            Spawners1 ();
            SpawnersGroot();
            StartSpawning = Player.position.z + SpawnRate;
        }
    }


    //Regelt kleine blokjes
    void Spawners1 ()
    {
        int randomIndex = Random.Range(0, SpawnPoints.Length);

        for (int i = 0; i < SpawnPoints.Length; i++)
        {
            if (randomIndex == i)
            {
                Instantiate(ObstakelPrefab, SpawnPoints[i].position, Quaternion.identity);
            }
        }
    }

    //Regelt grote blokjes
    void SpawnersGroot()
    {
        int randomIndex = Random.Range(0, SpawnPointsGroot.Length);

        for (int i = 0; i < SpawnPointsGroot.Length; i++)
        {
            if (randomIndex == i)
            {
                Instantiate(ObstakelGrootPrefab, SpawnPointsGroot[i].position, Quaternion.identity);
            }
        }
    }
}

