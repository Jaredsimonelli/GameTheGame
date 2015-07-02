using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour 
{
	//Rotation Variables 
	Vector3 mousePos;
	Vector3 objectPos;
	int angle;

	//Destroy player variables
	bool destroyed;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		//Get mouse position
		mousePos = Input.mousePosition;
		objectPos = Camera.main.WorldToScreenPoint(transform.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;

		//Rotation
		angle = (int)(Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg);
		transform.rotation = Quaternion.Euler(0, 0, angle - 90);

	}


}
