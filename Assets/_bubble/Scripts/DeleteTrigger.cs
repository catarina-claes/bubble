using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTrigger : MonoBehaviour
{
    public Trigger tg;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("iya gk");
        Debug.Log(collision.tag);
        Debug.Log(collision.name);
        tg.trigerDestroy();
        if(collision.tag == "collision")
        {
            Debug.Log("bisa di trigger sama trigger");
        }
    }
}
