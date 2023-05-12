using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

    public class Chase : MonoBehaviour
    {
        // MoveTo.cs

        public Transform[] goals;
        private NavMeshAgent agent;

        private int i = 0;
        private int goalCounter;
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            goalCounter = goals.Length;

        }
    // Update is called once per frame
    void Update()
    {

        if (agent.pathStatus == NavMeshPathStatus.PathComplete && agent.remainingDistance < 0.5)
        {
            agent.SetDestination(goals[i].position);
            i++;
            if(i == goalCounter)
            {
                i = 0;
            }
        }

    }
    }