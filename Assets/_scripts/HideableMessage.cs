using UnityEngine;
using System.Collections;

public class HideableMessage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var transformPosition = transform.position;
		transform.position = new Vector3 (transformPosition.x, transformPosition.y, transformPosition.z);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
}
