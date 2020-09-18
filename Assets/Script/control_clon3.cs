using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class control_clon3 : MonoBehaviour
{
    // Start is called before the first frame update
    public int cek;
    public Text ftext;
    public static int clon_time;
    public Slider slider;
    public GameObject slid;
    
    

    // Start is called before the first frame update
      // Update is called once per frame
    void Start()
    {
        cek = 5;
        clon_time = 5;
    }
    void Update()
    {
        slider = slid.GetComponent<Slider>();
        clon_time = (int)slider.value;
        ftext.text = clon_time.ToString();
        cek = clon_time;
    }
}
