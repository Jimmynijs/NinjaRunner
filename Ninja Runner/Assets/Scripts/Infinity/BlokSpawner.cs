using UnityEngine;

public class BlokSpawner : MonoBehaviour
{
    public Transform Player;

    public Transform[] SpawnPoints;

    public GameObject ObstakelPrefab;

    public float StartSpawning;
    public float SpawnRate;


    void Update()
    {
        if (Player.position.z >= StartSpawning)
        {
            Debug.Log(Player.position.z);
            Spawners ();
            StartSpawning = Player.position.z + SpawnRate;
        }
    }



    void Spawners ()
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
}

