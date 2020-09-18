using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flow1_counter : MonoBehaviour
{
    [SerializeField]
    public static float flow_1;   

    void OnTriggerEnter()
    {
        
        flow_1 += 1;        
    }
    void OnTriggerExit() 
    {
        flow_1 -= 1;
    }
}
