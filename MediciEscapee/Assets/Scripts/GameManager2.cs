using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class GameManager2 : MonoBehaviour
{
    public SteamVR_Action_Boolean menu;
    public GameObject gameMenuUI;
    bool on;
    void Start()
    {
        on = false;
    }

    void Update()
    {
        if (on)
            gameMenuUI.SetActive(true);
        else
            gameMenuUI.SetActive(false);
        if (menu.GetStateDown(SteamVR_Input_Sources.RightHand) || menu.GetStateDown(SteamVR_Input_Sources.LeftHand))
            on = !on;
    }
}
