using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class Flashlight : MonoBehaviour
{
    //public SteamVR_Action_Boolean grip;
    public SteamVR_Action_Boolean teleport;

    public GameObject[] lights;
    public bool on;
    void Start()
    {
        on = false;
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].SetActive(false);
        }
    }
    private void Update()
    {
        if (teleport.GetStateDown(SteamVR_Input_Sources.RightHand))
        {
            On();
        }

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
        void On()
        {
            on = !on;
        }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        if (grip.GetStateDown(SteamVR_Input_Sources.RightHand))
    //        {
    //            transform.parent = other.transform;
    //            //transform.position = new Vector3(,,);
    //            if (teleport.GetStateDown(SteamVR_Input_Sources.RightHand))
    //            {
    //                On();
    //            }
    //        }
    //        if (grip.GetStateDown(SteamVR_Input_Sources.LeftHand))
    //        {
    //            transform.parent = other.transform;
    //            //transform.position = new Vector3(,,);
    //            if (teleport.GetStateDown(SteamVR_Input_Sources.LeftHand))
    //            {
    //                On();
    //            }
    //        }
    //    }
}
