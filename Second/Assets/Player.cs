using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Start()
    {

    }
        float h = 0;
        float v = 0;

    void Update()
    {
        //float v = Input.GetAxis("Vertical"); // w : 1, s : -1, 누르지않으면 0
        //float h = Input.GetAxis("Horizontal");

        bool isKeyDown = Input.GetKeyDown(KeyCode.A);

        if (isKeyDown == true)
        {
            h = -1;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            h = 1;
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D)) 
        {
            h = 0;
        }





        //만약에 d키를 누르면 hfmf 1 

        // 키보드 w, s, 입력을 받아서 위아래로 움직이기
        //(0,1,0)
        Vector3 dir = GetDir(v,h);
        //위아래로 이동

        transform.position += dir * 5 * Time.deltaTime; ;
        //transform.Translate(Vector3.right * 5 * Time.deltaTime,);
        // P = P0 + vt
        //transform.position += transform.right * 5 * Time.deltaTime;
        //Vector3 이면 Space.world, transform.right이면 Space.self
    }

    Vector3 GetDir(float v, float h)
    {
        Vector3 dirV = Vector3.forward * v;
        Vector3 dirH = Vector3.right * h;
        Vector3 dir = dirV + dirH;

        return dir;
    }


    //오른쪽으로 이동
}
