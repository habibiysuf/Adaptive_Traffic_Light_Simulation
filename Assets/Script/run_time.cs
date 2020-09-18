using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class run_time : MonoBehaviour
{
    public int cek;
    public static int runtime;
    TMP_InputField inputField;
    string a;
    void Start() {
        inputField = gameObject.GetComponent<TMP_InputField>();
        cek = 100;
        runtime = 100;
    }
    public void change()
    {
        a = inputField.text;
        runtime = int.Parse(a);
        cek = runtime;
    }
}
