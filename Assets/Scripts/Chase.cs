using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

    public class Chase : MonoBehaviour
    {
        // MoveTo.cs

        public Transform[] goals;
        private NavMeshAgent agent;

        void Start()
        {
            agent = GetComponent<NavMeshAgent>();

        }
        // Update is called once per frame
        void Update()
        {
            for (int i = 0; i < goals.Length; i++)
            {
            agent.SetDestination(goals[i].position);
            }
        }
    }