using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour 
{
	//Variables
	public int speed;

	// Use this for initialization
	void Start () 
	{
		speed = 80;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//GetComponent<Rigidbody> ().AddForce (new Vector3(0 ,-speed , 0));
		GetComponent<Rigidbody> ().AddForce (transform.up * -speed);
	}
}
