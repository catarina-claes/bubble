using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public string lokasi;
    public GameObject prefab;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.tag == "delete")
        {
            Destroy(gameObject);
        }
        if (collision.tag == "MainCamera")
        {
            if (lokasi == "kiri")
            {
                Debug.Log("Masuk loh");
                Instantiate(prefab, new Vector3(transform.position.x - 17f, 0, 0), Quaternion.identity);
                Destroy(gameObject);
            } else if (lokasi == "kanan")
            {
                Instantiate(prefab, new Vector3(transform.position.x + 17f, 0, 0), Quaternion.identity);
                Destroy(gameObject);
            } else if (lokasi == "atas")
            {
                Instantiate(prefab, new Vector3(0, transform.position.y + 10f, 0), Quaternion.identity);
                Destroy(gameObject);
            } else if (lokasi == "bawah")
            {
                Instantiate(prefab, new Vector3(0, transform.position.y - 10f, 0), Quaternion.identity);
                Destroy(gameObject);

            }
        }
    }

}
