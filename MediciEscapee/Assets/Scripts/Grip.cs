using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. 만약 마우스 왼쪽 버튼을 누르면
        if (Input.GetButtonDown("Fire1"))
        {
            // 2. 내 반경 1M안의 충돌체 목록을 출력하고싶다.
            Collider[] 충돌한목록 = Physics.OverlapSphere(transform.position, 1f);
            for (int i = 0; i < 충돌한목록.Length; i++)
            {
                print(충돌한목록[i].gameObject.name);
                if (충돌한목록[i].gameObject.name.Contains("SM_Prop_Chair_BeanBag_02"))
                {
                    Destroy(충돌한목록[i].gameObject);
                }
            }
        }
    }
}
