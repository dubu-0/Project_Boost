using Enums;
using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    { 
        [SerializeField] private float rotationSpeed = 150f;
        [SerializeField] private float boostSpeed = 3750f;

        private const string Jump = nameof(Jump);
        private const string Horizontal = nameof(Horizontal);

        private void Update()
        {
            RotateHorizontally();
            Boost();
        }

        private void RotateHorizontally()
        {
            UseManualRotationOnly(GetRotationSpeed() != 0);
        
            if (GetRotationSpeed() != 0)
            {
                transform.Rotate(Vector3.forward * GetRotationSpeed() * Time.deltaTime);
            }
        }

        private void Boost()
        {
            PlayerCachedComponents.Rigidbody.AddRelativeForce(Vector3.up * GetBoostSpeed() * Time.deltaTime);
            PlayerCachedComponents.PlayerVFX.PlayEffect(ParticleEffect.Jet, GetBoostSpeed() > 0);
            PlayerCachedComponents.PlayerSFX.ChangeEngineVolume(GetBoostSpeed());
        }

        private float GetRotationSpeed() => rotationSpeed * Input.GetAxis(Horizontal);
        private float GetBoostSpeed() => boostSpeed * Input.GetAxis(Jump);
        private void UseManualRotationOnly(bool b) => PlayerCachedComponents.Rigidbody.freezeRotation = b;
    }
}
