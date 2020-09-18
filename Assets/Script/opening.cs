using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class opening : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menuawal;
    public GameObject menuset;
    public GameObject open;
    public Slider slider;
    
    private float counter = 0f;

    void Start()
    {
        counter = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
        if (counter > 3)
        {
            open.SetActive(false);
            menuawal.SetActive(true);
            menuset.SetActive(false);
                        
        }
        slider.value = slider.value + 1;
        counter += Time.deltaTime;
        
    }
}
