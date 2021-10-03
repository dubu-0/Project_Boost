using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPlatform : MonoBehaviour
{
    [SerializeField] private SceneLoader sceneLoader;

    private void OnCollisionEnter(Collision other)
    {
        PlayerComponentCollection.PlayerMovement.enabled = false;
        PlayerComponentCollection.Rigidbody.constraints = RigidbodyConstraints.None;
        PlayerComponentCollection.PlayerSFX.MuteEngine(true);
        sceneLoader.Invoke(nameof(sceneLoader.LoadNextScene), 2);
    }
}
