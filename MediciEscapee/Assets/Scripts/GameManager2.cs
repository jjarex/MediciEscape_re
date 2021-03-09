using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class GameManager2 : MonoBehaviour
{
    public float playerSpeed;
    GameObject lightMain;
    public bool mainLight;
    public float patrolEnemySpeed;
    public float patrolEnemyChaseSpeed;
    public float spiderEnemySpeed;
    public float peekabooEnemyCreateTime;
    void Start()
    {
        playerSpeed = PlayerMove.instance.speed;
        patrolEnemySpeed = Enemy.instance.speed;
        patrolEnemyChaseSpeed = Enemy.instance.chaseSpeed;
        spiderEnemySpeed = EnemySpider.instance.speed;
        peekabooEnemyCreateTime = EnemyPeekabooManager.instanse.createTime;
    }
    void Update()
    {
        if (mainLight == false)
            lightMain.GetComponent<Light>().enabled = false;
        else
            lightMain.GetComponent<Light>().enabled = true;
    }
    //public SteamVR_Action_Boolean menu;
    //public GameObject gameMenuUI;
    //bool on;
    //void Start()
    //{
    //    on = false;
    //}

    //void Update()
    //{
    //    if (on)
    //        gameMenuUI.SetActive(true);
    //    else
    //        gameMenuUI.SetActive(false);
    //    if (menu.GetStateDown(SteamVR_Input_Sources.RightHand) || menu.GetStateDown(SteamVR_Input_Sources.LeftHand))
    //        on = !on;
    //}
}
