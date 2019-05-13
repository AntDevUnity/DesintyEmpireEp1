using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoRemder : MonoBehaviour
{

    public LogoCollection Logos;

    public int LogoNum = 0;
    public bool first = true;

    // Start is called before the first frame update
    void Start()
    {

        LogoNum = 0;
        
    }

    private void OnGUI()
    {
        if (LogoNum >= Logos.Logos.Count) return;
        if (Logos == null) return;
        Debug.Log("Yep");
        var cur_logo = Logos.Logos[LogoNum];

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


        GUI.color = new Color(cur_logo.lum, cur_logo.lum, cur_logo.lum, cur_logo.lum);
        GUI.DrawTexture(new Rect(dx,dy,dw,dh), cur_logo.LogoImage);
     
    }

    // Update is called once per frame
    void Update()
    {


        if (LogoNum >= Logos.Logos.Count)
        {
            if (Logos.NextScene != -1)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(Logos.NextScene);
            }
        }
        var cur_logo = Logos.Logos[LogoNum];

        if (first)
        {
            first = false;
            cur_logo.Size = cur_logo.InitialSize;
            cur_logo.lum = cur_logo.InitialLum;
        }

        cur_logo.Size += cur_logo.SizeMod;
        cur_logo.lum *= cur_logo.LumMod;

        if(cur_logo.lum<0.01f)
        {
            first = true;
            LogoNum++;
       
            

        }


    }
}
