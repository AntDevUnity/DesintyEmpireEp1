using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class LogoEditor : EditorWindow
{

    [MenuItem("Empire/Logo Editor")]
    public static void ShowWindow()
    {
        var win = EditorWindow.GetWindowWithRect(typeof(LogoEditor), new Rect(50, 50, 500, 350));
    }

    public LogoCollection Logos = null;
   

    private void OnGUI()
    {

        EditorGUILayout.BeginVertical();

        EditorGUILayout.BeginHorizontal();

        GUILayout.Label("Edit Logo");
        Logos = EditorGUILayout.ObjectField(Logos, typeof(LogoCollection)) as LogoCollection;


        EditorGUILayout.EndHorizontal();

        if (Logos != null)
        {

            int logo_num = 0;

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

            if(GUILayout.Button("Add Logo"))
            {

                var new_ele = ScriptableObject.CreateInstance("LogoElement") as LogoElement;

                Logos.AddLogo(new_ele);

            }

        }


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
