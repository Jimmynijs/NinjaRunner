
using UnityEngine;
using UnityEngine.SceneManagement;


public class Gamemanager : MonoBehaviour
{

    bool GameHasEnded = false;

    public GameObject LevelCompleteUI;

    public float Opnieuw = 2f;

    public float Volgende = 2f;



    public void CompleteLevel ()
    {
        LevelCompleteUI.SetActive (true);
        Invoke("NextLevel", Volgende);
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
            Debug.Log("GAME OVER!");
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
