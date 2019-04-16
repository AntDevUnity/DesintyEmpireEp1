using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoElement : ScriptableObject
{

    public Texture2D LogoImage = null;

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
