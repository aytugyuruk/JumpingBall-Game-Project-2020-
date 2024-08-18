using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterharaket1 : MonoBehaviour
{
    public float jumpforce;
    public Rigidbody2D rb;
    public bool zipliyor;
    public GameObject parmak;
    public AudioSource mysource;


    
    void Update()
    {
        if (zipliyor)
        {

            rb.velocity = Vector2.up * jumpforce * 100;
            zipliyor = false;
            mysource.Play();
        }
    }

    public void zipla()
    {
        zipliyor = true;
        Destroy(parmak);
    }

}
