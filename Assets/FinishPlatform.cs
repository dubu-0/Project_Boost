using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPlatform : CollisionHandler
{
    protected override void OnCollisionEnter(Collision other)
    {
        if (IsCollided) return;

        DisableInputMovement();
        RemoveRigidbodyConstrains();   
        MutePlayerEngine();
        
        PlayerCachedComponents.PlayerSFX.PlaySound(Sound.Success);
        sceneLoader.Invoke(nameof(sceneLoader.LoadNextScene), sceneLoadDelay);

        IsCollided = true;
    }
}