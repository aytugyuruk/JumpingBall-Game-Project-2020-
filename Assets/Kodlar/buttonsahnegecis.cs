using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttonsahnegecis : MonoBehaviour
{
    public bool bolum1gecisbutton;
    public Button sv2_, sv3_, sv4_, sv5_, sv6_, sv7_, sv8_, sv9_, sv10_, sv11_, sv12_, sv13_, sv14_, sv15_, sv16_, sv17_, sv18_, sv19_, sv20_, sv21_; 
    void Start()
    {
        Application.targetFrameRate = 90;
    }


    void Update()
    {
        if (bolum1gecisbutton)
        {
            SceneManager.LoadScene("1.Bölüm");
            
        }
        if (Restart.sv2)
        {
            sv2_.interactable = true;
        }
    }
   public void boum1()
    {
        bolum1gecisbutton = true;
    }

}
