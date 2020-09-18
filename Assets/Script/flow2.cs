using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flow2_counter : MonoBehaviour
{
    // Start is called before the first frame update
    public static float flow_2;
    
    void OnTriggerEnter()
    {        
        flow_2 += 1;        
    }
    void OnTriggerExit() 
    {
        flow_2 -= 1;
    }
}
