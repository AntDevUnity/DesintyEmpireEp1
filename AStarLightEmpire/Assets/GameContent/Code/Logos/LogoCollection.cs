using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoCollection : MonoBehaviour
{

    public List<LogoElement> Logos; //= new List<LogoElement>();
    public int NextScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddLogo(LogoElement ele)
    {

        Logos.Add(ele);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
