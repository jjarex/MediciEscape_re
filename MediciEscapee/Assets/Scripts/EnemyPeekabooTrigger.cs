using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPeekabooTrigger : MonoBehaviour
{
    public GameObject peekabooEnemy;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //에님&피카부에너미 디스트로이
            Destroy(peekabooEnemy.gameObject, 2);
        }
    }
    
}
