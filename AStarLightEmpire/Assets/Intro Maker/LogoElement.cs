using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class contains all the info required
/// for each logo.
/// </summary>
public class LogoElement : ScriptableObject
{

    /// <summary>
    /// The Logo image.
    /// </summary>
    public Texture2D LogoImage = null;

    /// <summary>
    /// The parameters that define how it will be
    /// presented and change.
    /// </summary>
    public float InitialLum = 1.0f;
    public float InitialSize = 1.0f;
    public float Size = 0, lum = 0;
    public float SizeMod = 1.02f;
    public float LumMod = 0.97f;
    public float Life = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
