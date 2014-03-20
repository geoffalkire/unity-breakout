using UnityEngine;
using System.Collections;

public class BreakoutGameBehavior : MonoBehaviour {
	public Transform BrickPrefab;
	public Vector2 BrickSetOffset;
	public float BrickWidth;
	public float BrickHeight;
	public int BrickXCount;
	public int BrickYCount;

	// Use this for initialization
	void Start () 
	{
		InitializeBricks();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	private void InitializeBricks()
	{
		//create a set of 10 bricks across the top
		for (var i = 0; i < BrickXCount; i++) 
		{
			for(var j = 0; j < BrickYCount; j++)
			{
				Vector3 BrickLocation = new Vector3(i * BrickWidth * BrickPrefab.localScale.x + BrickSetOffset.x,
				                                    BrickSetOffset.y - j * BrickHeight * BrickPrefab.localScale.y,
				                                    0);
				var brickInstance = (Transform)Instantiate (BrickPrefab, BrickLocation, Quaternion.identity);
				brickInstance.GetComponent<BrickDestruction>().SetRandomColor();
			}
		}

	}
}
