using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resulation : MonoBehaviour
{
    
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        Screen.SetResolution(Screen.currentResolution.width/2, Screen.currentResolution.height/2, true);
    }

   
}
