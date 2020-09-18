using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pos_wally_data_wt : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform pindah;
    void OnTriggerEnter(Collider other) {   
                    
        if (other.gameObject.tag == "hit_wall_y2")
        {
            this.transform.localPosition = pindah.localPosition;
            
            
        }      
        else 
        {          
            return ;
        }

    }
    
}
