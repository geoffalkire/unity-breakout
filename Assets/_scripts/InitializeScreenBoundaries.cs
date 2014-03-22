using UnityEngine;
using System.Collections;

public class InitializeScreenBoundaries : MonoBehaviour {
	public BoxCollider2D LeftScreen;
	public BoxCollider2D RightScreen;
	public BoxCollider2D TopScreen;
	// Use this for initialization
	void Start () {
		//Vector3 leftScreenPixelPos = new Vector3 (0, Camera.main.pixelHeight / 2, 10);
		//var leftScreenPos = Camera.main.ScreenToWorldPoint (leftScreenPixelPos);
		//leftScreenPos.x+=2;
		//Debug.Log ("left screen pos = " + leftScreenPos);
		//LeftScreen.transform.position = leftScreenPos;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
