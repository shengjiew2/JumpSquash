using UnityEngine;
using System.Collections;

public class RandomBounce : MonoBehaviour {

    public GameObject unit;
    private GameObject body;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {


        body = unit.GetComponent<bouncyController>().body;

        rb = body.GetComponent<Rigidbody>();
	
	}
    public float speed = 3;
    void jump()
    {
        //body.GetComponent<RigidBody>().velocity = Vector3.up * speed;
        rb.velocity = Vector3.up* speed;
        print("jumping!");
    }
	
	// Update is called once per frame
	void Update () {

        if (body.transform.position.y <= .5) 
        jump();

    }
}
