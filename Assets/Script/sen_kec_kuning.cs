using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class sen_kec_kuning : MonoBehaviour
{
     public List<GameObject> items;
    private NavMeshAgent[] agents;
    private float[] kec;
    public GameObject[] a;
    public float jumlah_kec ;
    private int jumlah_agen = 50;
    public static float kec_rata2;
    private GameObject objek;
    // Start is called before the first frame update
    void Start() 
    {
                
        agents = new NavMeshAgent[jumlah_agen];
        kec = new float[jumlah_agen];
        
    }

    // Update is called once per frame
    void Update()
    {
        jumlah_kec = 0;
        a = items.ToArray();
        for (int i = 0; i < a.Length ; i++)
        {
            agents[i] = a[i].GetComponent<NavMeshAgent>();
            kec[i] = agents[i].velocity.magnitude;
            jumlah_kec += kec[i];
        }
        kec_rata2 = jumlah_kec / a.Length;
        if (a.Length == 0)
        {
            kec_rata2 = 0;
        }
    }
    void OnTriggerEnter(Collider col)
    {   
         
        items.Add(col.gameObject);           
        
    }
}
