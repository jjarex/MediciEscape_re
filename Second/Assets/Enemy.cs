using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//타겟(플레이어)를 계속 따라다니게 하고 싶다.
//1. 타겟을 향하는 방향을 구하고
//2. 그 방향을 움직이고 싶다.
public class Enemy : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //1.타겟을 향하는 방향을 구하고
        Vector3 dir = target.position - transform.position;
        dir.Normalize();

        //2.그 방향을 움직이고 싶다.
        transform.position += dir * 4 * Time.deltaTime;
    }
}
