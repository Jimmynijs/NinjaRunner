using UnityEngine;

public class Volgspeler : MonoBehaviour
{
    // Regelt dat de camera gefixeert is op de speler zonder te draaien.
    public Transform Player;
    public Vector3 offsetCamera;

    void Update()
    {
        transform.position = Player.position - offsetCamera;
    }
}
