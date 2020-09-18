using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muter : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform A;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround (A.position, Vector3.up, 2f*Time.deltaTime);
        
    }
}
