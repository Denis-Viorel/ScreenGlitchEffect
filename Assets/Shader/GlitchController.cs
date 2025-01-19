using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlitchController : MonoBehaviour
{
    public Material mat;
    public float noiseAmount;
    public float glitchAmount;
    public float scanLinesStrength;

    // Update is called once per frame
    void Update()
    {
        mat.SetFloat("_NoiseAmount", noiseAmount);
        mat.SetFloat("_GlitchAmount", glitchAmount);
        mat.SetFloat("ScanLinesStrength", scanLinesStrength);
    }
}
