using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public static class Extensions
{
    public static int findIndex<T>(this T[] array, T item)
    {
        return Array.IndexOf(array, item);
    }
}
public class traffic_system : MonoBehaviour
{
    // Start is called before the first frame update
     
   
    public static float waktu_satu;
    public static float waktu_dua;
   
    ///////////////////// input fuzzy ////////////////
    private float input_q1;
    private float input_q2;
    private float input_q3;
    private float input_q4;
    private float flow1;
    private float flow2;
  
    
    private float[] aturan;
    private float mak;
    private float min;
    private float waktu_cuplik = 0.1f;
    public float ww1;
    public float ww2;
    private float[] z;
    bool aktifkan;
    /////////////////// traffic
    GameObject[] wall;
    
    public static bool[] set_lampu;
    public bool[] bool_state;
    private float[] countdown;
    private float waktu_hijau_1 = 1f;
    private float waktu_hijau_2 = 1f;
    private float waktu_hijau_3 = 1f;
    private float waktu_hijau_4 = 1f;
    private bool[] open;
    public bool checker;
    private float waktu_delay;
    private int[] state;
    private bool[] urutan;
    int hitung_aktif;
    public float jumlah_deteksi_min;
    public float jumlah_deteksi_max;
    public int minimal_hijau;
    public int maksimal_hijau;
    private float[] temp;
    public float[] copy_temp;
    private bool open_awal;
    private float jumlah = 0f;
    public float waktu_kuning;
    public GameObject counter1;
    public GameObject counter2;
    public GameObject counter3;
    public GameObject counter4;
    private bool open_akhir;
    private int[] jumlah_s;
    private float[] temp_s2;
    public float waktu_return;

    public GameObject lampukuning1;
    public GameObject lampukuning2;
    public GameObject lampukuning3;
    public GameObject lampukuning4;
    public int[] delay_cycle;
    public int total_delay;
    public bool kunci;
    public float clock;
    public float[] arrange;
    public float hitung_mundur = 0f;
    public float waktu_t;
    public bool SmartTraffic;

