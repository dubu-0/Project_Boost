using Level;
using UnityEngine;

namespace Player
{
    public abstract class CollisionHandler : MonoBehaviour
    {
        [SerializeField] protected SceneLoader sceneLoader;
        [SerializeField] protected float sceneLoadDelay;
    
        protected static bool IsCollided;

        protected abstract void OnCollisionEnter(Collision other);

        private void OnDisable()
        {
            IsCollided = false;
        }

        protected void MutePlayerEngine() => PlayerCachedComponents.PlayerSFX.MuteEngine(true);
        protected void DisableInputMovement() => PlayerCachedComponents.PlayerMovement.enabled = false;
        protected void RemoveRigidbodyConstrains() => PlayerCachedComponents.Rigidbody.constraints = RigidbodyConstraints.None;
    }
}