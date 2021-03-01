using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPeekabooManager : MonoBehaviour
{
    public GameObject peekabooEnemy;
    NavMeshAgent agent;
    NavMeshAgent agentSample;
    public float createTime = 120;
    public GameObject player;
    AudioSource gigglingSFX;
    void Start()
    {
        gigglingSFX = GetComponent<AudioSource>();
        GameObject enemySample = Instantiate(peekabooEnemy);
        agentSample = enemySample.GetComponent<NavMeshAgent>();
        agentSample.destination = player.transform.position;
    }

    void Update()
    {

        StartCoroutine("ieCreateEnemy");
    }
    IEnumerator ieCreateEnemy()
    {
        gigglingSFX.Play();
        GameObject enemy = Instantiate(peekabooEnemy);
        agent = enemy.GetComponent<NavMeshAgent>();
        //enemy.transform.parent = playerHand.transform;
        enemy.transform.position = player.transform.position;
        agent.destination = player.transform.position;
        yield return new WaitForSeconds(createTime);
    }
}
