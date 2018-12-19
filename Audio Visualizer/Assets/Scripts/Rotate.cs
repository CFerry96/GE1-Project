using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float rotateSpeedX = 1;
    public float rotateSpeedY = 1;
    public float rotateSpeedZ = 1;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(rotateSpeedX, rotateSpeedY, rotateSpeedZ);
    }
}
