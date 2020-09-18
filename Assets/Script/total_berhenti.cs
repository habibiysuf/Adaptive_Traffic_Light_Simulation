using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class total_berhenti : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject[] stop;
    private float[] temp;
    public float total;
    public static float tot;
    void Awake()
    {
        stop = new GameObject[4];
        temp = new float[stop.Length];
        for (int i = 0; i < stop.Length; i++)
        {
            stop[i] = GameObject.Find("counter"+(i+1));
            
        }
    }
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        tot = 0;
        total = 0;
        for (int i = 0; i < stop.Length; i++)
        {
            temp[i] = stop[i].GetComponent<counter_stop>().copy_ken_henti;
        }
        foreach (float item in temp)
        {
            total += item;   
            tot += item;         
        }
    }
}
