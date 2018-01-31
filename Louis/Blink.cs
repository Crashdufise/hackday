using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour {

    public float delay;

	// Use this for initialization
	void Start () {
        delay = 0;
	}
	
	// Update is called once per frame
	void Update () {
        delay += 1;
        if (delay > 90)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            delay = 0;
        }
        if (delay == 45)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
