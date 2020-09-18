using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rata_rata_delay : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject[] delay;
    private float[] temp;
    public static float rata2;
    public float rata_rata;
    private float count;
    public float total;
    void Awake()
    {   
        delay = new GameObject[4];
        delay[0] = GameObject.Find("delay1");
        delay[1] = GameObject.Find("delay2");
        delay[2] = GameObject.Find("delay3");
        delay[3] = GameObject.Find("delay4");
        temp = new float[4];
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        total = 0;
        count = 0;
        
        for (int i = 0; i < delay.Length; i++)
        {
            temp[i] = delay[i].GetComponent<delay_detector>().rata2_delay;
            if (temp[i] > 0)
            {
                total += 1;
            }
        }
        foreach (float i in temp)
        {
            count += i;
        }

        rata2 = count / total;
        rata_rata = rata2;
        if (total == 0)
            rata2 = 0;

    }
}
