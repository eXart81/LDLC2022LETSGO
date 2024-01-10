using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private GameObject player;

    private Vector3 targetPos;

    private NavMeshAgent agent;

    private Rigidbody rb;

    public float ratio;

    private Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        var position = player.transform.position;
        targetPos = position - (position - agent.destination).normalized * 2.5f;
        agent.destination = targetPos;

        if (ratio > 0f)
        {
            ratio -= Time.deltaTime;
            transform.position -= dir * 50 * ratio * Time.deltaTime;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(targetPos, 0.5f);
    }

    public void Throwback(Vector3 transformPosition)
    {
        Debug.Log("lol");
        var position = transform.position;
        dir = ((transformPosition - position) + Vector3.up * -5f).normalized;
        ratio = 0.5f;
    }
}
