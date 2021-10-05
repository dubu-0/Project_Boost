using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoveComponent : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private List<Transform> waypoints;

    private LinkedList<Transform> _wayPoints;
    private LinkedListNode<Transform> _nextWaypoint;
    
    private void Start()
    {
        _wayPoints = new LinkedList<Transform>(waypoints);
        SetNextWaypoint();
    }

    private void Update()
    {
        MoveToNextWaypoint();

        if (IsObstacleInWaypoint())
            SetNextWaypoint();
    }

    private void MoveToNextWaypoint() =>
        transform.position = Vector3.MoveTowards(transform.position, _nextWaypoint.Value.position, 
            moveSpeed * Time.deltaTime);

    private void SetNextWaypoint()
    {
        if (_nextWaypoint == null | _nextWaypoint == _wayPoints.Last)
            _nextWaypoint = _wayPoints.First;
        else
            _nextWaypoint = _nextWaypoint.Next;
    }

    private bool IsObstacleInWaypoint()
    {
        var distance = Vector3.Distance(transform.position, _nextWaypoint.Value.position);
        return distance < 0.1f;
    }
}
