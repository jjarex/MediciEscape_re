using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirenzeLight : MonoBehaviour
{
    public GameObject dLight;
    public GameObject spotLight;
    public bool trigger;
    bool isOn;
    // Start is called before the first frame update
    void Start()
    {
        dLight.SetActive(false);
        spotLight.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //if (trigger)
        //{
        //    dLight.SetActive(true);
        //    spotLight.SetActive(false);
        //}
        //else
        //{
        //    dLight.SetActive(false);
        //    spotLight.SetActive(true);
        //}
    }
    private void OnTriggerEnter(Collider other)
    {
        isOn = !isOn;
        if (other != null)
        {
            if (isOn)
            {
                dLight.SetActive(true);
                spotLight.SetActive(false);
            }
            if (!isOn)
            {
                dLight.SetActive(false);
                spotLight.SetActive(true);
            }
        }
    }
}
