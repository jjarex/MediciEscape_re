using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPeekabooManager : MonoBehaviour
{
    public GameObject peekabooEnemy;
    public float createTime = 120;
    public GameObject player;
    AudioSource gigglingSFX;
    void Start()
    {
        GameObject enemy = Instantiate(peekabooEnemy); //테스트
        //StartCoroutine("ieCreateEnemy");
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
            Ray ray = new Ray(transform.position, -transform.forward);


        }
    }
}
