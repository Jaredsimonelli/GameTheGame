using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour 
{
	//Variables

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	//Function for button press
	public void Pressed()
	{
		Application.LoadLevel (1);
	}


}
