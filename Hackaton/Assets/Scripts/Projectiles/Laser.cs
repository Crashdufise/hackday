using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser: MonoBehaviour
{
    public GameObject Player;
    public int speed = 200;
    public GameObject Las;
	public Valve.VR.InteractionSystem.Hand hand;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Camera cam = Player.GetComponent<Camera>();
		if(hand.GetStandardInteractionButtonDown()) {
            Rigidbody instance;
			instance = Instantiate(Las.GetComponent<Rigidbody>(), cam.transform.position, cam.transform.rotation) as Rigidbody;
            instance.AddForce(cam.transform.forward * speed);
        }

    }
}
