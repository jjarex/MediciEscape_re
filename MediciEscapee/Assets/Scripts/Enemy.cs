using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    NavMeshAgent agent;
    Animator anim;
    public GameObject player;
    public Transform destinaion;
    public float speed = 3;
    public float chaseSpeed = 100;
    public static Enemy instance;
    private void Awake()
    {
        instance=this;
    }
    public enum State
    {
        Patrol,
        Chase,
        Catch,
        GoHome
    }
    public State state;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        state = State.Patrol;
        player = GameObject.Find("Player");
    }

    void Update()
    {
        switch (state)
        {
            case State.Patrol:
                UpdatePatrol(); break;
            case State.Chase:
                UpdateChase(); break;
            case State.Catch:
                UpdateCatch(); break;
            case State.GoHome:
                GoHome(); break;
        }
        //if (state == State.Quiz)
        //    Timer.instance.pause = true;
        //else
        //    Timer.instance.pause = false;
    }

    private void UpdateGoHome()
    {
        
    }

    private void UpdatePatrol()
    {
        agent.destination = destinaion.transform.position;
        agent.speed = speed;
        anim.SetTrigger("Walk");

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = State.Chase;
        }

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
        anim.SetTrigger("Run");

        float distance = Vector3.Distance(transform.position, player.transform.position);
        //Debug.Log(distance);
        if (distance <= 1.5f)
        {
            state = State.Catch;
        }
    }
    private void UpdateCatch()
    {
        anim.SetTrigger("Attack");
        player.GetComponent<PlayerMove>().ChangState(2);
        Timer.instance.currentTime -= 30;
        StartCoroutine(ieGoHome());
    }
    IEnumerator ieGoHome()
    {
        yield return new WaitForSeconds(3);
        state = State.GoHome;
    }
    void GoHome()
    {
        //state = State.GoHome;
        agent.destination = destinaion.transform.position;
        agent.speed = speed;
        anim.SetTrigger("walk");
    }

    //private void UpdateHappy()
    //{
    //    Timer.instance.currentTime += 30;

    //    Destroy(gameObject, 5);
    //}
}
