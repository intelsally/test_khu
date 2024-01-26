using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Npc : MonoBehaviour {
    private NavMeshAgent _agent;
    public Transform target1;
    public Transform target2;
    private Vector3 _currentTargetPosition;
    private int _currentTargetIndex;
    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }


    // Start is called before the first frame update
    void Start()
    {
        _currentTargetPosition = target1.position;
        _currentTargetIndex = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if ( _currentTargetIndex == 1)
        {
            _currentTargetPosition = target1.position;
            if (Vector3.Distance(_currentTargetPosition, transform.position) < 0.75f)
                _currentTargetIndex = 2;

        }
        else if (_currentTargetIndex == 2)
        {
            _currentTargetPosition = target2.position;
            
            if (Vector3.Distance(_currentTargetPosition, transform.position) < 0.75f)
            {
                _currentTargetIndex = 1;
            }
        }
        _agent.destination = _currentTargetPosition;
    }
}
