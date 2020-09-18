using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class maximum_accel : MonoBehaviour
{
    public Text ftext;
    public static int accel;
    private Slider slider;
    public GameObject slid;
    void Update()
    {
        slider = slid.GetComponent<Slider>();
        accel = (int)slider.value;
        ftext.text = accel.ToString();
    }
}
