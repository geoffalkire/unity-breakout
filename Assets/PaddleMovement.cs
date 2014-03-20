using UnityEngine;
using System.Collections;

public class PaddleMovement : MonoBehaviour 
{
	
	public float Speed = 10;
	public float MaxAngle = 75;
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
        //only care about ball collisions
	    if (collision.collider.tag != "Ball") return;

		collision.collider.rigidbody2D.velocity = CalculateReboundVelocityVector(collision.transform.position, collision.rigidbody.velocity.magnitude);
	}

	private Vector2 CalculateReboundVelocityVector(Vector2 ballPosition, float ballSpeed)
	{
		BoxCollider2D collider = (BoxCollider2D)collider2D;

		var relativeXIntersect = ballPosition.x - (transform.position.x + (collider.size.x / 2f));
		var normalizedRelativeXIntersect = relativeXIntersect / (collider.size.x / 2f);

		var bounceAngle = normalizedRelativeXIntersect * (Mathf.Deg2Rad * MaxAngle);

		return new Vector2 (ballSpeed * Mathf.Sin (bounceAngle), ballSpeed * Mathf.Cos (bounceAngle));

	}

}
