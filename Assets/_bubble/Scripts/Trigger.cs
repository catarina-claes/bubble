using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject prefab;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("okay");
        Instantiate(prefab, new Vector3(-32f, 0, 0), Quaternion.identity);
    }

    public void trigerDestroy()
    {
        Destroy(gameObject);
    }
}
