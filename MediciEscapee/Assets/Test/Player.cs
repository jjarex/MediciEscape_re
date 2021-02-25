using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform startPoint;
    void Start()
    {

    }
    void Update()
    {

    }
    internal void Ready()
    {
        //SFX
        Invoke("StartPoint",5);
    }
    void StartPoint()
    {
        transform.position = startPoint.position;
    }
}
