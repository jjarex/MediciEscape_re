using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpider : MonoBehaviour
{
    public float dropSpeed=10;
    public GameObject spiderObj;
    void Start()
    {
        
    }
    void Update()
    {
        Vector3 dir;
        float xx = Random.Range(-70, 60);
        float zz=Random.Range(-30,30);

        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            spiderObj.gameObject.GetComponent<Rigidbody>().useGravity = true;
            //transform.Translate(Vector3.down*dropSpeed*Time.deltaTime);
        }
    }
}
