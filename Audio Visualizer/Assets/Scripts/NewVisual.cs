﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewVisual : MonoBehaviour
{
    private const int SAMPLE_SIZE = 1024;

    public float rmsValue;
    public float dbValue;

    public float maxVisualScale = 25.0f;
    public float visualModifier = 50.0f;
    public float smoothSpeed = 10.0f;
    public float keepPercentage = 0.5f;

    private AudioSource source;
    private float[] samples;
    private float[] spectrum;
    private float sampleRate;

    private Transform[] visualList;
    private float[] visualScale;
    public int amnVisual = 10;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        samples = new float[SAMPLE_SIZE];
        spectrum = new float[SAMPLE_SIZE];
        sampleRate = AudioSettings.outputSampleRate;

        Spawn();
    }

    private void Spawn() //Create Visuals
    {
        visualScale = new float[amnVisual];
        visualList = new Transform[amnVisual];
        for(int i = 0; i < amnVisual; i++)
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube) as GameObject;// Spawn Cube
            visualList[i] = go.transform;
            visualList[i].position = Vector3.right * i; // place them 1 away from eachother
        }


    }

    private void Update()
    {
        AnalyzeSound();
        UpdateVisual();
    }

    private void UpdateVisual()
    {
        int visualIndex = 0;
        int spectrumIndex = 0;
        int averageSize = (int)((SAMPLE_SIZE * keepPercentage) / amnVisual); // each cube will have a certain amount of sample

        while(visualIndex < amnVisual)
        {
            int j = 0;
            float sum = 0;
            while (j < averageSize)
            {
                sum += spectrum[spectrumIndex];
                spectrumIndex++;
                j++;
            }

            float scaleY = sum / averageSize * visualModifier;
            visualScale[visualIndex] -= Time.deltaTime * smoothSpeed;
            if(visualScale[visualIndex] < scaleY)
            {
                visualScale[visualIndex] = scaleY;
            }

            if(visualScale[visualIndex] > maxVisualScale)
            {
                visualScale[visualIndex] = maxVisualScale;
            }

            visualList[visualIndex].localScale = Vector3.one + Vector3.up * visualScale[visualIndex];
            visualIndex++;
        }
    }

    private void AnalyzeSound()
    {
        source.GetOutputData(samples, 0);

        //Get The RMS Value
        int i = 0;
        float sum = 0;
        for(; i < SAMPLE_SIZE; i++)
        {
            sum += samples[i] * samples[i];

        }
        rmsValue = Mathf.Sqrt(sum / SAMPLE_SIZE);

        //Get DB Value
        dbValue = 20 * Mathf.Log10(rmsValue / 0.1f);

        // Get sound Spectrum
        source.GetSpectrumData(spectrum, 0, FFTWindow.BlackmanHarris);

        //
    }
}
