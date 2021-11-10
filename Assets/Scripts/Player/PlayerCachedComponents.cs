using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(BoxCollider))]
    [RequireComponent(typeof(PlayerVFX))]
    [RequireComponent(typeof(PlayerSFX))]
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(AudioSource))]
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerCachedComponents : MonoBehaviour
    {
        private PlayerCachedComponents() { }
        
        public static Rigidbody Rigidbody { get; private set; }
        public static AudioSource AudioSource { get; private set; }
        public static PlayerMovement PlayerMovement { get; private set; }
        public static PlayerSFX PlayerSFX { get; private set; }
        public static PlayerVFX PlayerVFX { get; private set; }
        public static BoxCollider BoxCollider { get; private set; }

        private void Awake()
        {
            BoxCollider = GetComponent<BoxCollider>();
            PlayerSFX = GetComponent<PlayerSFX>();
            PlayerVFX = GetComponent<PlayerVFX>();
            PlayerMovement = GetComponent<PlayerMovement>();
            AudioSource = GetComponent<AudioSource>();
            Rigidbody = GetComponent<Rigidbody>();
        }
    }
}
