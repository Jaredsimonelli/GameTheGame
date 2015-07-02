using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour 
{
	//Variables
	public GameObject destroyedBody;
	public GameObject explosion;
	public bool destroyed;

	// Use this for initialization
	void Start () 
	{
		destroyed = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (destroyed) 
		{
			Destroy(this.transform.parent.gameObject);
			Instantiate(destroyedBody, transform.position, Quaternion.identity);
			Instantiate(explosion, transform.position, Quaternion.identity);
		}
	}

	//For Destroying player
	void OnTriggerEnter(Collider collider)
	{
		//If you collide with anything "Bad" then player is dead
		if (collider.gameObject.tag == "Bad") 
		{
			destroyed = true;
		}
	}


}
