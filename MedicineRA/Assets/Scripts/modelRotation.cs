using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelRotation : MonoBehaviour {

	public float rotationSpeed;
	public bool rotate;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		if(rotate)
		{
			gameObject.transform.Rotate(new Vector3(0, rotationSpeed, 0));
		}
	}
}
