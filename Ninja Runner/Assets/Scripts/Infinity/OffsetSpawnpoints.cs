using UnityEngine;

public class OffsetSpawnpoints : MonoBehaviour
{
    public Transform Spawn1;
    public float OffsetSpawn1;
    public Transform Player;

    void Start ()
    {
        Spawn1.position = new Vector3(0, 1, Player.position.z + OffsetSpawn1);
    }

    void Update()
    {
        Spawn1.position = new Vector3(0, 1, Player.position.z + OffsetSpawn1);
    }
}


