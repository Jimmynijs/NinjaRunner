using UnityEngine;
using UnityEngine.SceneManagement;

//Dit hele script koppeld de verschillende drukknoppen van de menu's aan wat er moet gebeuren als erop gedrukt wordt.

public class GoTo : MonoBehaviour
{

    public void Afsluiten()
    {
        FindObjectOfType<AudioManager>().Play("Drukknop");
        Application.Quit();
    }

    public void StartStory()
    {
        FindObjectOfType<AudioManager>().Play("Drukknop");
        SceneManager.LoadScene("Level00");
    }

    public void Infinity()
    {
        FindObjectOfType<AudioManager>().Play("Drukknop");
        SceneManager.LoadScene("Infinity");
    }

    public void Credits()
    {
        FindObjectOfType<AudioManager>().Play("Drukknop");
        SceneManager.LoadScene("Credits");
    }

    public void Nextlevel()
    {
        FindObjectOfType<AudioManager>().Play("Drukknop");
        SceneManager.LoadScene("Level01");
    }
}
