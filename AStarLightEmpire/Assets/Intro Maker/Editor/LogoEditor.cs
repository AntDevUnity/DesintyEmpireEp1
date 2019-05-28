/// IntroMaker V1 - By Vector Software - http://www.vectorsoft.co.uk/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


/// <summary>
/// This is the gui-based add-on, that lets you visually set up 
/// the logos to display, and change their parameters within
/// the unity's own gui system.
/// </summary>
public class LogoEditor : EditorWindow
{

    /// <summary>
    /// This is the entry-point for the tool within Unity's GUI.
    /// </summary>
    [MenuItem("Vector Software/Intro Maker")]
    public static void ShowWindow()
    {
        ///Creates the tool window.
        var win = EditorWindow.GetWindowWithRect(typeof(LogoEditor), new Rect(50, 50, 500, 350));
    }

    /// <summary>
    /// The current Intro being edited.
    /// </summary>
    public LogoCollection Logos = null;
   
    /// <summary>
    /// This draws the tools UI, using unity's built in UI system.
    /// </summary>
    private void OnGUI()
    {


        

        ///Begin rendering the ui.
        EditorGUILayout.BeginVertical();

        EditorGUILayout.BeginHorizontal();

        GUILayout.Label("Edit Logo");
        Logos = EditorGUILayout.ObjectField(Logos, typeof(LogoCollection)) as LogoCollection;


        EditorGUILayout.EndHorizontal();

        ///If there is a intro assigned, draw the ui that lets you edit it.
        if (Logos != null)
        {

            int logo_num = 0;


            ///Enumerate through the logos, so they can be edited after creation.
            foreach(var ele in Logos.Logos)
            {

                GUILayout.Label("Logo " + logo_num);
                EditorGUILayout.BeginHorizontal();
                ele.LogoImage = EditorGUILayout.ObjectField(ele.LogoImage, typeof(Texture2D)) as Texture2D;
                if (GUILayout.Button("Clear"))
                {
                    ele.LogoImage = null;
                }
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();


                GUILayout.Label("Initial Lum");
                ele.InitialLum = EditorGUILayout.FloatField(ele.InitialLum);
                GUILayout.Label("Initial Size");
                ele.InitialSize = EditorGUILayout.FloatField(ele.InitialSize);


                EditorGUILayout.EndHorizontal();

                EditorGUILayout.BeginHorizontal();

                GUILayout.Label("Lum Mod");
                ele.LumMod = EditorGUILayout.FloatField(ele.LumMod);

                GUILayout.Label("Size Mod");
                ele.SizeMod = EditorGUILayout.FloatField(ele.SizeMod);

                EditorGUILayout.EndHorizontal();


            }


            ///The button that lets you add a new logo to the intro.
            if(GUILayout.Button("Add Logo"))
            {

                var new_ele = ScriptableObject.CreateInstance("LogoElement") as LogoElement;

                Logos.AddLogo(new_ele);

            }

        }

        Logos.NextScene = EditorGUILayout.IntField(Logos.NextScene);


        EditorGUILayout.EndVertical();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
