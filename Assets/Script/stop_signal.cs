using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class stop_signal : MonoBehaviour
{
    // Start is called before the first frame update
    NavMeshAgent agent;
    public static bool stop;
    public float kec;
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        kec = agent.velocity.magnitude;
        if (kec == 0)
        {
            stop = true;
        }
    }

}
