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
        //gigglingSFX = GetComponent<AudioSource>();
        //GameObject enemySample = Instantiate(peekabooEnemy);
        //agentSample = enemySample.GetComponent<NavMeshAgent>();
        //agentSample.destination = player.transform.position;
        GameObject enemy = Instantiate(peekabooEnemy);
        agent = enemy.GetComponent<NavMeshAgent>();
        float px = player.transform.position.x;
        float py = player.transform.position.y;
        float pz = player.transform.position.z;
        enemy.transform.position = /*new Vector3(px, 12, pz - 0.1f)*/player.transform.position;
        agent.destination = player.transform.position;
    }

    void Update()
    {
        //enemy.transform.parent = playerHand.transform;
        //StartCoroutine("ieCreateEnemy");
    }
    IEnumerator ieCreateEnemy()
    {
        gigglingSFX.Play();
        GameObject enemy = Instantiate(peekabooEnemy);
        agent = enemy.GetComponent<NavMeshAgent>();
        //enemy.transform.parent = playerHand.transform;
        float px = player.transform.position.x;
        float py = player.transform.position.y;
        float pz = player.transform.position.z;
        enemy.transform.position =new Vector3(px,py,pz-1.5f);
        agent.destination = player.transform.position;
        yield return new WaitForSeconds(createTime);
    }
}
