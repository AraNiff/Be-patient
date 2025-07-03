using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicSceneScript : MonoBehaviour
{
    public GameObject deathScreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void Death()
    {
        deathScreen.SetActive(true);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
