using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A ATTACHER A L'ECRAN D'ACCUEIL //

public class demarrer : MonoBehaviour {

    public Valve.VR.InteractionSystem.Hand hand1;
    public Valve.VR.InteractionSystem.Hand hand2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (hand1.GetStandardInteractionButtonDown() || hand2.GetStandardInteractionButtonDown())
        {

        }
	}
}
