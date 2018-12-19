using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public float scale = 10;
    List<GameObject> elements = new List<GameObject>();

    // Use this for initialization
    void Start () {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.parent = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < elements.Count; i++)
        {
            elements[i].transform.localScale = new Vector3(1, 1 + AudioAnalyzer.spectrum[i] * scale, 1);
        }
    }
}
