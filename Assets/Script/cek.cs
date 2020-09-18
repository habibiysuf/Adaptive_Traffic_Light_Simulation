using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI.Extensions;
using UnityEngine.UI;

public class cek : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public int i = 0;
    public float totalhenti;
    public float cekk = 0f;
    public static Vector3 x;
    private bool tick;
    private bool tick2;
    public static float v_x;
    public static float v_y;
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
        tick = track.chek;
        tick2 = TrackY.chek;
        if (tick)
        {
            open = true;
            if (open)
            {
                 float xx = this.transform.localScale.x;
                xx = xx * 0.85f;
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
                yy = yy * 0.85f;
                float xx = this.transform.localScale.x;
                float zz = this.transform.localScale.z;
                Vector3 scal = new Vector3 (xx, yy, zz);
                this.transform.localScale = scal;
            }
            open2 = false;
           
            
        
        }
        cekk += Time.deltaTime;           
        if (cekk > 0.5)
        {
            
            totalhenti = total_berhenti.tot;
            i += 1; 
            v_x = i;
            v_y = totalhenti;
            lineRenderer.positionCount += 1;
            Vector3 next = new Vector3 (i,totalhenti,0);
            x = next;
            lineRenderer.SetPosition(i, next); 
            cekk = 0;
        }
    }
    
  
}
