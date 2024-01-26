using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rabbit : MonoBehaviour
{
    public Transform playertarget;
    public float avoidDistance = 5f;
    private UnityEngine.AI.NavMeshAgent _agent;

    private void Awake()
    {
        _agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Vector3.Distance(playertarget.position, transform.position) < avoidDistance)
        {

        }
    }
}
