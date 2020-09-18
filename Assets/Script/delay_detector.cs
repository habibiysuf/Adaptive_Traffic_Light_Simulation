using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;
using System.IO;
public class delay_detector : MonoBehaviour
{
    public float[] kolek_delay;
    private delay_mobil delay;
    public List<GameObject> items;
    public GameObject[] agents;
    private float count = 0f;
    public float rata2_delay;
    public List<float> list_delay;
    public bool open = false;
    float buka = 0f;
    public float copy_hen;
    public float count_detek;
    
    void Start() 
    {
        kolek_delay = new float[100];
        
    }
    void OnTriggerEnter(Collider col)
    {   
        buka += 1;
        if (col.gameObject.tag == "Player")
        {
            if (items.Contains(col.gameObject))
                return ;
            else
                items.Add(col.gameObject); 
        }
        
        else 
        {          
            return ;
        }
    }
    void OnTriggerExit(Collider col) 
    {
        buka -= 1;
        if (col.gameObject.tag == "Player")
        {
            items.Remove(col.gameObject); 
            
        }      
        else {
            return;
        }
    }
    
    void OnTriggerStay(Collider col)
    { 
        if (col.gameObject.tag == "counter")
        {
            count_detek = col.GetComponent<counter_stop>().ken_henti;
        }
    }  
   
       
    //     open = true;
    //     if (col.gameObject.tag == "Player")
    //     {           
    //         count = 0;
            
    //         agents = items.ToArray();
            
    //         for (int i = 0; i < agents.Length ; i++)
    //         {
    //             kolek_delay[i] = agents[i].GetComponent<delay_mobil>().waktu_delay_agen; 
    //             //list_delay.Add(kolek_delay[i]);
    //         }
    //         // kolek_delay = list_delay.ToArray();
    //         foreach (float j in kolek_delay)
    //         {                
    //             count += j;
    //         }
    //         rata2_delay = count / agents.Length;
    //         if (agents.Length == 0)
    //         {
    //             rata2_delay = 0;
    //         }
    //         // if (col.gameObject.tag == "Player")
    //         // {
    //         //     kolek_delay = col.GetComponent<delay_mobil>().waktu_delay_agen;            
    //         //     //kolek_delay = delay.waktu_delay_agen;
                
    //         // }
    //     } 
    //     else {return ;}         
        
        
    // }
    void Update() {
        
        
        if (buka > 0)
        {
            count = 0;
            list_delay.Clear();
            agents = items.ToArray();
            Array.Clear(kolek_delay, 0, agents.Length);
            for (int i = 0; i < agents.Length ; i++)
            {
                //kolek_delay[i] = agents[i].GetComponent<delay_mobil>().waktu_delay_agen; 
                list_delay.Add(agents[i].GetComponent<delay_mobil>().waktu_delay_agen);
            }
            
            // kolek_delay = list_delay.ToArray();
            foreach (float j in list_delay)
            {                               
                count += j;
            }
            rata2_delay = count / count_detek;
            if (count_detek == 0)
            {
                rata2_delay = 0;
            }        
        }
    }
    // Update is called once per frame
}
