using UnityEngine;

public class VolgSpelerShurikenSpawn : MonoBehaviour
{
   
    // Regelt dat de shuriken spawner gefixeert is op de speler zonder te draaien.
    public Transform Player;
    public Vector3 OffsetShurikenSpawn;

    void Update()
    {
        transform.position = Player.position + OffsetShurikenSpawn;
    }
}
