using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

void Update() {
	if (Input.GetMouseButtonDown(0)) {
		gameObject.active = true;
	}
	if (Input.GetMouseButtonDown(1)) {
			gameObject.active = false;
}
	}	
}
