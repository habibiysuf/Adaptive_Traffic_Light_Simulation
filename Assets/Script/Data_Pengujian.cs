using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;
using System;

public class Data_Pengujian : MonoBehaviour
{
    
    public float countdown = 1;
    public float data_berhenti;
    public float data_kecepatan;
    public float data_delay;
       
    public float count; 
    float waktu;
    private string dir;
    //////////////////////////
    private List<string[]> rowData = new List<string[]>();
    //////////////////////////
    void Start()
    {
        make_dir();
        string[] rowDataTemp = new string[4];
        rowDataTemp[0] = "TIme";
        rowDataTemp[1] = "Kecepatan Rata-Rata";
        rowDataTemp[2] = "Total Stop";
        rowDataTemp[3] = "Rata-rata Waiting time";
        
        rowData.Add(rowDataTemp);
        waktu = 0f;
        
        
    }
    // Update is called once per frame
    void Update()
    {
     
       count = counter.hitung_1;
       data_berhenti = total_berhenti.tot;
       data_kecepatan = sensor_kecepatan.kecepatan_rata;
       data_delay = Rata_rata_delay.rata2;
       
       if (countdown <= 0f)
		{
			//Debug.Log(count);
            //Debug.Log("kec velo 0 : "+ kec);
            waktu += 1;
            //Debug.Log("kec clone Rata2  : "+kec_x);
            string[] rowDataTemp = new string[4];
            rowDataTemp[0] = waktu.ToString();
            rowDataTemp[1] = data_kecepatan.ToString();
            rowDataTemp[2] = data_berhenti.ToString();
            rowDataTemp[3] = data_delay.ToString();

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
    private string getPath()
    {        
        return dir;
    }
    void make_dir()
    {
        dir = Directory.GetCurrentDirectory() + "/Data_Pengujian/";
        if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
        string date = System.DateTime.Now.ToString("_yyyy.MM.dd_HH.mm.ss");
        dir = dir + "log" + date + ".csv";
    }
    // private string getPath(){
    //     //if UNITY_EDITOR
    //     return Application.dataPath +"/CSV/"+"Data Kecepatan Rata2.csv";
    //     // #elif UNITY_ANDROID
    //     // return Application.persistentDataPath+"Saved_data.csv";
    //     // #elif UNITY_IPHONE
    //     // return Application.persistentDataPath+"/"+"Saved_data.csv";
    //     // else
    //     // return Application.dataPath +"/"+"Saved_data.csv";
    //     //#endif
    // }
    
}
