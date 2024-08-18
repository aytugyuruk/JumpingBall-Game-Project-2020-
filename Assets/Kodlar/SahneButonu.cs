using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneButonu : MonoBehaviour
{
    public void Sahnedegistir(int sahneid)
    {


        SceneManager.LoadScene(sahneid);
        Time.timeScale = 1;

    }
}
