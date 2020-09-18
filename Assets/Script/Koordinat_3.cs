using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Koordinat_3 : MonoBehaviour
{
    Text ftext1;
    Text ftext2;
    public bool trig;
    public bool trigy;
    public float x;
    public float y;
    void Start()
    {
        GameObject f1 = GameObject.Find("x_data3");
        GameObject f2 = GameObject.Find("y_data3");
        ftext1 = f1.GetComponent<Text>();
        ftext2 = f2.GetComponent<Text>();
        ftext1.text = "10";
        ftext2.text = "3";
        y = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        trig = hit_wt_x.chek;
        trigy = hit_wt_y.chek;
        if (trig)
        {
            x = Grafik_data_waiting_time.v_x;
            ftext1.text = x.ToString();
        }
        if (trigy)
        {
            if(Grafik_data_waiting_time.v_y > y)
            {
                y = Grafik_data_waiting_time.v_y;
                ftext2.text = y.ToString("F1");
            }
        }
        
        
    }
}
