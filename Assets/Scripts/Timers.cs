using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timers : MonoBehaviour 
{
	//Variables
	float startTimer;
	public Text textTime;
	public GameObject player;

	// Use this for initialization
	void Start () 
	{
		startTimer = Time.time;
	}

	// Update is called once per frame
	void Update () 
	{
		//Check if the player has been destroyed
		if (player.gameObject != null) 
		{
			//If it hasn't then run timer
			if (!player.GetComponent<CollisionScript> ().destroyed) 
			{
				//Get current time
				float curTime = Time.time - startTimer;

				//Calc minutes, seconds, milliseconds
				int minutes = (int)(curTime / 60);
				//Turn minutes into string
				string minText = minutes.ToString ();
				int seconds = (int)(curTime % 60);
				//Turn seconds into string
				string secText = seconds.ToString ();
				int milliSeconds = (int)((curTime * 100) % 100);
				//Turn milliSeconds into string
				string millText = milliSeconds.ToString ();

				//Print
				if(seconds < 10)
				{
					textTime.GetComponent<Text> ().text = minText + " : 0" + secText + " . " + millText;
				}
				else
				{
					textTime.GetComponent<Text> ().text = minText + " : " + secText + " . " + millText;
				}

			}
		}


	}
}
