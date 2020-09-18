﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;
using System;
public class Data_Kecepatan_Rata2 : MonoBehaviour
{
    
    Text ftext;
    float countdown = 1;
    float kec_1;
    float kec_2;
    float kec_x;
    
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
        rowDataTemp[1] = "Kecepatan Rata-Rata Semua Agen";
        rowData.Add(rowDataTemp);
        waktu = 0f;
        
        
    }
    // Update is called once per frame
    void Update()
    {
     
       count = counter.hitung_1;
       kec_1 = move.velo_s;
       kec_2 = move_2.velo_s;
       kec_x = (kec_1 + kec_2) / 2 ;
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
        return Application.dataPath +"/CSV/"+"Data Kecepatan Rata2.csv";
        // #elif UNITY_ANDROID
        // return Application.persistentDataPath+"Saved_data.csv";
        // #elif UNITY_IPHONE
        // return Application.persistentDataPath+"/"+"Saved_data.csv";
        // else
        // return Application.dataPath +"/"+"Saved_data.csv";
        //#endif
    }
    
    
}