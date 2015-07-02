using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour 
{
	//Variables
	float startTime;
	float timer;

	// Use this for initialization
	void Start () 
	{
		startTime = Time.time;
		timer = 4;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Time.time - startTime > timer) 
		{
			Destroy(this.gameObject);
		}
	}
}
