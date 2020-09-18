using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counter4 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public float data_hitung4;
    public static float hitung_4;
    void  Awake() {
        data_hitung4 = 0f;
        hitung_4 = 0f;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            data_hitung4 += 1;
            hitung_4 += 1;      
        }  
    }
    void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            data_hitung4 += 1;
            hitung_4 -= 1;
        }
    }
}
