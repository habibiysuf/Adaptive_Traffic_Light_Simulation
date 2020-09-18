using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampuLaluLintas : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject lampuhijau;
    public GameObject lampumerah;
    public GameObject wall1;
    public static GameObject wall;
    //public GameObject wall;
    private float countdown = 0;
    private float countdownhijau = 0;
    public static bool merah;
    public static bool hijau;  
    float waktu_hijau;
    float waktu_merah; 
    public bool open = true;
    bool status ;
    public GameObject ab;
    BoxCollider a;
    
    void Awake() {

       wall = wall1;
        
                
    }
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        status = traffic_system.set_lampu[0];
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
        
        // if(!traffic_system.a[0])
        // {
        //     status = false;
        //     if (open == true)
        //         wall.transform.Translate(0, 4, 0);
        //     open = false;
                   
        //     lampumerah.SetActive(false);
        //     lampuhijau.SetActive(true); //hijau
            
        //     if (countdown >= waktu_hijau)
        //     {
        //         traffic_system.a[0] = true;
        //         //Debug.Log("merah");
        //         countdown = 0;
        //         status = true;
        //         open = true;
                
        //     }
        //     countdown += Time.deltaTime;

        // }
        
        // if(traffic_system.a[0])
        // {
        //     status = false;
        //     if (open == true)
        //         wall.transform.Translate(0, -4, 0);
        //     open = false;
        //     lampumerah.SetActive(true);
        //     lampuhijau.SetActive(false);
            
        //     if (countdownhijau >= waktu_merah)
        //     {
        //         traffic_system.a[0] = false;
        //         //Debug.Log("Hijau");
        //         countdownhijau = 0;
        //         status = true;
        //         open = true;
                
        //     }
        //     countdownhijau += Time.deltaTime;

        //}


        
        
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
