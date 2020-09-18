using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class reset_setting_UI : MonoBehaviour
{
    public Slider slidervehicle;
    public Slider slider_c1;
    public Slider slider_c2;
    public Slider slider_c3;
    public Slider slider_c4;
    public Slider slider_speedmin;
    public Slider slider_speedmax;
    public Slider slider_acc;
    public Toggle toggle;
    public TMP_InputField input_runtime;
       
   public void reset_setting()
   {
       slidervehicle.value = 60;
       slider_c1.value = 1;
       slider_c2.value = 1;
       slider_c3.value = 1;
       slider_c4.value = 1;
       slider_speedmin.value = 2;
       slider_speedmax.value = 5;
       slider_acc.value = 12;
       toggle.isOn = true;
       input_runtime.text = "100";

   }
}
