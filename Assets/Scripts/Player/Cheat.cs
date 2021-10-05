using Level;
using UnityEngine;

namespace Player
{
    public class Cheat : MonoBehaviour
    {
        [SerializeField] private SceneLoader sceneLoader;
    
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                ToggleCollisions(false);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                ToggleCollisions(true);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                LoadNextLevel();
            }
        }

        private void ToggleCollisions(bool enable)
        {
            var playerColliders = PlayerCachedComponents.BoxCollider.GetComponentsInChildren<Collider>();
        
            foreach (var playerCollider in playerColliders)
            {
                playerCollider.enabled = enable;
            }
        }
        private void LoadNextLevel() => sceneLoader.LoadNextScene();
    }
}