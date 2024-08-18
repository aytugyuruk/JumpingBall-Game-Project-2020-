using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ogreticikamera : MonoBehaviour
{
    public bool carpi0;


    void Start()
    {
        Application.targetFrameRate = 120;
    }

    void LateUpdate()
    {
       
        if (carpi0)
        {
            SceneManager.LoadScene("1.Bölüm");

        }


    }
    
    public void carpi()
    {
        carpi0 = true;
    }

}

