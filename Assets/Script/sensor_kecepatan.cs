using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class sensor_kecepatan : MonoBehaviour
{
    private float[] kecepatan_rata2;
    public float total_kec_rata2;
    public static float kecepatan_rata;
    public float copy_kec;
    
    void Start()
    {
        kecepatan_rata2 = new float[4];
        
    }
    void  Update() 
    {
        total_kec_rata2 = 0;
        
        kecepatan_rata2[0] = sen_kec_biru.kec_rata2;
        //kecepatan_rata2[1] = sen_kec_birumuda.kec_rata2;
        //kecepatan_rata2[2] = sen_kec_hijau.kec_rata2;
        kecepatan_rata2[1] = sen_kec_kuning.kec_rata2;
        //kecepatan_rata2[4] = sen_kec_merah.kec_rata2;
        kecepatan_rata2[2] = sen_kec_tengah_hijau.kec_rata2;
        //kecepatan_rata2[6] = sen_kec_tengah_kuning.kec_rata2;
        kecepatan_rata2[3] = sen_kec_ungu.kec_rata2;

        foreach (float item in kecepatan_rata2)
        {
            total_kec_rata2 += item;
        }
        
        
        kecepatan_rata = total_kec_rata2 / kecepatan_rata2.Length ;
        copy_kec = total_kec_rata2 / kecepatan_rata2.Length;
    }
    
    
}
