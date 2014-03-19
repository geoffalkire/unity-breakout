using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	public KeyCode MoveLeft;
	public KeyCode MoveRight;
	public float Speed = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mousePositionInScreen = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = new Vector3(mousePositionInScreen.x, transform.position.y, transform.position.z);
	}

	//called when item is collided with
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.tag == "Ball") {
			var newXVelocity = calculateReboundValue(collision.transform.position.x);
			Debug.Log ("Looking at collider " + collision.collider.tag);
			collision.collider.rigidbody2D.velocity = new Vector2(newXVelocity, collision.collider.rigidbody2D.velocity.y);
		}
	}

	private float calculateReboundValue(float locationX)
	{
		//Debug.Log ("collider2d = " + collider2D);
		BoxCollider2D collider = (BoxCollider2D)collider2D;

		var leftSide = transform.position.x - (collider.size.x / 2);
		var rightSide = transform.position.x + (collider.size.x / 2);
		float topRatio = Mathf.Abs (locationX - leftSide);
		float bottomRatio = Mathf.Abs (rightSide - leftSide);
		float ratio = Mathf.Abs (transform.position.x - leftSide) / Mathf.Abs (rightSide - leftSide);
		Debug.Log ("Calculated ratio is " + topRatio + "/" + bottomRatio);

		float range = 5f;
		float increment = 1f;
		//float bottomValue = -7.5f;

		//return value between -5 and 5
		return (ratio * range) - (range/2);
	}

}