    ////////////////////////////
    void Awake()
    {
        arrange = new float[4];
        urutan = new bool[4];
        aturan = new float[8];
        z = new float[8];
        ////////////////////////
        countdown = new float[4];
        bool_state = new bool [4];
        open = new bool[4];
        set_lampu = new bool[4];
        hitung_aktif = 0;
        wall = new GameObject[4];
        state = new int[4];
        temp = new float[4];
        delay_cycle = new int[4];
        copy_temp = new float[4];
        jumlah_s = new int[4];
        temp_s2 = new float[4];
        lampukuning1.SetActive(false);
        lampukuning2.SetActive(false);
        lampukuning3.SetActive(false);
        lampukuning4.SetActive(false);
        
        SmartTraffic = TOggle.state;

    }
    void Start()
    {
        wall[0] = LampuLaluLintas.wall;
        wall[1] = LLL2.wall;
        wall[2] = LLL3.wall;
        wall[3] = LLL4.wall;    
        waktu_satu = 10f;
        waktu_dua = 10f;
        bool_state[0] = true; ////harus
        open_awal = true;
        open_akhir = true;
        waktu_delay = 0f;
        jumlah = 0;
        total_delay = 1;
    }
    void Update() 
    {
        
        clock += Time.deltaTime;        
        jumlah = 0;
        input_q1 = counter1.GetComponent<delay_detector>().agents.Length;
        input_q2 = counter2.GetComponent<delay_detector>().agents.Length;
        input_q3 = counter3.GetComponent<delay_detector>().agents.Length;
        input_q4 = counter4.GetComponent<delay_detector>().agents.Length;
    //////////fuzzifikasi
        ////// Q1
        
        if (SmartTraffic)
        {
        if (input_q1 <= jumlah_deteksi_min && input_q1 != 0) {
            temp[0] = minimal_hijau;}
        if (input_q1 > jumlah_deteksi_min && input_q1 <= jumlah_deteksi_max) {
            temp_s2[0] = (jumlah_deteksi_max - input_q1) / (jumlah_deteksi_max - jumlah_deteksi_min);
            temp[0] = maksimal_hijau - temp_s2[0]*(maksimal_hijau - minimal_hijau);
            }
        if (input_q1 == 0)
            {temp[0] = 0;}                  
        if (input_q1 >= jumlah_deteksi_max) {
            temp[0] = maksimal_hijau;}
        ////// Q2
        if (input_q2 <= jumlah_deteksi_min && input_q2 != 0) {
            temp[1] = minimal_hijau;}
        if (input_q2 > jumlah_deteksi_min && input_q2 <= jumlah_deteksi_max) {
            temp[1] = (jumlah_deteksi_max - input_q2) / (jumlah_deteksi_max - jumlah_deteksi_min);
            temp[1] = maksimal_hijau - temp_s2[1]*(maksimal_hijau - minimal_hijau);}
        if (input_q2 >= jumlah_deteksi_max) {
            temp[1] = maksimal_hijau;}
        if (input_q2 == 0)
            {temp[1] = 0;}   
        ////// Q3
        if (input_q3 <= jumlah_deteksi_min && input_q3 != 0) {
            temp[2] = minimal_hijau;}
        if (input_q3 > jumlah_deteksi_min && input_q3 <= jumlah_deteksi_max) {
            temp[2] = (jumlah_deteksi_max - input_q3) / (jumlah_deteksi_max - jumlah_deteksi_min);
            temp[2] = maksimal_hijau - temp_s2[2]*(maksimal_hijau - minimal_hijau);}
        if (input_q3 >= jumlah_deteksi_max) {
            temp[2] = maksimal_hijau;}
        if (input_q3 == 0)
            {temp[2] = 0;}  
        ////// Q4
        if (input_q4 <= jumlah_deteksi_min && input_q4 != 0) {
            temp[3] = minimal_hijau;}
        if (input_q4 > jumlah_deteksi_min && input_q4 <= jumlah_deteksi_max) {
            temp_s2[3] = (jumlah_deteksi_max - input_q4) / (jumlah_deteksi_max - jumlah_deteksi_min);
            temp[3] = maksimal_hijau - temp_s2[3]*(maksimal_hijau - minimal_hijau);}
        if (input_q4 >= jumlah_deteksi_max) {
            temp[3] = maksimal_hijau;}
        if (input_q4 == 0)
            {temp[3] = 0;}  
        
        }
        else
        {
            temp[0] = 8;
            temp[1] = 8;
            temp[2] = 8;
            temp[3] = 8; 
        }
    /////////   
        
        // kunci = true;   
        // if (kunci)
        // {
        total_delay = delay_cycle[0] + delay_cycle[1] + delay_cycle[2] + delay_cycle [3];
        checker = true;
               
        // float[] key = new float[4];        
        // key[0] = 0.1f;
        // key[1] = 0.2f;
        // key[2] = 0.3f;
        // key[3] = 0.4f;        
        // Array.Copy(delay_cycle, jumlah_s, temp.Length);
        // for (int i = 0; i < 4; i++)
        // {
        //     arrange[i] = Convert.ToSingle(delay_cycle[i]);
        //     arrange[i] += key[i];
        // } 
        // Array.Copy(arrange, copy_temp, temp.Length);
        // Array.Sort(copy_temp);
        // Array.Reverse(copy_temp);     
        // for (int i = 0; i < 4; i++)
        // {
        //     state[i] = arrange.findIndex(copy_temp[i]);
        // }
        
        susunan(0,1,2,3);
        
        

    }
    
