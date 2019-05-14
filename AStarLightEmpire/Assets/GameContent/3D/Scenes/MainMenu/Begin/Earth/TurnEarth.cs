using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnEarth : MonoBehaviour
{

    public Vector3 Turn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Turn, Space.Self);    
    }
}
