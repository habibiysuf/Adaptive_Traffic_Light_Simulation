using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//[RequireComponent(typeof(Enemy))]
public class Start_acak : MonoBehaviour
{
    private Transform[] target;
	//private int wavepointIndex = 0;
    float speed = 3f;
    NavMeshAgent agents;
	NavMeshAgent agents_clone;
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

	void Awake() 
	{
		// ori= GameObject.CreatePrimitive (PrimitiveType.Cube);
        // ori.AddComponent<Rigidbody>();
        // ori.AddComponent<NavMeshAgent>();		
		agents = pemain.GetComponent<NavMeshAgent>();
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
        
		target = jalan.points;		
		agents.SetDestination(target[1].position);
		StartCoroutine(waitspawner(jumlah_agen));	
		           
                
	}
    
	void Update()
	{
        // check = trigger1.check;
        // Debug.Log(check);
		// Vector3 dir = target.position - transform.position;
		// transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
		// GetNextWaypoint();
        // if (check)
        // {
        //     waveIndex += 1;
        //     target = jalan.points[waveIndex];
        // }
		//tartCoroutine(waitspawner());
		//spawnWait = Random.Range(spawnmax, spawnmin);

		// if (countdown <= 0f)
		// {
		// 	StartCoroutine(waitspawner());  
		// 	countdown = timeBetweenWaves;
		// 	return;
		// }

		// countdown -= Time.deltaTime;
		
            
       		
	}

	// void GetNextWaypoint()
	// {
    //     if (waveIndex > jalan.points.Length - 1)
	// 	{
	// 		EndPath();
	// 		return;
	// 	}
	// 	agents.SetDestination(target.position);	
		
	// }

	// void EndPath()
	// {
	// 	//PlayerStats.Lives--;
	// 	//WaveSpawner.EnemiesAlive--;
	// 	Destroy(gameObject);
	// }

	IEnumerator waitspawner(int N)
    {
		yield return new WaitForSeconds (startWait); 
		
		for (int i=0 ; i<N ; i++)
		{			       
			//home = GameObject.FindWithTag("HOME").transform;
			rand_start = Random.Range(0, start_point.Length);
			GameObject mobil = Instantiate (pemain, start_point[rand_start].position, start_point[rand_start].rotation);
			rand = Random.Range(1,4);
			agents_clone = mobil.GetComponent<NavMeshAgent>();			
			agents_clone.SetDestination(target[rand].position);
			yield return new WaitForSeconds (startWait); 

		}
		
		

		
		// jumlah_agen -= 1;
					
		// jumlah_agen += 1;
		// if (jumlah_agen == 10)
		// {
		// 	start = false;
		// }
		//yield return new WaitForSeconds(startWait);	

		
        
		
		//yield return new WaitForSeconds (spawnWait);
       
    }
}

