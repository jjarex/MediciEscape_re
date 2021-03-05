﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyFactory;
    public Transform otherPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.transform.parent.gameObject);
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = otherPoint.position;
            //enemy.GetComponent<Enemy>().enabled=true;
            //enemy.GetComponent<NavMeshAgent>().enabled=true;
        }
    }
}
