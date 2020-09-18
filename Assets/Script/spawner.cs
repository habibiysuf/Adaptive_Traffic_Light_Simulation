using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] objek;
    public Vector3 spawnValue;
    public float spawnWait;
    public float spawnmax;
    public float spawnmin;
    public int startwait;
    public bool start;
    int rand;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitspawner());
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(spawnmax, spawnmin);
    }
    
    IEnumerator waitspawner()
    {
        yield return new WaitForSeconds (startwait);
        while (!start)
        {
            rand = Random.Range(0,2);
            Vector3 spawnpos = new Vector3(Random.Range(-spawnValue.x, spawnValue.x), 1, Random.Range(-spawnValue.z, spawnValue.z));
            Instantiate (objek[rand], spawnpos + transform.TransformPoint (0,0,0), gameObject.transform.rotation);
            yield return new WaitForSeconds (spawnWait);
        }
    }
}
