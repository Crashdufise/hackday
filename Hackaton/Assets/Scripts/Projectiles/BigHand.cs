using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigHand : MonoBehaviour {

	public Valve.VR.InteractionSystem.Hand hand;

	public float min = 0.1f;
	public float max = 0.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (hand.GetStandardInteractionButton ()) {
			transform.localScale *= 1.05f;
			transform.localScale = Mathf.Min (transform.localScale, max);
		} else {
			transform.localScale *= 0.9f;
			transform.localScale = Mathf.Max (transform.localScale, min);
		}
	}
}
