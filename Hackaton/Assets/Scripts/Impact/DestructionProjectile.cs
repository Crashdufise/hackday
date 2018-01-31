using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionProjectile : MonoBehaviour {
	
	public GameObject destroyedVersion;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider col) {
		
		if (col.gameObject.name == "Projectile(Clone)") {

			Instantiate (destroyedVersion, col.gameObject.transform.position, col.gameObject.transform.rotation);
			Destroy (col.gameObject);
			SteamVR_Controller.Input (3).TriggerHapticPulse (10000);
		}
	}
}
