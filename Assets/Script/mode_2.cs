﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mode_2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider_c1;
    public Slider slider_c2;
    public Slider slider_c3;
    public Slider slider_c4;
    public void mode2()
    {        
       slider_c1.value = 1;
       slider_c2.value = 5;
       slider_c3.value = 6;
       slider_c4.value = 6;
    }
}
