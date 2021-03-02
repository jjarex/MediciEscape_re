using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject player;
    public Transform destinaion;
    public float chaseSpeed=100;
    public enum State
    {
        Patrol,
        Chase,
        Quiz,
        Happy
    }
    public State state;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        state = State.Patrol;
    }

    void Update()
    {
        switch (state)
        {
            case State.Patrol:
                UpdatePatrol(); break;
            case State.Chase:
                UpdateChase(); break;
            case State.Quiz:
                UpdateQuiz(); break;
            case State.Happy:
                UpdateHappy(); break;
        }
        if (state == State.Quiz)
            Timer.instance.pause = true;
        else
            Timer.instance.pause = false;
    }

    private void UpdatePatrol()
    {
        agent.destination = destinaion.transform.position;
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitinfo;
        if (Physics.Raycast(ray, out hitinfo))
        {
            if (hitinfo.transform.CompareTag("Player"))
            {
                state = State.Chase;
            }
        }
    }

    private void UpdateChase()
    {
        agent.destination = player.transform.position;
        agent.speed *= chaseSpeed;

        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance<=agent.stoppingDistance)
        {
            state = State.Quiz;
        }
    }

    private void UpdateQuiz()
    {
        player.GetComponent<PlayerMove>().catched = true;
        if (player.GetComponent<PlayerMove>().quiz)
        {
            state = State.Happy;
        }
        else
        {
            //플레이어 게임오버
        }
    }

    private void UpdateHappy()
    {
        Timer.instance.currentTime += 30;

        Destroy(gameObject, 5);
    }
}
