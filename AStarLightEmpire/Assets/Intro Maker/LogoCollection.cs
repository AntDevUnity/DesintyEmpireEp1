using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// This class contains the overall collection
/// of logos for any given intro.
/// </summary>
public class LogoCollection : MonoBehaviour
{

    /// <summary>
    /// Each logo within a list.
    /// </summary>
    public List<LogoElement> Logos; //= new List<LogoElement>();
    /// <summary>
    /// The scene that will load after the logos have been displayed.
    /// </summary>
    public int NextScene;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    /// <summary>
    /// Adds a new logo to the collection.
    /// </summary>
    /// <param name="ele"></param>
    public void AddLogo(LogoElement ele)
    {
        ///Add the new logo.
        Logos.Add(ele);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
