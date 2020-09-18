using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    // Start is called before the first frame update
    public float count_game;
    public GameObject end;
    void Update()
    {
        count_game += Time.deltaTime;
        if (count_game > run_time.runtime)
        {
            Time.timeScale = 0;
            end.SetActive(true);
        }
    }
}
