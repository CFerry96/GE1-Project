using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float sensitivity = 100;
    public float loudness = 0;
    AudioSource _audio;


    void Start()
    {
        _audio = GetComponent<AudioSource>();
        _audio.clip = Microphone.Start(null, true, 10, 44100);
        _audio.loop = true;
        _audio.mute = true;
        while(!(Microphone.GetPosition(null) > 0)) { }
        _audio.Play();
	}
	
	
	void Update ()
    {
        loudness = GetAveragedVolume() * sensitivity;
        if(loudness>8)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(this.GetComponent<Rigidbody>().velocity.x, 4);
        }
	}

    float GetAveragedVolume()
    {
        float[] data = new float[256];
        float a = 0;
        _audio.GetOutputData(data, 0);
        foreach(float s in data)
        {
            a += Mathf.Abs(s);

        }
        return a / 256;
    }

}
