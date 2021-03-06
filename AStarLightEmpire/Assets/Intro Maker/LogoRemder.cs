﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// The LogoRender class, is the class that will take the data you've
/// entered with the main gui-based tool, render the logos and then load the next
/// scene as requested.
/// </summary>
public class LogoRemder : MonoBehaviour
{
    /// <summary>
    /// This is the logo data generated by the gui Intro Maker tool.
    /// </summary>
    public LogoCollection Logos;

    /// <summary>
    /// This is the current logo being displayed
    /// </summary>
    public int LogoNum = 0;

    /// <summary>
    /// If true, this is the first logo.
    /// </summary>
    public bool first = true;

    // Start is called before the first frame update
    void Start()
    {
        ///Reset logo num back to zero.
        LogoNum = 0;
        
    }

    private void OnGUI()
    {
        ///Do some checks to see if all the logos have been rendered.
        if (LogoNum >= Logos.Logos.Count) return;
        if (Logos == null) return;
        

        ///Get the current logo
        var cur_logo = Logos.Logos[LogoNum];


        ///Render it properly.
        var draw_r = new Rect(0, 0, 0, 0);

        float dx = 0;
        float dy = 0;
        float dw = Screen.width;
        float dh = Screen.height;

        float incx = cur_logo.Size;
        float incy = cur_logo.Size;

        dx = dx - incx;
        dy = dy - incy;
        dw = dw + incx * 2;
        dh = dh + incy * 2;

        ///Render it properly.
        GUI.color = new Color(cur_logo.lum, cur_logo.lum, cur_logo.lum, cur_logo.lum);
        GUI.DrawTexture(new Rect(dx,dy,dw,dh), cur_logo.LogoImage);
     
    }

    // Update is called once per frame
    void Update()
    {


        ///Checks to see if all logos have been rendered
        ///If so, it will load the next scene if specified.
        if (LogoNum >= Logos.Logos.Count)
        {
            if (Logos.NextScene != -1)
            {
                ///LoadSceneScript.LoadIndex = 0;

                UnityEngine.SceneManagement.SceneManager.LoadScene(Logos.NextScene);
            }
        }

        ///Get the current Logo.
        var cur_logo = Logos.Logos[LogoNum];


        ///If First update, set to initial state.
        if (first)
        {
            first = false;
            cur_logo.Size = cur_logo.InitialSize;
            cur_logo.lum = cur_logo.InitialLum;
        }

        ///Updat the logo parameters.
        cur_logo.Size += cur_logo.SizeMod;
        cur_logo.lum *= cur_logo.LumMod;


        ///Check to see if the logo has finished.
        if(cur_logo.lum<0.01f)
        {

            //Change to the next logo and reset initial state.
            first = true;
            LogoNum++;
       
            

        }


    }
}
