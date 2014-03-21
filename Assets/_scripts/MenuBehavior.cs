using UnityEngine;
using System.Collections;

public class MenuBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnGUI()
	{
		if (GUI.Button (new Rect (Screen.width/2f - 40f, Screen.height/2f - 10f, 80, 20), "Play")) 
		{
			Application.LoadLevel ("breakoutGame");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
