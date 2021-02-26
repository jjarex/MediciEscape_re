using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    public enum State
    {
        Search,
        Move,
        Test,
        Happy
    }    
    public State state;

    void Update()
    {
        switch (state)
        {
            case State.Search:
                UpdateSearch();break;
            case State.Move:
                UpdateMove();break; 
            case State.Test:
                UpdateTest();break;
            case State.Happy:
                UpdateHappy();break;
        }
    }

    private void UpdateSearch()
    {
    }

    private void UpdateMove()
    {
    }

    private void UpdateTest()
    {
    }

    private void UpdateHappy()
    {
        Timer.instance.currentTime +=30;
    }
}
