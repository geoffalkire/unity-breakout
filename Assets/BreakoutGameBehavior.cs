using UnityEngine;
using System.Collections;

public class BreakoutGameBehavior : MonoBehaviour {
	public Transform BrickPrefab;
	public Vector2 BrickSetOffset;
	public float BrickWidth;
	// Use this for initialization
	void Start () {
		InitializeBricks();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void InitializeBricks()
	{
		//create a set of 10 bricks across the top
		for (var i = 0; i < 10; i++) {
			var brickInstance = (Transform)Instantiate (BrickPrefab, new Vector3(i * BrickWidth * BrickPrefab.localScale.x + BrickSetOffset.x, BrickSetOffset.y, 0), Quaternion.identity);
			brickInstance.GetComponent<BrickBehavior>().SetRandomColor();
				}

	}
}
