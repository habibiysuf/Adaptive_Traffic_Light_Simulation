using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counter2 : MonoBehaviour
{
    [SerializeField]
    public float data_hitung2;
    public static float hitung_2;
    void  Awake() {
        data_hitung2 = 0f;
        hitung_2 = 0f;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            data_hitung2 += 1f;
            hitung_2 += 1;  
        }
              
    }
    void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            data_hitung2 += 1f;
            hitung_2 -= 1;
        }
        
    }
}
