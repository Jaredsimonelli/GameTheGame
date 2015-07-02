using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameInfo : MonoBehaviour 
{
	//Variables
	public GameObject UI;
	static public string playerName;
	InputField inpField;

	void awake()
	{
		DontDestroyOnLoad (transform.root.gameObject);
	}

	// Use this for initialization
	void Start ()
	{
		inpField = UI.GetComponent<InputField> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		playerName = inpField.text;

	}

	//Function for input
	/*public void printName()
	{
		Debug.Log (playerName);
	}*/
}
