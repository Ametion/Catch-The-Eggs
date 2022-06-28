using UnityEngine;
using UnityEngine.SceneManagement;

namespace Components
{
    public class SceneComponent : MonoBehaviour
    {
        public void LoadSceneById(int sceneId) => SceneManager.LoadScene(sceneId);

        public void ReloadScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}