using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpiderObj : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            //플레이어 게임오버&에님
        }
    }
}
