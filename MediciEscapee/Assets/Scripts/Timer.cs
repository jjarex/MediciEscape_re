using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Timer instance;
    private void Awake()
    {
        instance = this;
    }
    public float totalTime = 3;
    public float currentTime;
    float GameTime
    {
        get { return currentTime; }
        set
        {
            currentTime = value;
            int min = (int)(currentTime / 60);
            int sec = (int)((currentTime % 60));
        }
    }
    void Start()
    {
        currentTime = totalTime;
        currentTime *= 60;
    }
    void Update()
    {
        GameTime -= Time.deltaTime;
    }
}
