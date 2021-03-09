using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text hourMin;
    public Text second;
    public float startTime = 55;
    public float currentTime;
    public bool pause;
    public int hour;
    public  GameObject gameoverUI;

    public static Timer instance;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        currentTime = startTime * 60;
        pause = false;
        gameoverUI.SetActive(false);

    }
    void Update()
    {
        if (pause == false)
            currentTime += Time.deltaTime;
        hour = 11;
        int min = (int)(currentTime / 60);
        if (min == 0)
            hour++;
        int sec = (int)(currentTime % 60);

        if (min < 10)
            hourMin.text = hour + ":0" + min;
        else
            hourMin.text = hour + ":" + min;

        if (sec < 10)
            second.text = ".0" + sec;
        else
            second.text = "." + sec;

        if (hour >= 12)
        {
            gameoverUI.SetActive(true);
            //GAMEOVER
        }

        

        //Test();
    }

    //private void Test()
    //{
    //    if (Input.GetKeyDown(KeyCode.Alpha1))
    //    {
    //        QRcord.instance.FindQRCord(0);
    //    }
    //    if (Input.GetKeyDown(KeyCode.Alpha2))
    //    {
    //        QRcord.instance.FindQRCord(1);
    //    }
    //    if (Input.GetKeyDown(KeyCode.Alpha3))
    //    {
    //        QRcord.instance.FindQRCord(2);
    //    }
    //    if (Input.GetKeyDown(KeyCode.Alpha4))
    //    {
    //        QRcord.instance.FindQRCord(3);
    //    }
    //    if (Input.GetKeyDown(KeyCode.Alpha5))
    //    {
    //        QRcord.instance.FindQRCord(4);
    //    }
    //}
}
