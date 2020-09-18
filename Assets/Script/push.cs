using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class push : MonoBehaviour
{
    // Start is called before the first frame update
    public bool check = false;
    NavMeshAgent agent;
    NavMeshObstacle obstacle;
    
    // Update is called once per frame
    void Awake() {
        //agent = GetComponentInParent<NavMeshAgent>();
    }
    void Update()
    {
        // 
        // if (check)
        // {            
        //     agent.isStopped = true;

        // }
        // else
        // {
        //     agent.isStopped = false;
        // }
        // //agent = this.GetComponent<NavMeshAgent>();
    }
    
    void OnTriggerEnter()
    {
        agent = GetComponentInParent<NavMeshAgent>();
        check = true;
        agent.isStopped = true;
                
    }
    void OnTriggerExit()
    {
        agent = GetComponentInParent<NavMeshAgent>();
        check = false;  
        agent.isStopped = false;   
                
    }
    // void OnTriggerStay() {
    //     //agent = GetComponentInParent<NavMeshAgent>();
    //     check = true;
    //     agent.isStopped = true;  
    // }
    
}

