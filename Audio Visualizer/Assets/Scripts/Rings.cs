using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rings : MonoBehaviour {

    public float intensity = 10;
    GameObject cylinder;

    List<GameObject> elements = new List<GameObject>();
	

	void Start ()
    {
        CreateVisualisers();
    }

    public float radius = 50;

    void CreateVisualisers()
    {
        float theta = (Mathf.PI * 2.0f) / (float)AudioAnalyzer.frameSize;
        for (int i = 0; i < AudioAnalyzer.frameSize; i++)
        {
            Vector3 p = new Vector3(
                Mathf.Sin(theta * i) * radius
                , 0
                , Mathf.Cos(theta * i) * radius
                );
            p = transform.TransformPoint(p);
            Quaternion q = Quaternion.AngleAxis(theta * i * Mathf.Rad2Deg, Vector3.up);
            q = transform.rotation * q;

            cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            cylinder.transform.SetPositionAndRotation(p, q);
            cylinder.transform.parent = this.transform;
            //cylinder.GetComponent<Renderer>().material.color = new Color(1f,255f,1f);
            elements.Add(cylinder);
        }
    }

   
    void Update ()
    {
        
        for (int i = 0; i < elements.Count; i++)
        {
            float change = elements[i].transform.localScale.y / 3;

            elements[i].transform.localScale = new Vector3(1, 1 + AudioAnalyzer.spectrum[i] * intensity, 1);
            elements[i].GetComponent<Renderer>().material.color = new Color(0f, change , 0f);
           
        }

        
	}
}
