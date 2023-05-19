using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    NavMeshAgent agent;

    private Animator animator;



    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                agent.destination = hit.point;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.animator.SetTrigger("Attack 01");
        }
        if (Input.GetMouseButton(1))
        {
            this.animator.SetTrigger("Defend");
        }
    }
    private void Awake()
    {
        animator = GetComponent<Animator>();

    }
}