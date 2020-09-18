using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    // Start is called before the first frame update
   
    public Transform pointprebab;
    [Range(10, 100)]
    public int resolution = 10;
    float i = 0;
    void Awake() {
        Vector3 scale = Vector3.one / 5f;
        Vector3 position;
        //position.y = 0f;
		position.z = 0f;
        while(i < resolution)
        {
            float step = 2f / resolution;
            Transform point = Instantiate(pointprebab);
            //point.localPosition = Vector3.right * ((i + 0.5f) / 5f - 1f);
            position.x = (i + 0.5f) * step - 1f;
            position.y = position.x * position.x;
			point.localPosition = position;
			point.localScale = scale;
            i += 1;

        }
        
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
