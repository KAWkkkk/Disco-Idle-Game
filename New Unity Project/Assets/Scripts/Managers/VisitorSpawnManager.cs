using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorSpawnManager : MonoBehaviour
{
    public Transform spawnPoint;

    public GameObject visitor;

    public float timeBetweenSpawns = 8f;
    private float countdown;

    void Start()
    {
        
    }

    void Update()
    {
        if (countdown <= 0f)
        {
            SpawnVisitor();
            countdown = timeBetweenSpawns;
        }

        countdown -= Time.deltaTime;
    }

    public void SpawnVisitor() 
    {
        Instantiate(visitor, spawnPoint.position, Quaternion.identity);
    }
}
