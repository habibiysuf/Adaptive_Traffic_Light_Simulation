using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumlah_total_pemain : MonoBehaviour
{
    // Start is called before the first frame update
    public int lemparan_jumlah;
    private int[] jumlah;
    public bool scene_enabled;
    public GameObject a;
    public float[] control_jumlah_agen;
    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;

    void Awake() {
        
        control_jumlah_agen = new float [4];
        lemparan_jumlah = Control_Jumlah.jumlah_p;
        s1.GetComponent<move>().jumlah_agen =  lemparan_jumlah / 4;
        s2.GetComponent<move>().jumlah_agen =  lemparan_jumlah / 4;
        s3.GetComponent<move>().jumlah_agen =  lemparan_jumlah / 4;
        s4.GetComponent<move>().jumlah_agen =  lemparan_jumlah / 4;
        control_jumlah_agen[0] = s1.GetComponent<move>().jumlah_agen;
        control_jumlah_agen[1] = s2.GetComponent<move>().jumlah_agen;
        control_jumlah_agen[2] = s3.GetComponent<move>().jumlah_agen;
        control_jumlah_agen[3] = s4.GetComponent<move>().jumlah_agen;
        s1.GetComponent<move>().startWait = control_clon1.clon_time;
        s2.GetComponent<move>().startWait = control_clon2.clon_time;
        s3.GetComponent<move>().startWait = control_clon3.clon_time;
        s4.GetComponent<move>().startWait = control_clon4.clon_time;
    }
   
    // Update is called once per frame
   
}
