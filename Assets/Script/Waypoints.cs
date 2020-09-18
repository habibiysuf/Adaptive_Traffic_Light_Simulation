using UnityEngine;
using System;
using System.Collections;

namespace traffic
{
	public class Waypoints : MonoBehaviour {
		
		public static Transform[] points;
		System.Random random = new System.Random();
		
		void Awake() 	
		{
			points = new Transform[transform.childCount];
			for (int i = 0; i < points.Length ; i++)
			{
				int R = random.Next(0, points.Length);
				points[i] = transform.GetChild(R);
			}					
		}
		
		

	}
}
