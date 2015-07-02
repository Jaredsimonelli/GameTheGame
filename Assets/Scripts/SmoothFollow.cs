using UnityEngine;
using System.Collections;


public class SmoothFollow : MonoBehaviour 
{
	public Transform target;
	
	// Update is called once per frame
	void LateUpdate() 
	{
		if (target != null) 
		{
			transform.position = new Vector3 (target.position.x, target.position.y, target.position.z - 250);
		}
	}
}
