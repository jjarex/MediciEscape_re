using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitManager : MonoBehaviour
{
    public static HitManager instance;
    private void Awake()
    {
        instance = this;
    }

    public GameObject hitImage;
    // Start is called before the first frame update
    void Start()
    {
        //태어날 때 Hit이미지를 비활성 하고싶다.
        hitImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoHit()
    {
        StopCoroutine("ieHit");
        StartCoroutine("ieHit");
    }

    IEnumerator ieHit()
    {
        // 1. hitImage를 보이게하고싶다.
        hitImage.SetActive(true);
        // 2. 잠시 0.1초 기다렸다가
        yield return new WaitForSeconds(0.1f);
        // 3. hitImage를 안 보이게 하고싶다.
        hitImage.SetActive(false);
    }
}
