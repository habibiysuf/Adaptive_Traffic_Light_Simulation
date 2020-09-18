using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minimum_speed : MonoBehaviour
{
    public Text ftext;
    public static int speed_min;
    public Slider slider;
    public GameObject slid;
    void Update()
    {
        slider = slid.GetComponent<Slider>();
        speed_min = (int)slider.value;
        ftext.text = speed_min.ToString();
    }
}
