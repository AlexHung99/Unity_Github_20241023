using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesControl : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        //��������
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        //���}�C��
        Application.Quit();
    }
}

