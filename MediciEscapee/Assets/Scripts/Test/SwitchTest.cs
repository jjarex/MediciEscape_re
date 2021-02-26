using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTest : MonoBehaviour
{
    public GameObject mainLight;
    public GameObject spotLight;
    bool isOn;
    void Start()
    {
        isOn = false;
        spotLight.SetActive(true);
        mainLight.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        isOn = true;
        if (isOn)
        {
            isOn = !isOn;
            spotLight.SetActive(false);
            mainLight.SetActive(true);
        }
    }
}
