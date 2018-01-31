using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impact : MonoBehaviour {
	
	public GameObject destroyedVersion;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider col) {
		
		if (col.gameObject.name == "Projectile(Clone)") {

			Instantiate (destroyedVersion, col.gameObject.transform.position, col.gameObject.transform.rotation);
			Destroy (col.gameObject);
		}
	}
}
