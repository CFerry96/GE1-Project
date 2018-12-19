﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parameter : MonoBehaviour {

    public int band;
    public float startScale, scaleMultiplier;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale = new Vector3(transform.localScale.x, (BandIdentifier.freqCount[band] * scaleMultiplier) + startScale, transform.localScale.z);
	}
}
