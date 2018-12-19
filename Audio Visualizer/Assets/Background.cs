using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public float scale = 10;
  
    // Use this for initialization
    void Start () {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.parent = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        

            //transform.localScale = new Vector3(1, 1 + AudioAnalyzer. * scale, 1);
       
    }
}
