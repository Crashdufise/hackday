using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciation : MonoBehaviour {

	[Range (1, 50)]
	public int speed = 25;
	[Range (0.2f, 2.0f)]
	public float delay = 1.0f;
	private float timeCurrent = 0.0f;

	public Transform player;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

		//S'execute tous les delay
		if (timeCurrent+delay < Time.fixedTime)
		{
			//Instanciation d'un projectile
			Rigidbody instance;

			//Position du FP
			var playerPos = player.position;

			//Position somewhere au dessus du terrain in a cube -10.0 and 10.0
			Vector3 pos = new Vector3(Random.Range(-58.0f, -13.0f), Random.Range(0.0f, 20.0f), Random.Range(-33.0f, 13.0f));
			instance = Instantiate((GameObject.Find("Projectile")).GetComponent<Rigidbody>(), pos, Random.rotation) as Rigidbody;

			//Application d'une force au projectile instance
			//Vecteur force en direction d'une zone autour du player
			Vector3 dir = playerPos - instance.transform.position + new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(-2.0f, 2.0f), Random.Range(-2.0f, 2.0f));;
			instance.AddForce(dir * speed);

			timeCurrent = Time.fixedTime;

		}
	}
}
