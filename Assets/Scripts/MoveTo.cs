﻿// MoveTo.cs
using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    Animator anim;
    NavMeshAgent agent;

    Vector3 viewPoint;
    Vector3 direction;
    Quaternion rotation;

    float stopDistance;

    void Awake()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        if (agent == null)
        {
            agent = this.gameObject.AddComponent<NavMeshAgent>();
            agent.speed = 0.2f;
        }

        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
    }

    private void Update()
    {
        viewPoint = Camera.main.transform.position;
        viewPoint.y = transform.position.y;
        agent.destination = viewPoint;

        anim.SetFloat("Speed", agent.speed);

        stopDistance = Mathf.Round(Vector3.Distance(viewPoint, transform.position) * 10) / 10;

        if (stopDistance < 0.3f)
        {
            agent.speed = 0;
            //agent.acceleration = float.MaxValue;
            //agent.velocity = Vector3.zero;
            //agent.isStopped = true;


            //agent.enabled = false;
            //GetComponent<Rigidbody>().mass = 10;
            //GetComponent<Rigidbody>().AddForce(transform.up * 0.3f, ForceMode.Impulse);
        }
        else 
        {
            agent.speed = 0.2f;
        }

        //if (GameObject.Find("Informations").GetComponent<SaveInformations>().developerMode)
        //{
        //    Debug.DrawRay(transform.position, Vector3.up * 0.5f, Color.blue, float.MinValue);
        //}

        direction = (viewPoint - transform.position).normalized;
        rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;
    }
}