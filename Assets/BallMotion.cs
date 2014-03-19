using UnityEngine;
using System.Collections;

public class BallMotion : MonoBehaviour {
	public float Speed = 10;
	// Use this for initialization
	void Start () {
		rigidbody2D.AddForce(new Vector2 (0, -1 * Speed));
	}
	
	// Update is called once per frame
	void Update () {
		//rigidbody2D.AddForce(new Vector2 (0, -1));
	}




}
