using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Restart : MonoBehaviour
{
    public GameObject restart;
    public GameObject circle,finishsound;
    public GameObject partikul;
    public static bool topdegdi, sv2, sv3, sv4, sv5, sv6, sv7, sv8, sv9, sv10, sv11, sv12, sv13, sv14, sv15, sv16, sv17, sv18, sv19, sv20, sv21;
    public Rigidbody2D rb;
     
     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "engel")
        {
            restart.SetActive(true);
            circle.GetComponent<Image>().color = new Color(0, 0, 0, 0);
           
        }
        if (col.gameObject.tag == "sahne")
        {
            finishsound.SetActive(true);
            topdegdi = true;
            partikul.SetActive(true);
            circle.SetActive(false);
            sv2 = true;
        }
       
    }
}
