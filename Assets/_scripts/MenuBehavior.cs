using UnityEngine;
using System.Collections;

public class MenuBehavior : MonoBehaviour {
	private float _menuOffsetX = Screen.width/2f;
	private float _menuOffsetY = Screen.height/2f;
	// Use this for initialization
	void Start () {
	
	}

	void OnGUI()
	{
		float buttonWidth = 120;
		float buttonHeight = 60;
		float margin = 10;
		if (GUI.Button (new Rect (_menuOffsetX - buttonWidth/2, _menuOffsetY - buttonHeight/2, buttonWidth, buttonHeight), "Play")) 
		{
			Application.LoadLevel ("breakoutGame");
		}

		if (GUI.Button (new Rect (_menuOffsetX - buttonWidth / 2, _menuOffsetY + buttonHeight / 2 + margin, buttonWidth, buttonHeight), "Exit")) 
		{
			Application.Quit();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
