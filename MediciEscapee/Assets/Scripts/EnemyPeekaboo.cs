using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPeekaboo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //에님&피카부에너미 디스트로이
        }
    }
}
