using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpinComponent : MonoBehaviour
{
    [SerializeField] private float spinSpeed;
    
    private void Update()
    {
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
    }
}
