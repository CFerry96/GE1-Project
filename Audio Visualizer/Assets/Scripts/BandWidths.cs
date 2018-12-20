﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandWidths : MonoBehaviour {
    public float scale = 10;
    List<GameObject> elements = new List<GameObject>();
	// Use this for initialization
	void Start () {
        CreateVisualisers();

    }

    public float radius = 50;

    void CreateVisualisers()
    {
        float theta = (Mathf.PI * 2.0f) / (float)AudioAnalyzer.bands.Length;
        for (int i = 0; i < AudioAnalyzer.bands.Length; i++)
        {
            Vector3 p = new Vector3(
                Mathf.Sin(theta * i) * radius
                , 0
                , Mathf.Cos(theta * i) * radius
                );
            p = transform.TransformPoint(p);
            Quaternion q = Quaternion.AngleAxis(theta * i * Mathf.Rad2Deg, Vector3.up);
            q = transform.rotation * q;

            GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            cylinder.transform.SetPositionAndRotation(p, q);
            cylinder.transform.parent = this.transform;
            cylinder.GetComponent<Renderer>().material.color = Color.HSVToRGB(
            i / (float)AudioAnalyzer.bands.Length
                , 1
                , 1
                );
        elements.Add(cylinder);
        }
    }

    // Update is called once per frame
    void Update () {
        for (int i = 0; i < elements.Count; i++) {
            Vector3 ls = elements[i].transform.localScale;
            ls.y = Mathf.Lerp(ls.y, 1 + (AudioAnalyzer.bands[i] * scale), Time.deltaTime * 3.0f);
            elements[i].transform.localScale = ls;
        }
	}
}

/*Color.HSVToRGB(
                i / (float)AudioAnalyzer.bands.Length
                , 1
                , 1
                );
*/