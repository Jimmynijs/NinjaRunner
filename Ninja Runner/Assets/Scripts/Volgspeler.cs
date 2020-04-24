using UnityEngine;

public class Volgspeler : MonoBehaviour
{

    public Transform Player;
    public Vector3 offsetCamera;

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position - offsetCamera;
    }
}
