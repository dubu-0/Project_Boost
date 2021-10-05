using System;
using Enums;
using UnityEngine;

namespace Player
{
    public class PlayerSFX : MonoBehaviour
    {
        [SerializeField] private AudioClip explosion;
        [SerializeField] private AudioClip success;

        private AudioClip[] _sounds;

        private void Start() => _sounds = new[] { explosion, success };
        public void MuteEngine(bool mute) => PlayerCachedComponents.AudioSource.mute = mute;
        public void PlaySound(Sound sound) => AudioSource.PlayClipAtPoint(_sounds[(int) sound], transform.position);
    }
}
