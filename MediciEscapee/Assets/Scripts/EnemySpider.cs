using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpider : MonoBehaviour
{
    //public float dropSpeed=100;
    public GameObject spiderObj;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            spiderObj.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
