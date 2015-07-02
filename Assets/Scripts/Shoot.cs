using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour 
{
	//Variables
	public GameObject bullet;
	public GameObject fire;
	public GameObject player;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		//If mouse button is pressed
		if (Input.GetMouseButton (0)) 
		{
			//Instantiate(bullet,transform.position,Quaternion.identity);

			//Move the player in the opposite direction when shot
			player.GetComponent<Rigidbody> ().AddForce (transform.up * 5000);

			//For flame
			fire.SetActive (true);
		} 
		else 
		{
			fire.SetActive(false);
		}

	}

}
