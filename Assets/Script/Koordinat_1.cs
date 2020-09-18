using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Koordinat_1 : MonoBehaviour
{
    Text ftext1;
    Text ftext2;
    public bool trig;
    public bool trigy;
    public float x;
    public float y;
    void Start()
    {
        GameObject f1 = GameObject.Find("x_data1");
        GameObject f2 = GameObject.Find("y_data1");
        ftext1 = f1.GetComponent<Text>();
        ftext2 = f2.GetComponent<Text>();
        ftext1.text = "10";
        ftext2.text = "5";
        
    }

    // Update is called once per frame
    void Update()
    {
        trig = track.chek;
        trigy = TrackY.chek;
        if (trig)
        {
            x = cek.v_x;
            ftext1.text = x.ToString();
        }
        if (trigy)
        {
            y = cek.v_y;
            ftext2.text = y.ToString();
        }
        
        
    }
}
