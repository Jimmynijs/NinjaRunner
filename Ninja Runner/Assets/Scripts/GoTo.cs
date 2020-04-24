using UnityEngine;
using UnityEngine.SceneManagement;

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
