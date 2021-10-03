using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    { 
        [SerializeField] private float rotationSpeed = 150f;
        [SerializeField] private float boostSpeed = 3750f;

        private const string Jump = nameof(Jump);
        private const string Horizontal = nameof(Horizontal);

        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

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
            if (GetBoostSpeed() > 0) 
                _rigidbody.AddRelativeForce(Vector3.up * GetBoostSpeed() * Time.deltaTime);
        
            PlayerCachedComponents.PlayerSFX.MuteEngine(GetBoostSpeed() <= 0);
        }

        private float GetRotationSpeed() => rotationSpeed * Input.GetAxis(Horizontal);
        private float GetBoostSpeed() => boostSpeed * Input.GetAxis(Jump);
        private void UseManualRotationOnly(bool b) => _rigidbody.freezeRotation = b;
    }
}
