using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOver : MonoBehaviour 
{
	//Variables
	public Text pName;

	// Use this for initialization
	void Start () 
	{
		//Debug.Log(gameInfo.playerName);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gameInfo.playerName == "Enter Name") 
		{
			gameInfo.playerName = "Noob";
		}
		pName.text = "Get Skrekt " + gameInfo.playerName;
	}
	
	//Function for button press
	public void ReplayPressed()
	{
		Application.LoadLevel (1);
	}

	//Function for button press
	public void MainMenuPressed()
	{
		Application.LoadLevel (0);
	}
}
