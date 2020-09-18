using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_wt_x : MonoBehaviour
{
    
    public static bool chek = false;
    public bool chekk = false;
   
    void Start()
    {
        this.transform.position = GetComponentInParent<Transform>().position;
       
    }
    // Update is called once per frame
    void Update()
    {
        //this.transform.position += cek.x;
        //this.transform.position = GetComponentInParent<Transform>().position;
        this.transform.localPosition = Grafik_data_waiting_time.x;
    }
    
    void OnTriggerStay(Collider other) {        
        chekk = true;
        if (other.gameObject.tag == "wall_x")
        {
            chek = true;
        }      
        else 
        {          
            return ;
        }

    }
    void OnTriggerExit(Collider other) {
        chekk = false;
        if (other.gameObject.tag == "wall_x")
        {
            chek = false;
        }      
        else 
        {          
            return ;
        }
    }
}
