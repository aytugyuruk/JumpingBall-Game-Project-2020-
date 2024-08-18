using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hiz, deger;
    void Update()
    {
        gameObject.transform.Translate(new Vector3(deger * hiz * Time.deltaTime, 0, 0));
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "varilacak")
        {
            deger *= -1;
        }
    }
}
