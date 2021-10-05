using Enums;
using UnityEngine;

namespace Player
{
    public class PlayerVFX : MonoBehaviour
    {
        [SerializeField] private ParticleSystem explosion;
        [SerializeField] private ParticleSystem success;
        [SerializeField] private ParticleSystem jet;

        private ParticleSystem[] _particleSystems;

        private void Start() => _particleSystems = new[] { explosion, success, jet };
        public void PlayEffect(ParticleEffect effect, bool play)
        {
            if (play && !_particleSystems[(int) effect].isPlaying)
                _particleSystems[(int) effect].Play();
            else if (!play)
                _particleSystems[(int) effect].Stop();
        }
    }
}
