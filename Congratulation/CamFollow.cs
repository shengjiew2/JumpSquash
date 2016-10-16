using UnityEngine;
using System.Collections;

public class CamFollow : MonoBehaviour {
    public GameObject unit;
    public Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - unit.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = unit.transform.position + offset;
	}
}
