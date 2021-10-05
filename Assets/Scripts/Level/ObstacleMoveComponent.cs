using UnityEngine;

namespace Level
{
    public class ObstacleMoveComponent : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 1f;
        [SerializeField] private Vector3 localTarget;

        private Vector3 _startingPosition;
        
        private void Start()
        {
            _startingPosition = transform.position;
        }

        private void Update()
        {
            transform.position = _startingPosition + CalculateOffset();
        }
        
        private Vector3 CalculateOffset() => localTarget * CalculateOffsetFactor();
        
        // Value between 0 and 1
        private float CalculateOffsetFactor() => (Mathf.Sin(Time.time * moveSpeed) + 1) / 2;
    }
}
