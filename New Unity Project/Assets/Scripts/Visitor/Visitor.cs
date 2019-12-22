using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Visitor : MonoBehaviour
{
    public enum States
    {
        Idle,
        ChoosingDestination,
        Leaving,
    }
    public enum Actions
    {
        Dancing,
        AtTheBar,
    }

    [SerializeField]
    private Transform destination;

    NavMeshAgent navMeshAgent;

    private void Awake()
    {
        destination = GameObject.FindGameObjectWithTag("Destination").transform;
    }

    void Start()
    {
        navMeshAgent = this.GetComponent<NavMeshAgent>();

        if (!navMeshAgent)
        {
            Debug.Log("NavMeshAgent not added to" + gameObject.name);
        }
        else
        {
            SetDestination();
        }
        destination = GameObject.FindGameObjectWithTag("Destination").transform;

    }


    void Update()
    {
        
    }

    void SetDestination()
    {
        if (destination)
        {
            Vector3 targetDestination = destination.transform.position;
            navMeshAgent.SetDestination(targetDestination);
        }
    }
}
