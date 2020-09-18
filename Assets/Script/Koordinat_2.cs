using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Koordinat_2 : MonoBehaviour
{
    Text ftext1;
    Text ftext2;
    public bool trig;
    public bool trigy;
    public float x;
    public float y;
    void Start()
    {
        GameObject f1 = GameObject.Find("x_data2");
        GameObject f2 = GameObject.Find("y_data2");
        ftext1 = f1.GetComponent<Text>();
        ftext2 = f2.GetComponent<Text>();
        ftext1.text = "10";
        ftext2.text = "3";
        y = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        trig = hit_x_kec.chek;
        trigy = hit_y_kec.chek;
        if (trig)
        {
            x = grafik_data_kec.v_x;
            ftext1.text = x.ToString();
        }
        if (trigy)
        {
            if (grafik_data_kec.v_y > y)
            {
                y = grafik_data_kec.v_y;
                ftext2.text = y.ToString("F1");

            }
            
        }
        
        
    }
}
