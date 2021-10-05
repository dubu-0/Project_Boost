using System;
using Enums;
using Player;
using UnityEngine;

namespace Level
{
    public class Obstacle : CollisionHandler
    {
        protected override void OnCollisionEnter(Collision other)
        {
            if (IsCollided) return;

            DisableInputMovement();
            RemoveRigidbodyConstrains();
            MutePlayerEngine();

            PlayerCachedComponents.PlayerSFX.PlaySound(Sound.Explosion);
            PlayerCachedComponents.PlayerVFX.PlayEffect(ParticleEffect.Explosion, true);
            PlayerCachedComponents.PlayerVFX.PlayEffect(ParticleEffect.Jet, false);
            sceneLoader.Invoke(nameof(sceneLoader.RestartCurrentScene), sceneLoadDelay);

            IsCollided = true;
        }
    }
}
