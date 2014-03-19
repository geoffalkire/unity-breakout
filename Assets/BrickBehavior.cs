using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BrickBehavior : MonoBehaviour {

	public List<Sprite> AvailableSprites;
	// Use this for initialization
	void Start () {
	
	}

	public void SetRandomColor()
	{
		int randomIndex = Random.Range (0, AvailableSprites.Count - 1);
		//Sprite sprite = (Sprite)Resources.Load ("sprites_7", typeof(Sprite));
		GetComponent<SpriteRenderer>().sprite = AvailableSprites[randomIndex];
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		//only care about ball collisions
		if (collision.collider.tag != "Ball") return;

		Destroy (gameObject);
		//var newXVelocity = calculateReboundValue(collision.transform.position.x, collision.rigidbody.velocity.magnitude);
		//Debug.Log ("Paddle Loc: " + transform.position + " Ball Loc: " + collision.transform.position);
		//Debug.Log ("New X Velocity: " + newXVelocity);
		//collision.collider.rigidbody2D.velocity = new Vector2(newXVelocity, collision.collider.rigidbody2D.velocity.y);
		//collision.collider.rigidbody2D.velocity = CalculateReboundVelocityVector(collision.transform.position, collision.rigidbody.velocity.magnitude);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
