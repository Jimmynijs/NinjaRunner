
using UnityEngine;

//Stukje code koppeld het blok waar de speler inrent als einde aan de gamemanager.
public class EindTrigger : MonoBehaviour
{
    public Gamemanager Gamemanager; 

    void OnTriggerEnter(Collider EnterInfo)
    {
        if (EnterInfo.GetComponent<Collider>().tag == "Speler")
        {
            Gamemanager.CompleteLevel();
        }
    }
}
