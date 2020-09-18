using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//[RequireComponent(typeof(Enemy))]
public class move : MonoBehaviour
{
	public Transform Targetpos;
    private Transform[] target;
	//private int wavepointIndex = 0;
    public float maksimal;
	public float minimal;
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
	public int jumlah_agen;
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
	public GameObject end_point;
	public static int jumlah_kopi;
	//public Transform titik_ori;
	void Awake() 
	{
		//startWait = 1f;
		jumlah_kopi = jumlah_agen;
		target = new Transform[Targetpos.transform.childCount];
		for (int i = 0; i < target.Length; i++)
		{
			target[i] = Targetpos.transform.GetChild(i);
		}
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
		
		
	
		
	}
	void Start()
	{
        minimal = minimum_speed.speed_min;
		maksimal = maximum_speed.speed_mak;
		perubahan_speed = new float[jumlah_agen];
		//agents.SetDestination(titik_ori.position);
		//StartCoroutine(waitspawner(jumlah_agen));	
		StartCoroutine(waitspawner(jumlah_agen));	
		
                
	}
    void FixedUpdate() {

		//StartCoroutine(waitspawner(jumlah_agen));	
		
		
	}
	void Update()
	{
        

		// countdown -= Time.deltaTime;
		

	}

	
	IEnumerator waitspawner(int N)
    {
		//yield return new WaitForSeconds (startWait); 
		
		
		for (int i=0 ; i<N ; i++)
		{			       
			float speed = 0f;
			//home = GameObject.FindWithTag("HOME").transform;
			perubahan_speed[i] = Random.Range(minimal,maksimal);
			mobil = Instantiate (pemain, this.transform.position, this.transform.rotation);
			rand = Random.Range(0,target.Length);
			agents_clone = mobil.GetComponent<NavMeshAgent>();
			agents_clone.speed = speed + perubahan_speed[i];
			agents_clone.acceleration = maximum_accel.accel;
			agents_clone.SetDestination(target[rand].position);
			
			
			
			// Vector3 pos =  mobil.transform.position - previousPosition;
			// kec_tampung[i] = pos.magnitude;
			// previousPosition = mobil.transform.position;
			
			
			yield return new WaitForSeconds (startWait); 
			

		}
		
	
       
    }

    
}

