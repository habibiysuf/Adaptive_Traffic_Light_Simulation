using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lempar : MonoBehaviour
{
    public Transform pos_lempar;
    private Transform[] targetnya;
    private int rand;
    void Awake() {
        targetnya = new Transform[pos_lempar.transform.childCount];
        for (int i = 0; i < targetnya.Length; i++)
		{
			targetnya[i] = pos_lempar.transform.GetChild(i);
		}
    }
    void OnTriggerEnter(Collider other) {
        rand = Random.Range(0,targetnya.Length);
        other.transform.position = targetnya[rand].transform.position ;
    }
    
}
