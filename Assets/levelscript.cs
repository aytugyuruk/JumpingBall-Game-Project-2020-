using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelscript : MonoBehaviour
{
    public GameObject buton;
    public void Pass()
    {
        Destroy(buton);
        int currentLevel = SceneManager.GetActiveScene().buildIndex;

        if (currentLevel >= PlayerPrefs.GetInt("levelsUnlocked"))
        {
            PlayerPrefs.SetInt("levelsUnlocked", currentLevel + 1);
        }


        Debug.Log("LEVEL" + PlayerPrefs.GetInt("levelsUnlocked") + "UNLOCKED");

    }
    
}
