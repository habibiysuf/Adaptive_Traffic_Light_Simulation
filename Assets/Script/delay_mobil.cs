using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class delay_mobil : MonoBehaviour
{
    private NavMeshAgent agent;
    private float kecepatan_agen;
    public float waktu_delay_agen;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other) 
    {
        if (other.gameObject.tag == "delay")
        {
            agent = this.GetComponent<NavMeshAgent>();
            kecepatan_agen = agent.velocity.magnitude;
            if (kecepatan_agen < 1.5)
            {
                waktu_delay_agen += Time.deltaTime;
            }
        }
        
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "delay")
        {
            waktu_delay_agen = 0;
        }
        
    }
    // total_delay = items.ToArray();
    //     for (int i = 0; i < total_delay.Length ; i++)
    //     {
    //         count += total_delay[i];
    //     }

    //     rata2_delay = count / total_delay.Length;
        
}
