using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BandIdentifier : MonoBehaviour {

    AudioSource Tune;
    public static float[] samples = new float[512];
    public static float[] freqCount = new float[8];

	// Use this for initialization
	void Start () {
        Tune.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        MakeFrequencyBands();

    }

    void MakeFrequencyBands()
    {

        float average = 0;
        int Count = 0;

        for( int i = 0; i < 8; i++)
        {
            int sampleCount = (int)Mathf.Pow(2, i) * 2; //calculete bandwidth

            for (int j = 0; j < sampleCount; j++)
            {
                average += samples[Count] * (Count + 1);
                    Count++;
            }

            average /= Count;

            freqCount[i] = average + 10;
        }

    }
}
