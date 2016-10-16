using UnityEngine;
using System.Collections;

public class Oscillator : MonoBehaviour {
    float timeCounter = 0;
    float speed ;
    float witdth;
    float height;
	// Use this for initialization
	void Start () {
        speed = 0.2f;
        witdth = 2.5f;
        height = 5;
	}

    // Update is called once per frame
    void Update() {
        timeCounter += Time.deltaTime;

        if (timeCounter <= 20)
        { 
        float x = Mathf.Cos(timeCounter) * height;
        float y = 6;
        float z = Mathf.Sin(timeCounter) * witdth;
        transform.position = new Vector3(x, y, z);
        }
        else if (timeCounter <= 40)
        {
            float x = 0;
            float y = 6;
            float z = Mathf.Sin(timeCounter) * witdth;
            transform.position = new Vector3(x, y, z);
        }
        else
        {
            transform.position = new Vector3(0, 6, 0);
        }
        
	}
}
