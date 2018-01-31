using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impact : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider col) {
		
		if (col.gameObject.name == "Projectile(Clone)") {
			Destroy (col.gameObject);
		}
	}
}
