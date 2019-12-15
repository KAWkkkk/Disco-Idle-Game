using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Visitor : MonoBehaviour
{
    private enum States
    {
        Leaving,
        Dancing,
        ChoosingDestination,
    }

    [SerializeField] private Transform destination;

    private NavMeshAgent navMeshAgent;

    [SerializeField] private Transform[] destinationChoices;

    [SerializeField] private float timeBetweenDestinationChange = 60f;

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


        InvokeRepeating("ChooseDestination", 1f, timeBetweenDestinationChange);

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
