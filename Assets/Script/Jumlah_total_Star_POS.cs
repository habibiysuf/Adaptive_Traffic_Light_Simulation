using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumlah_total_Star_POS : MonoBehaviour
{
    public int lemparan_jumlah;
    private int[] jumlah;
    private move[] pemain;
    public bool scene_enabled;
    public GameObject a;
    public float[] control_jumlah_agen;
    void Awake() {
        control_jumlah_agen = new float [4];
        
        pemain = new move [transform.childCount];        
        GameObject s1 = GameObject.Find("Start_POS/Start_Pos_kuning");
        GameObject s2 = GameObject.Find("Start_POS/Start_Pos_ungu");
        GameObject s3 = GameObject.Find("Start_POS/Start_Pos_biru");
        GameObject s4 = GameObject.Find("Start_POS/Start_Pos_1hijau");
        lemparan_jumlah = Control_Jumlah.jumlah_p;
        // for (int i = 0; i < pemain.Length; i++)
        // {
        //     pemain[i].jumlah_agen = lemparan_jumlah / pemain.Length ;
            
        // }
        s1.GetComponent<move>().jumlah_agen = lemparan_jumlah / 4;
        s2.GetComponent<move>().jumlah_agen = lemparan_jumlah / 4;
        s3.GetComponent<move>().jumlah_agen = lemparan_jumlah / 4;
        s4.GetComponent<move>().jumlah_agen = lemparan_jumlah / 4;
       
        
        
        
        
    }
   
    // Update is called once per frame
    void Start()
    {
        // pemain[0].startWait = control_clon1.clon_time;
        // pemain[1].startWait = control_clon2.clon_time;
        // pemain[2].startWait = control_clon3.clon_time;
        // pemain[3].startWait = control_clon4.clon_time;
        // control_jumlah_agen[0] = control_clon1.clon_time;
        // control_jumlah_agen[1] = control_clon2.clon_time;
        // control_jumlah_agen[2] = control_clon3.clon_time;
        // control_jumlah_agen[3] = control_clon4.clon_time;
        
        
      
    }
}
