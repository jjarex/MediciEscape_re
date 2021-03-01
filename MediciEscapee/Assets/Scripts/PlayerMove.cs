using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PlayerMove : MonoBehaviour
{
    public SteamVR_Action_Vector2 move;
    public float speed = 5;
    State state;
    public bool catched;
    public enum State
    {
        Move,
        Quiz
    }
    void Start()
    {
        state = State.Move;
        catched = false;
    }

    void Update()
    {
        switch (state)
        {
            case State.Move:
                UpdateMove(); break; 
            case State.Quiz:
                UpdateQuiz(); break;
        }
        if (catched)
        {
            state = State.Quiz;
        }
    }

    private void UpdateQuiz()
    {
        //Quiz UI
    }

    private void UpdateMove()
    {
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
