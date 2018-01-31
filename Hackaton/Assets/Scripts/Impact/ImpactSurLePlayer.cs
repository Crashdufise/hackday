using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactSurLePlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	//Impact du projectile avec un autre object
	void OnTriggerEnter(Collider col) {

		//Si cet object est le player
		if (col.gameObject.name == "HeadCollider") {
			GetComponentInChildren<AudioSource>().Play();
			Debug.Log ("Impact");
		}
	}
}
