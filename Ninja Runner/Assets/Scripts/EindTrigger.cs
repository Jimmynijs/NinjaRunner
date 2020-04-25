
using UnityEngine;

//Stukje code koppeld het blok waar de speler inrent als einde aan de gamemanager.
public class EindTrigger : MonoBehaviour
{
    public Gamemanager Gamemanager; 

    void OnTriggerEnter()
    {
        Gamemanager.CompleteLevel();
    }
}
