using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class Flashlight : MonoBehaviour
{
    public SteamVR_Action_Boolean grip;
    public SteamVR_Action_Boolean teleport;

    public GameObject[] lights;
    bool on;
    void Start()
    {
        on = false;
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
                if (teleport.GetStateDown(SteamVR_Input_Sources.RightHand))
                {
                    On();
                }
            if (grip.GetState(SteamVR_Input_Sources.RightHand))
            {
                transform.parent = other.transform;
                //transform.position = new Vector3(,,);
            }
            if (grip.GetActive(SteamVR_Input_Sources.LeftHand))
            {
                transform.parent = other.transform;
                //transform.position = new Vector3(,,);
                if (teleport.GetActive(SteamVR_Input_Sources.LeftHand))
                {
                    On();
                }
            }
        }
    }
    void On()
    {
        on = !on;
        if (on)
        {
            for (int i = 0; i < lights.Length; i++)
            {
                lights[i].SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < lights.Length; i++)
            {
                lights[i].SetActive(false);
            }
        }
    }
}
