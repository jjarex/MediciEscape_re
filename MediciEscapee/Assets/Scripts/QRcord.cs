using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QRcord : MonoBehaviour
{
    public static QRcord instance;
    private void Awake()
    {
        instance = this;
        
    }

    public GameObject[] qrCord;

    public void FindQRCord(int index)
    {
        qrCord[index].SetActive(true);

        // 다 켜졌는지 체크해서 
        bool isComplete = true;
        for (int i = 0; i < qrCord.Length; i++)
        {
            if (qrCord[i].activeSelf == false)
            {
                // 실패
                isComplete = false;
            }
        }

        if (isComplete)
        {
            // 다 켜졌으면 어쩌고 저쩌고
            print("성공~!!!");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < qrCord.Length; i++)
        {
            qrCord[i].SetActive(false);
        }
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
