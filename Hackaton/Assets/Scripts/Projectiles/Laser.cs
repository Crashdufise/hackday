using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser: MonoBehaviour
{
    public GameObject Player;
    public int speed = 200;
    public GameObject Las;
    private float timeCurrent = 0.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Camera cam = Player.GetComponent<Camera>();
        if(Input.GetKeyDown(KeyCode.Space)) {
            Rigidbody instance;
            instance = Instantiate(Las.GetComponent<Rigidbody>(), cam.transform.position, Quaternion.identity) as Rigidbody;
            instance.AddForce(cam.transform.forward * speed);
        }

    }
}
