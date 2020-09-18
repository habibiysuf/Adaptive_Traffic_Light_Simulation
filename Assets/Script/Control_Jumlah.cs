using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Control_Jumlah : MonoBehaviour
{
    public static int jumlah_p;
    public Slider my_slider;
    public TMP_InputField my_field;
    private float a = 10f;
    public int jumlah;
 
    void Start() {
        //my_slider = gameObject.GetComponent<Slider>();
        jumlah_p = 60;
        jumlah = 60;
        
    }
    // void Update()
    // {
    //   my_field.text = a.ToString();
    // }
 
    public void UpdateValueFromFloat(float value) {
        //Debug.Log("float value changed: " + value);
        if (my_slider)
        {
           my_slider.value = value;
           jumlah_p = (int)value;
           jumlah = jumlah_p;

        }
        if (my_field)
        {
           my_field.text = ((int)value).ToString(); 
           jumlah_p = (int)value;
           jumlah = jumlah_p;
        }
        
    }
 
    public void UpdateValueFromString(string value) {
        //Debug.Log("string value changed: " + value);
        if (my_slider)
        {
           my_slider.value = int.Parse(value); 
           jumlah_p = int.Parse(value);
           jumlah = jumlah_p;
        }
        if (my_field) 
        {
           my_field.text = value; 
           jumlah_p = int.Parse(value);
           jumlah = jumlah_p;
        }
    }
}
