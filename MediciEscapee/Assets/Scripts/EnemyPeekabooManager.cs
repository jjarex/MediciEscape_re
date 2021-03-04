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
        StartCoroutine("ieCreateEnemy");
    }

    void Update()
    {
        
    }
    IEnumerator ieCreateEnemy()
    {
        while (true)
        {
            //gigglingSFX.Play();
            yield return new WaitForSeconds(createTime);
            GameObject enemy = Instantiate(peekabooEnemy);
        }
    }
}
