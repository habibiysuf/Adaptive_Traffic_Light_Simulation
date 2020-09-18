using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pos_wally_data_kecepatan : MonoBehaviour
{
    public Transform pindah;
    
    void OnTriggerEnter(Collider other) {   
              
        if (other.gameObject.tag == "hit_wall_y")
        {
            this.transform.localPosition = pindah.localPosition;
        }      
        else 
        {          
            return ;
        }

    }
    
}
