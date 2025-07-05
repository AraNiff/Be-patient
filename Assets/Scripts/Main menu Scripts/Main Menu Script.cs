using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void Quit()
    {
        // ���� ���� �������� � ������, �������
        #if UNITY_EDITOR
        // ���� � ���������, ������������� ���������������
        UnityEditor.EditorApplication.isPlaying = false;
        #else
            // � ��������� ������, ������� �� ����������
            Application.Quit();
        #endif
    }

    public void newGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
