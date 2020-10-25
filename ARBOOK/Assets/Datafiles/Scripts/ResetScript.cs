using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour {
	Vector3 originalpos;
	// Use this for initialization
	void Start () {
		originalpos = transform.localPosition;

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider collide){
		if (collide.gameObject.CompareTag ("SHIPWALL")) {
			transform.localPosition = originalpos;
		}
		else if (collide.gameObject.CompareTag ("AEROPLANEWALL")) {
			transform.localPosition = originalpos;
		}
		else if (collide.gameObject.CompareTag ("CLOUDWALL")) {
			transform.localPosition = originalpos;
		}
	}
}
