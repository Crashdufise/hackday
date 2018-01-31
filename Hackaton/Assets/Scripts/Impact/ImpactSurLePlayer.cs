using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactSurLePlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	//Impact du projectile avec un autre object
	void OnTriggerEnter(Collider col) {
		Debug.Log (col.gameObject.name);
		//Si cet object est le player
		if (col.gameObject.name == "HeadCollider" || col.gameObject.name == "BodyCollider") {
			GetComponentInChildren<AudioSource>().Play();
		}	
	}
}
