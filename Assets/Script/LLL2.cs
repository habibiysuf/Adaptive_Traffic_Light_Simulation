using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LLL2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lampuhijau;
    public GameObject lampumerah;
    public GameObject wall2;
    public static GameObject wall;
    private float countdown = 0;
    private float countdownhijau = 0;
    public static bool merah;
    public static bool hijau;  
    float waktu_hijau;
    float waktu_merah; 
    
    public bool open = true;
    
    bool status ;
    void Awake() 
    {
         
       wall = wall2;
                
    }
    // Update is called once per frame
    void Update()
    {
        status = traffic_system.set_lampu[1];
        waktu_hijau = traffic_system.waktu_satu;
        waktu_merah = traffic_system.waktu_dua; 
        if (!status)
        {
            lampumerah.SetActive(true);
            lampuhijau.SetActive(false); 
           
        }
        else
        {
            lampumerah.SetActive(false);
            lampuhijau.SetActive(true); 
            

        }
        // if(!traffic_system.a[1])
        // {
        //     if (open == true)
        //         wall.transform.Translate(0, -4, 0);
        //     open = false;
                   
        //     lampumerah.SetActive(true);
        //     lampuhijau.SetActive(false); //hijau
            
        //     if (countdown >= waktu_hijau)
        //     {
        //         traffic_system.a[1] = true;
        //         //Debug.Log("merah");
        //         countdown = 0;
        //         open = true;
                
        //     }
        //     countdown += Time.deltaTime;

        // }
        
        // if(traffic_system.a[1])
        // {
        //     if (open == true)
        //         wall.transform.Translate(0, 4, 0);
        //     open = false;
        //     lampumerah.SetActive(false);
        //     lampuhijau.SetActive(true);
            
        //     if (countdownhijau >= waktu_merah)
        //     {
        //         traffic_system.a[1] = false;
        //         //Debug.Log("Hijau");
        //         countdownhijau = 0;
        //         open = true;
                
        //     }
        //     countdownhijau += Time.deltaTime;

        // }
        
        
        // if(hijau)
        // {
        //     wall.SetActive(false);
        //     lampuhijau.SetActive(true);
            
        //     if (countdownhijau == 3)
        //     {
        //         hijau = false;
        //         merah = true;
        //     }
        //     countdownhijau += Time.deltaTime;
        // }
        
		
        
    }
}
