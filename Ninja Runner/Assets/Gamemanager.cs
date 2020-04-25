// Werkt als een soort regelaar van levels. Switchen daartussen, herstarten, etc.


using UnityEngine;
using UnityEngine.SceneManagement;


public class Gamemanager : MonoBehaviour
{

    bool GameHasEnded = false;
    public GameObject LevelCompleteUI;

    //Timers voor herstarten en volgende.
    public float Opnieuw = 2f;
    public float Volgende = 2f;



    public void CompleteLevel ()
    {
        LevelCompleteUI.SetActive (true);       //Regelt scherm 'level complete'
        Invoke("NextLevel", Volgende);          //Regelt volgend level na een delay
    }

    void NextLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    

    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Invoke ("Restart", Opnieuw);
        }
    }

    void Restart ()
    {
        if (GameHasEnded == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);       
        }
    }
}
