using Enums;
using Player;
using UnityEngine;

namespace Level
{
    public class FinishPlatform : CollisionHandler
    {
        protected override void OnCollisionEnter(Collision other)
        {
            if (IsCollided) return;

            DisableInputMovement();
            RemoveRigidbodyConstrains();   
            PlayerCachedComponents.PlayerSFX.ChangeEngineVolume(0);
        
            PlayerCachedComponents.PlayerSFX.PlaySound(Sound.Success);
            PlayerCachedComponents.PlayerVFX.PlayEffect(ParticleEffect.Success, true);
            PlayerCachedComponents.PlayerVFX.PlayEffect(ParticleEffect.Jet, false);
            sceneLoader.Invoke(nameof(sceneLoader.LoadNextScene), sceneLoadDelay);

            IsCollided = true;
        }
    }
}