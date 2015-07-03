using UnityEngine;
using System.Collections;

public class ReplayScript : MonoBehaviour 
{
	//Variables
	public GameObject player;

	void awake()
	{
		DontDestroyOnLoad (transform.root.gameObject);
	}

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (player.gameObject != null) 
		{
			if (player.GetComponent<CollisionScript> ().destroyed) 
			{
				//Load replay level
				StartCoroutine (loadLevel ());
			}
		}
	}

	//Call replay screen
	static IEnumerator loadLevel()
	{
		//Wait for 3 seconds before loading
		yield return new WaitForSeconds(1);
		Application.LoadLevel (11);
		
	}
}
