using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPeekabooTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //에님
            Destroy(transform.parent, 2);
        }
    }

}
