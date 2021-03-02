using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPeekabooo : MonoBehaviour
{
    public GameObject cam;
    public GameObject player;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        transform.position = cam.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = player.transform.position;
        
    }
    void CreateE()
    {
        Ray ray = new Ray(cam.transform.position,cam.transform.forward);

    }
}
