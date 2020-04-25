using UnityEngine;
using UnityEngine.SceneManagement;

//Dit hele script koppeld de verschillende drukknoppen van de menu's aan wat er moet gebeuren als erop gedrukt wordt.

public class GoTo : MonoBehaviour
{

    public void Afsluiten()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void StartStory()
    {
        Debug.Log("Start");
        SceneManager.LoadScene("Level00");
    }

    public void Infinity()
    {
        Debug.Log("Infinity");
        SceneManager.LoadScene("Infinity");
    }

    public void Credits()
    {
        Debug.Log("Credits");
        SceneManager.LoadScene("Credits");
    }

    public void Nextlevel()
    {
        SceneManager.LoadScene("Level01");
    }
}
