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
        GameObject enemy = Instantiate(peekabooEnemy);
        
    }

    void Update()
    {
        StartCoroutine("ieCreateEnemy");
    }
    IEnumerator ieCreateEnemy()
    {
        gigglingSFX.Play();
        GameObject enemy = Instantiate(peekabooEnemy);
        yield return new WaitForSeconds(createTime);
    }
}
