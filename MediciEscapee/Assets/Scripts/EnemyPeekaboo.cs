using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPeekaboo : MonoBehaviour
{
    public GameObject player;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        transform.position = Camera.main.transform.position;
    }

    void Update()
    {
        agent.destination = Camera.main.transform.position;
    }
}
