using UnityEngine;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{

    public void ReturnMenu()
    {
        Debug.Log("Return");
        SceneManager.LoadScene("Menu");
    }
}
