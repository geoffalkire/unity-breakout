using UnityEngine;
using System.Collections;

public class BallMotion : MonoBehaviour {
	public float Speed = 10;
	public float MaxSpeed = 50;
	// Use this for initialization
	void Start () {
		rigidbody2D.AddForce(new Vector2 (0, -1 * Speed));
	}
	
	// Update is called once per frame
	void Update () {
		//rigidbody2D.AddForce(new Vector2 (0, -1));
		if (_gameOver) {
			Destroy (gameObject);
				}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		//only care about ball collisions
		if (collision.collider.tag != "Paddle") return;

		if (rigidbody2D.velocity.magnitude < MaxSpeed) 
		{
			Debug.Log("Magnitude = " + rigidbody2D.velocity.magnitude);
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x * 1.1f, rigidbody2D.velocity.y * 1.1f);
		}

	}

	private bool _gameOver= false;
	public void EndGame()
	{
		_gameOver = true;
	}




}
