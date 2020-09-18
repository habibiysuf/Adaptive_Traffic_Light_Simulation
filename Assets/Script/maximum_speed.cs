using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class maximum_speed : MonoBehaviour
{
    public Text ftext;
    public static int speed_mak;
    public Slider slider;
    public GameObject slid;
    void Update()
    {
        slider = slid.GetComponent<Slider>();
        speed_mak = (int)slider.value;
        ftext.text = speed_mak.ToString();
    }
}
