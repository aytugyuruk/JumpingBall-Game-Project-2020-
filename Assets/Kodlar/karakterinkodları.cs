using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class karakterinkodlarý : MonoBehaviour
{

    public void Update()
    {
        if (Restart.topdegdi)
        {
            StartCoroutine(bekleme());
        }
        if (Restart2.topdegdi)
        {
            StartCoroutine(bekleme2());
        }
    }
    IEnumerator bekleme()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        Restart.topdegdi = false;
        SceneManager.LoadScene("2.Bölüm");
    }
    IEnumerator bekleme2()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        Restart.topdegdi = false;
        SceneManager.LoadScene("3.Bölüm");
    }

}
