using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace traffic
{
public class endpoint : MonoBehaviour
{
	public static Transform[] end;
	System.Random random = new System.Random();
	
	
	void Awake()
	{
		end = new Transform[transform.childCount];
		for (int i = 0; i < end.Length ; i++)
		{
			int E = random.Next(0, end.Length);
			end[i] = transform.GetChild(E);
		}
		/*int E = random.Next(0, end.Length);
		end[0] = transform.GetChild(E);*/


	}
}
}
