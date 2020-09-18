using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counter : MonoBehaviour
{
    [SerializeField]
    public float data_hitung1;
    public static float hitung_1;

    void  Awake() {
        data_hitung1 = 0f;
        hitung_1 = 0f;
    }
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            data_hitung1 +=1;
            hitung_1 += 1; 
        }
               
    }
    void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            data_hitung1 +=1;
            hitung_1 -= 1;
        }
        
    }
}
