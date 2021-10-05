using UnityEngine;
using UnityEngine.SceneManagement;

namespace Level
{
    public class SceneLoader : MonoBehaviour
    {
        public void LoadNextScene()
        {
            var nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

            if (nextSceneIndex >= SceneManager.sceneCountInBuildSettings)
                nextSceneIndex = 0;

            SceneManager.LoadScene(nextSceneIndex);
        }

        public void RestartCurrentScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