    IEnumerator fuzzy()
    {
        // [2,3,1,4]     
       
        yield return new WaitForSeconds(5);
        kunci = false;
        susunan(state[0],state[1],state[2],state[3]);

    
    }
    void susunan(int x, int y, int z, int a)
    {        
        waktu_return += Time.deltaTime;
        int N = 2;           
        if (bool_state[0])
        {         
            if (open_akhir)
            {    
                wall[a].transform.Translate(0,-N,0);
                wall[x].transform.Translate(0,-N,0);
                wall[y].transform.Translate(0,-N,0);
                wall[z].transform.Translate(0,-N,0);
            }
            open_akhir = false;
            lampukuning4.SetActive(true);     
            if(waktu_delay > waktu_kuning) {
                if (open_awal == true)
                {
                    wall[x].transform.Translate(0,N,0);                    
                }
                open_awal = false;
                lampukuning4.SetActive(false); //ilang
                set_lampu[x] = true;
                set_lampu[y] = false;
                set_lampu[z] = false;
                set_lampu[a] = false;
                if (countdown[x] >= temp[x])
                {            
                    wall[x].transform.Translate(0,-N,0);      
                    bool_state[1] = true;
                    countdown[y] = 0;
                    bool_state[0] = false; 
                    open[y] = true;          
                    waktu_delay = 0; 
                    //open_akhir = true;             
                    
                }
                countdown[x] += Time.deltaTime;  
            }  
            
            
            waktu_delay += Time.deltaTime;    
        }
        else if (bool_state[1])
        {            
            // if (open_akhir)
            // {    
            //     wall[a].transform.Translate(0,-N,0);
            //     wall[x].transform.Translate(0,-N,0);
            //     wall[y].transform.Translate(0,-N,0);
            //     wall[z].transform.Translate(0,-N,0);
            // }
            open_akhir = false;    
            lampukuning1.SetActive(true);   
            if(waktu_delay > waktu_kuning) {
                if (open[y] == true)
                {
                   wall[y].transform.Translate(0,N,0);
                }
                open[y] = false;
                lampukuning1.SetActive(false); //ilang
                set_lampu[y] = true;
                set_lampu[x] = false;
                set_lampu[z] = false;
                set_lampu[a] = false;
                if (countdown[y] >= temp[y])
                {                
                    bool_state[2] = true;
                    wall[y].transform.Translate(0,-N,0);
                    countdown[z] = 0;
                    bool_state[1] = false;
                    open[z] = true; 
                    waktu_delay = 0;  
                    //open_akhir = true;         
                    
                }
                countdown[y] += Time.deltaTime;     
            }
            
            waktu_delay += Time.deltaTime;      
        }
        else if (bool_state[2])
        {
            
            
            open_akhir = false;    
            lampukuning2.SetActive(true);  
            if(waktu_delay > waktu_kuning) {
                if (open[z] == true)
                {
                    wall[z].transform.Translate(0,N,0);
                    
                }
                open[z] = false;
                lampukuning2.SetActive(false);  
                set_lampu[z] = true;
                set_lampu[x] = false;
                set_lampu[y] = false;
                set_lampu[a] = false;
                if (countdown[z] >= temp[z])
                {                
                    bool_state[3] = true;
                    wall[z].transform.Translate(0,-N,0);
                    countdown[a] = 0;
                    bool_state[2] = false;  
                    open[a] = true;    
                    waktu_delay = 0; 
                    //open_akhir = true;  
                    
                }
                countdown[z] += Time.deltaTime;   
            }
            
            waktu_delay += Time.deltaTime;       
        }
        else if (bool_state[3])        
        {
           
            open_akhir = false;    
            lampukuning3.SetActive(true);     
            if(waktu_delay > waktu_kuning) {
                if (open[a] == true)
                {
                   wall[a].transform.Translate(0,N,0);
                }
                open[a] = false;
                lampukuning3.SetActive(false); 
                set_lampu[a] = true;
                set_lampu[x] = false;
                set_lampu[y] = false;
                set_lampu[z] = false;
                if (countdown[a] >= temp[a])
                {                
                    bool_state[0] = true;
                    wall[a].transform.Translate(0,-N,0);
                    countdown[x] = 0;
                    bool_state[3] = false; 
                    open_awal = true;      
                    waktu_delay = 0; 
                    open_akhir = true;     
                    aktifkan = true;
                    
                }
                countdown[a] += Time.deltaTime;  
            } 
            
            waktu_delay += Time.deltaTime;   
            if (aktifkan)    
            {
                wall[a].transform.Translate(0,N,0);
                wall[x].transform.Translate(0,N,0);
                wall[y].transform.Translate(0,N,0);
                wall[z].transform.Translate(0,N,0);
            }
            aktifkan = false;
        }
        //status = true;
        
            
    }
    
    
    
    
    
}
