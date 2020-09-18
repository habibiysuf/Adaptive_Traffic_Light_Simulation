using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class move_2 : MonoBehaviour
{
   private Transform[] target;
	//private int wavepointIndex = 0;
    float speed = 3f;
    NavMeshAgent agents;
	NavMeshAgent agents_clone;
	public NavMeshAgent[] agent_velo;
    //public int waveIndex = 0;
    //public bool check;
	//public float spawnWait = 1f;
	public float startWait = 2f;
	//public bool start;
	int rand;
	//public Transform home;
	
    //public float spawnmax = 2f;
    //public float spawnmin = 1f;
	public int jumlah_agen = 5;
	//public bool start;
    
    //public Transform a;
	//private Enemy enemy;
    private float countdown = 2f;
	//public float timeBetweenWaves = 1f;
	private GameObject ori;
	private Transform[] start_point;
	int rand_start;
	public GameObject pemain;
	public float[] perubahan_speed;
	public static float velo;
	public static float velo_s;
	public static float[] kec_tampung;
	public float count;
	public static float kec_cek;
	 private Vector3 previousPosition;
	 public float mob_speed;

	 public GameObject mobil;
	private bool isCoroutineExecuting = false;
	public bool check;
	public float waktu_delay;
	public Transform titik_ori;
	void Awake() 
	{
				
		agent_velo = new NavMeshAgent[jumlah_agen];
		agents = pemain.GetComponent<NavMeshAgent>();
		kec_tampung = new float[jumlah_agen];
		start_point = new Transform[transform.childCount];
		for (int i = 0; i < start_point.Length ; i++)
		{
			start_point[i] = transform.GetChild(i);
		}
		//posisi_start_1 = start_point[2];
	    //ori.transform.position = start_point[0].transform.position;
		// Debug.Log(start_point.Length);
		// Debug.Log(start_point[0]);
		perubahan_speed = new float[jumlah_agen];  
		
	
		
	}
	void Start()
	{
        
		target = jalan.points;		
		agents.SetDestination(titik_ori.position);
		//StartCoroutine(waitspawner(jumlah_agen));	
		StartCoroutine(waitspawner(jumlah_agen));	
		
                
	}
    void FixedUpdate() {

		//StartCoroutine(waitspawner(jumlah_agen));	
		
		
	}
	void Update()
	{
        

		// countdown -= Time.deltaTime;
		count = 0;
		StartCoroutine(delay(waktu_delay));
		//velo = agents.velocity.magnitude;
		
		foreach (float i in kec_tampung)
		{
			count = count + i;
		}

		
		// kec_cek = kec_tampung[0];
		// count = velo + kec_cek;
        velo_s = count / (agent_velo.Length);          	
		

	}

	
	IEnumerator waitspawner(int N)
    {
		//yield return new WaitForSeconds (startWait); 
		
		
		for (int i=0 ; i<N ; i++)
		{			       
			
			//home = GameObject.FindWithTag("HOME").transform;
			perubahan_speed[i] = Random.Range(-1,2);
			rand_start = Random.Range(0, start_point.Length);
			mobil = Instantiate (pemain, start_point[rand_start].position, start_point[rand_start].rotation);
			rand = Random.Range(0,4);
			agents_clone = mobil.GetComponent<NavMeshAgent>();
			agents_clone.speed = speed + perubahan_speed[i];
			agents_clone.SetDestination(target[rand].position);
			agent_velo[i] = agents_clone;
			
			
			// Vector3 pos =  mobil.transform.position - previousPosition;
			// kec_tampung[i] = pos.magnitude;
			// previousPosition = mobil.transform.position;
			
			
			yield return new WaitForSeconds (startWait); 
			

		}
		
	
       
    }

    private IEnumerator delay(float time)
    {
		
		if (isCoroutineExecuting)
			//check = true;
        	yield break;
			check = false;
		isCoroutineExecuting = true;
    	
		yield return new WaitForSeconds(time);

        for (int i = 0; i < agent_velo.Length; i++)
        {
            kec_tampung[i] = agent_velo[i].velocity.magnitude;

        }
		
		isCoroutineExecuting = false;
		check = true;
		
    }
}
