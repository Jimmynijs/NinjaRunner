using UnityEngine;
using UnityEngine.SceneManagement;

// Stukje code regelt dat als er op de postgame screenknop wordt gedrukt, dat ie teruggaat naar het menu.
// Kan eigenlijk ook onder het GoToscript worden geplaatst
// later aanpassen!

public class Return : MonoBehaviour
{

    public void ReturnMenu()
    {
        FindObjectOfType<AudioManager>().Play("Drukknop");
        SceneManager.LoadScene("Menu");
    }
}
