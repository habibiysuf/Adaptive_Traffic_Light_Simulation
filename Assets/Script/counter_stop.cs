using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;
using UnityEngine.UI;
using TMPro;
public class counter_stop : MonoBehaviour
{
    // Start is called before the first frame update
    public float ken_henti;
    private bool stop_sign;
    public float copy_ken_henti;
    public float cek_h;
    public float[] kec;
    private float temp_ken;
    public List<GameObject> items;
    public List<float> jumlah_nol;
    private NavMeshAgent[] agents;
    public List<NavMeshAgent> agenn;
    public GameObject[] a;
    public float cek;
    bool open;
    public float kec_rata2;
    public float jumlah_kec;
    public float[] hitung_kec_sem;
    public float[] delay_n;
    public float[] count_n;
    public GameObject show;

    
    
    void Start() 
    {
        temp_ken = 0;
        ken_henti = 0f;
        agents = new NavMeshAgent[move.jumlah_kopi*2];
        kec = new float[move.jumlah_kopi*2];
        delay_n = new float[move.jumlah_kopi*2];
        count_n = new float[move.jumlah_kopi*2];
        
    }
    void OnTriggerEnter(Collider col)
    {   
        temp_ken += 1;
        if (col.gameObject.tag == "Player")
        {
            items.Add(col.gameObject); 
        }      
        else 
        {          
            return ;
        }
    }
    
    void OnTriggerExit(Collider col) 
    {
        temp_ken -= 1;
        if (col.gameObject.tag == "Player")
        {
            items.Remove(col.gameObject); 
        }      
        else {
            return;
        }
    }
   
    void Update()
    {               
        
       
        
        
    }
    void OnTriggerStay(Collider col)
    {   
        
       // float n = 0f;
        jumlah_nol = new List<float>();
        jumlah_kec = 0;
             
        a = items.ToArray();
        cek = a.Length;        
        
        
        for (int i = 0; i < a.Length ; i++)
        {
            agents[i] = a[i].GetComponent<NavMeshAgent>();
            kec[i] = agents[i].velocity.magnitude;
        
            jumlah_kec += kec[i];
            if (kec[i] < 1.3)
            {
                
                count_n[i] += Time.deltaTime;
                jumlah_nol.Add(kec[i]);
                
            }

            
        }             
        
        ken_henti = jumlah_nol.ToArray().Length;
        copy_ken_henti = ken_henti;
        cek_h = ken_henti;
        kec_rata2 = jumlah_kec / a.Length;
        if (a.Length == 0)
        {
            kec_rata2 = 0;
        }
        // Text x = show.GetComponent<Text>();
        // x.text = ken_henti.ToString();
                
        
    }
    
    // Update is called once per frame


}
