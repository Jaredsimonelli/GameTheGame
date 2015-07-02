using UnityEngine;
using System.Collections;

public class MoveableObstacle : MonoBehaviour 
{
	//Variables
	public bool moveLeft;
	public bool moveRight;

	int speed;

	// Use this for initialization
	void Start () 
	{
		speed = 4;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//If moving left
		if (moveLeft) 
		{
			//Transform the obstacle left
			transform.Translate(Vector3.left * speed * Time.deltaTime);
			//If the obstacle has reached the edge switch to right
			if(transform.localPosition.x < 11.3)
			{
				moveLeft = false;
				moveRight = true;
			}
		}
		//If moving right
		else if (moveRight) 
		{
			//Transform the obstacle right
			transform.Translate(Vector3.right * speed * Time.deltaTime);
			//If the obstacle has reached the edge switch to left
			if(transform.localPosition.x > 34.9)
			{
				moveLeft = true;
				moveRight = false;
			}
		}
	}
}
