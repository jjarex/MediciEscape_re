using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpiderObj : MonoBehaviour
{
    public bool trap;
    public float dropSpeed=0.1f;
    // Start is called before the first frame update
    void Start()
    {
        trap = false;  
    }

    // Update is called once per frame
    void Update()
    {
        if (trap == true)
        {
            float x = transform.position.x;
            float z = transform.position.z;
            Vector3 bottom = new Vector3(x, 0, z);
            transform.position = Vector3.MoveTowards(transform.position, bottom, dropSpeed);
            transform.eulerAngles=new Vector3(0,90,0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<PlayerMove>().ChangState(2);
        }
    }
}
