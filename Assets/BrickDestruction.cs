using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BrickDestruction : MonoBehaviour {

	public List<Sprite> AvailableSprites;
	// Use this for initialization
	void Start () {
	
	}

	public void SetRandomColor()
	{
		int randomIndex = Random.Range (0, AvailableSprites.Count - 1);

		GetComponent<SpriteRenderer>().sprite = AvailableSprites[randomIndex];
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		//only care about ball collisions
		if (collision.collider.tag != "Ball") return;

		Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
