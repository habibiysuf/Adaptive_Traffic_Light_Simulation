using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class track : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 trac;
    public static bool chek = false;
    public bool chekk = false;
    private Vector3 awal;
    void Start()
    {
        this.transform.position = GetComponentInParent<Transform>().position;
       
    }
    // Update is called once per frame
    void Update()
    {
        //this.transform.position += cek.x;
        //this.transform.position = GetComponentInParent<Transform>().position;
        this.transform.localPosition = cek.x;
    }
    
    void OnTriggerEnter(Collider other) {        
        chekk = true;
        if (other.gameObject.tag == "wall_x")
        {
            chek = true;
        }      
        else 
        {          
            return ;
        }

    }
    void OnTriggerExit(Collider other) {
        chekk = false;
        if (other.gameObject.tag == "wall_x")
        {
            chek = false;
        }      
        else 
        {          
            return ;
        }
    }
}
