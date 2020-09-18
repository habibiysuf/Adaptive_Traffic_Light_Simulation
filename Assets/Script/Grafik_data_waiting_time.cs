using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grafik_data_waiting_time : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public int i = 0;
    public float total_waiting_time;
    public float cekk = 0f;
    public static Vector3 x;
    private bool tick;
    private bool tick2;
    public static float v_x;
    public static float v_y;
    public float scalling_wt;
    void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 1;
        
        
    }
    // Start is called before the first frame update
    void Start()
    {
        

       
        
    }

    // Update is called once per frame
    void Update()
    {   
        bool open = false;
        bool open2 = false;
        tick = hit_wt_x.chek;
        tick2 = hit_wt_y.chek;
        if (tick)
        {
            open = true;
            if (open)
            {
                 float xx = this.transform.localScale.x;
                xx = xx * 0.65f;
                float yy = this.transform.localScale.y;
                float zz = this.transform.localScale.z;
                Vector3 scal = new Vector3 (xx, yy, zz);
                this.transform.localScale = scal;
            }
            open = false;        
                   
        }
        if (tick2)
        {
            open2 = true;
            if (open2)
            {
                float yy = this.transform.localScale.y;
                yy = yy * 0.95f;
                float xx = this.transform.localScale.x;
                float zz = this.transform.localScale.z;
                Vector3 scal = new Vector3 (xx, yy, zz);
                this.transform.localScale = scal;
            }
            open2 = false;
           
            
        
        }
        cekk += Time.deltaTime;           
        if (cekk > 0.25)
        {
            
            total_waiting_time = Rata_rata_delay.rata2;
            i += 1; 
            v_x = i;
            v_y = total_waiting_time;
            lineRenderer.positionCount += 1;
            Vector3 next = new Vector3 (i,total_waiting_time*scalling_wt,0);
            x = next;
            lineRenderer.SetPosition(i, next); 
            cekk = 0;
        }
    }
}
