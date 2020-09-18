using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tes_tabrak : MonoBehaviour
{
    // Start is called before the first frame update
    bool chek = false;
    void OnTriggerEnter(Collider other) {
        chek = true;
    }
    void OnTriggerExit(Collider other) {
        chek = false;
    }
}
