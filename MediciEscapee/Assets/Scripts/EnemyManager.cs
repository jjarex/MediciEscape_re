using System.Collections;
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
            Destroy(other.gameObject);
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = otherPoint.position;
            //enemy.GetComponents<Enemy>();
            //enemy.GetComponents<NavMeshAgent>();
        }
    }
}
