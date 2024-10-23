using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesControl : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        //¤Á´«³õ´º
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        //Â÷¶}¹CÀ¸
        Application.Quit();
    }
}

