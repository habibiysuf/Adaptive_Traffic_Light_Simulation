using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;
using System;

public class Data_Rata2_Pos1 : MonoBehaviour
{
    // Start is called before the first frame update
    public int cuplik;
    Text ftext;
    float countdown = 1;
    public float kec;
    public float kec_x;
    
    public float count; 
    float waktu;
    //////////////////////////
    private List<string[]> rowData = new List<string[]>();
    //////////////////////////
    void Start()
    {
        ftext = GetComponent<Text>();
        string[] rowDataTemp = new string[2];
        rowDataTemp[0] = "TIme";
        rowDataTemp[1] = "Kecepatan Rata-Rata Pos 1";
        rowData.Add(rowDataTemp);
        waktu = 0f;
        
        
    }
    // Update is called once per frame
    void Update()
    {
     
       count = counter.hitung_1;
       kec = move.velo;
       kec_x = move.velo_s;
       ftext.text = "Antrian Traffic 1 : " + count.ToString(); 
       if (countdown <= 0f)
		{
			//Debug.Log(count);
            //Debug.Log("kec velo 0 : "+ kec);
            waktu += 1;
            Debug.Log("kec clone Rata2  : "+kec_x);
            string[] rowDataTemp = new string[2];
            rowDataTemp[0] = waktu.ToString();
            rowDataTemp[1] = kec_x.ToString();
            rowData.Add(rowDataTemp);
            string[][] output = new string[rowData.Count][];

            for(int i = 0; i < output.Length; i++){
                output[i] = rowData[i];
            }

            int  length  = output.GetLength(0);
            string delimiter = ",";

            StringBuilder sb = new StringBuilder();
            
            for (int index = 0; index < length; index++)
                sb.AppendLine(string.Join(delimiter, output[index]));
            
            
            string filePath = getPath();

            StreamWriter outStream = System.IO.File.CreateText(filePath);
            outStream.WriteLine(sb);
            outStream.Close();
            countdown = 1;
		}

		countdown -= Time.deltaTime;

    }
        private string getPath(){
        //if UNITY_EDITOR
        return Application.dataPath +"/CSV/"+"Data Kecepatan Rata2 Pos 1.csv";
        // #elif UNITY_ANDROID
        // return Application.persistentDataPath+"Saved_data.csv";
        // #elif UNITY_IPHONE
        // return Application.persistentDataPath+"/"+"Saved_data.csv";
        // else
        // return Application.dataPath +"/"+"Saved_data.csv";
        //#endif
    }
    
}
