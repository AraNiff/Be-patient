using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void Quit()
    {
        // Если игра запущена в сборке, выходим
        #if UNITY_EDITOR
        // Если в редакторе, останавливаем воспроизведение
        UnityEditor.EditorApplication.isPlaying = false;
        #else
            // В противном случае, выходим из приложения
            Application.Quit();
        #endif
    }

    public void newGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
