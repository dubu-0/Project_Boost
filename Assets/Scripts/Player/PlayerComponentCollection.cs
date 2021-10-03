using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(PlayerSFX))]
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(AudioSource))]
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(PlayerComponentCollection))]
    public class PlayerComponentCollection : MonoBehaviour
    {
        private PlayerComponentCollection() { }
        
        public static Rigidbody Rigidbody { get; private set; }
        public static AudioSource AudioSource { get; private set; }
        public static PlayerMovement PlayerMovement { get; private set; }
        public static PlayerSFX PlayerSFX { get; private set; }

        private void Awake()
        {
            PlayerSFX = GetComponent<PlayerSFX>();
            PlayerMovement = GetComponent<PlayerMovement>();
            AudioSource = GetComponent<AudioSource>();
            Rigidbody = GetComponent<Rigidbody>();
        }
    }
}
