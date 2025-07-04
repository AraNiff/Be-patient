using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public void newGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
