using UnityEngine;
using System.Collections;

public class GoalScript : MonoBehaviour 
{
	//Variables for floating
	bool isUp;
	public int currentLevel;

	// Use this for initialization
	void Start () 
	{
		//For floating
		isUp = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//For floating
		if (isUp) 
		{
			//Float upwards
			StartCoroutine(floatingUp());
		}
		else if (!isUp) 
		{
			//Float downwards
			StartCoroutine(floatingDown());
		}
	}

	//Floating functions
	IEnumerator floatingUp()
	{
		//Move up
		transform.Translate (new Vector3 (0f, 1f, 0f) * Time.deltaTime);
		//Wait 1 second continuing
		yield return new WaitForSeconds(1f);
		isUp = false;
	}

	IEnumerator floatingDown()
	{
		//Move down
		transform.Translate (new Vector3 (0f, -1f, 0f) * Time.deltaTime);
		//Wait 1 second before continuing
		yield return new WaitForSeconds(1f);
		isUp = true;
	}

	void OnTriggerEnter(Collider colObj)
	{
		if (colObj.gameObject.tag == "Player") 
		{
			Application.LoadLevel((currentLevel + 1));
		}
	}


}
