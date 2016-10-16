using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
    public float speed = 0.5f;
    float timeCounter = 0;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timeCounter += Time.deltaTime;
        if (timeCounter <= 40)
        {
            transform.Rotate(speed, 0, 0);
        }
        else { transform.rotation = Quaternion.Euler(-10, 0, 0); }
	}
}
