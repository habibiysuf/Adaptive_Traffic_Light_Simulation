using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TOggle : MonoBehaviour
{
    public bool cek;
    public GameObject background;
    public static bool state;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }
    void Update()
    {
        
        cek = gameObject.GetComponent<Toggle>().isOn;
        state = cek;
        if (cek == true)
        {
            background.GetComponent<Image>().color = new Color (10,255,0,255);
        }
        else if (cek == false)
        {
            background.GetComponent<Image>().color = new Color (255,255,255,100);
        }
    }

}
