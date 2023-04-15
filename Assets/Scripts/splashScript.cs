using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenController : MonoBehaviour
{
    public float delay = 3.0f; // Delay in seconds before loading the next scene
    public string nextSceneName; // Name of the scene to load after the splash screen

    void Start()
    {
        Invoke("LoadNextScene", delay);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}