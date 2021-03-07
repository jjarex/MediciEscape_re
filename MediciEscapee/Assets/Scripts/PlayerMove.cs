using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PlayerMove : MonoBehaviour
{
    public SteamVR_Action_Vector2 move;
    public float speed = 5;
    public bool catched;
    public GameObject gameOverUI;
    public GameObject lightMain;
    public enum State
    {
            Move,
            Catched,
            Die
    }
    public State state;

    public void ChangState(int index)
    {
        state = (State)index;
    }

    void Start()
    {
        catched = false;
        gameOverUI.SetActive(false);
    }

    void Update()
    {
        switch (state)
        {
            case State.Move:
                UpdateMove();break;
            case State.Catched:
                UpdateCatched();break;
            case State.Die:
                UpdateDie(); break;
        }
        if (Timer.instance.hour == 12)
        {
            state = State.Die;
        }
    }

    private void UpdateDie()
    {
        gameOverUI.SetActive(true);
        lightMain.GetComponent<Light>().color = Color.red;
    }

    private void UpdateCatched()
    {
        //데미지 UI
        lightMain.GetComponent<Light>().color = Color.red;
        Invoke("UpdateMove", 3);
    }
    private void UpdateMove()
    {
        state = State.Move;
        Vector2 dir2 = move.GetAxis(SteamVR_Input_Sources.LeftHand);
        //print(dir2);
        float movex = dir2.x;
        float movey = dir2.y;
        Vector3 dir3 = new Vector3(movex, 0, movey);
        dir3 = Camera.main.transform.TransformDirection(dir3);
        dir3.y = 0;
        transform.position += dir3 * Time.deltaTime * speed;
    }
}
