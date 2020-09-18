using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counter3 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public float data_hitung3;
    public static float hitung_3;
    void  Awake() {
        data_hitung3 = 0f;
        hitung_3 = 0f;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            data_hitung3 += 1;
            hitung_3 += 1;  
        }
              
    }
    void OnTriggerExit(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            data_hitung3 += 1f;
            hitung_3 -= 1;
        }
    }
}
