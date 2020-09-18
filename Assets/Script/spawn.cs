using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;



namespace traffic {


// public class s_point : MonoBehaviour
// {	
// 	GameObject parent_start_point;
//     public static Transform[] home;
//     void findparent()
//     {
//         parent_start_point = GameObject.FindGameObjectWithTag("Start_point");
//         home = new Transform[parent_start_point.transform.childCount];

//     }

//     private int GetGetChildCount()
//     {
//         return transform.GetChildCount;
//     }


// }

public class spawn : MonoBehaviour
{
    public int jumlah_player = 1;
    public float[] perubahan_speed;
    public static Transform[] start;
    public static Transform[] target;
    public GameObject[] objek;
    public NavMeshAgent[] agents;
    public float speed = 5f;
    private float countdown = 2f;
    public float timeBetweenWaves = 2f;
    private int waveIndex = 0;
    private Text kecepatan_rata; //for UI
    
    public List<float> temp ;
    private Vector3 kecepatan_sebelumnya;
    float kecepatan;
    public float kecepatan_rata_rata;
    

    // public NavMeshAgent[] Agents { get => agents; set => agents = value; }
    // public NavMeshAgent[] Agents1 { get => agents; set => agents = value; }

    
    // Start is called before the first frame update
          
    
    // Update is called once per frame
    void OnEnable()
    {
        start = new Transform[jumlah_player];  
        target = new Transform[jumlah_player];
        objek = new GameObject[jumlah_player];
        perubahan_speed = new float[jumlah_player];  
        agents = new NavMeshAgent[jumlah_player]; 
        for (int i = 0; i < jumlah_player; i++)
        {
            int R = Random.Range(0, start.Length);            
            perubahan_speed[i] =  Random.Range((-speed/2), (speed/2));
            objek[i]= GameObject.CreatePrimitive (PrimitiveType.Cube);
            objek[i].AddComponent<Rigidbody>();
            objek[i].AddComponent<NavMeshAgent>();  
            objek[i].transform.position = start[i].position;
            agents[i] = objek[i].GetComponent<NavMeshAgent>();
            agents[i].speed = speed + perubahan_speed[i];
            
        } 
    }
    void Start()
    {

    }
    void Update()
    {
        if (objek.Length != 0)
        {
            temp = new List<float>(objek.Length);  
            Debug.Log(objek.Length);      
            if (countdown <= 0f)
            {
                agents[waveIndex].SetDestination(target[waveIndex].position);	
                
                countdown = timeBetweenWaves;
                waveIndex++;
                if (waveIndex == jumlah_player)
                {
                    waveIndex = 0;
                }
            }        

            foreach (GameObject a in objek)
            {
                Vector3 sp = a.transform.position - kecepatan_sebelumnya;        
                kecepatan = sp.magnitude / Time.deltaTime;
                kecepatan_sebelumnya = transform.position;
                temp.Add(kecepatan);                 
            }
            float kec = 0;
            Debug.Log(temp);

            foreach(float a in temp)
            {            
                kec = kec + a;
            }

            kecepatan_rata_rata = kec / objek.Length;
            

            countdown -= Time.deltaTime;
        }
        
    }
}
}
