using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class psuh2 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool check;
    NavMeshAgent agent;
    NavMeshObstacle obstacle;
    public Transform destination;
    // Update is called once per frame
    private float a = 0f;
    
    void OnTriggerEnter(Collider col)
    {
        a += 1;
        if (a > 0)
        {
            agent = col.GetComponent<NavMeshAgent>();
            agent.isStopped = true;   

        }
       
                
    }
    void OnTriggerExit(Collider col)
    {
        agent = col.GetComponent<NavMeshAgent>();
        agent.isStopped = false;   
                
    }
}
