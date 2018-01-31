using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciation : MonoBehaviour {

	int speed = 50;
	private float delay = 0.5f;
	private float timeCurrent = 0.0f;

	// Use this for initialization
	void Start () {
		Rigidbody rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

		//S'execute tous les delay
		if (timeCurrent+delay < Time.fixedTime)
		{
			//Instanciation d'un projectile
			Rigidbody instance;

			//Position du FP
			var playerObject = GameObject.Find("FP Controller");
			var playerPos = playerObject.transform.position;

			//Position somewhere in a cube -10.0 and 10.0
			Vector3 pos = playerPos +  new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f));

			//Application d'une force au projectile
			instance.AddForce(instance.transform.forward * speed);

			timeCurrent = Time.fixedTime;

		}
	}
}
