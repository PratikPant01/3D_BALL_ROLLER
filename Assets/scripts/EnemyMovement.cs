using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform Player;//player postion 
    public NavMeshAgent navMeshAgent;//for accessing the nav meanh agent 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        navMeshAgent=GetComponent<NavMeshAgent>();//find the agent
    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        
        {
            navMeshAgent.SetDestination(Player.position);//check the null and updates the postion
        }

    }
}
