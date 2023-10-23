using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookBehindScript : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)) 
        {  
            cam1.enabled = false;
            cam2.enabled = true;
        
        }
        if(Input.GetKeyUp(KeyCode.F)) 
        {  
            cam1.enabled = true;
            cam2.enabled = false;
        
        }
    }
}
