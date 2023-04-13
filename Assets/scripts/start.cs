using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneButton : MonoBehaviour
{
    public string sceneName; // The name of the scene to load

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}

