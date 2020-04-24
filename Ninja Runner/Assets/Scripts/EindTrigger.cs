
using UnityEngine;

public class EindTrigger : MonoBehaviour
{
    public Gamemanager Gamemanager; 

    void OnTriggerEnter()
    {
        Gamemanager.CompleteLevel();
    }
}
