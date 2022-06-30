using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public string lokasi;
    public GameObject prefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "delete")
        {
            Debug.Log(collision.tag);
            Destroy(gameObject);
        }
        if (collision.tag == "MainCamera")
        {
            if (lokasi == "kiri")
            {
                Instantiate(prefab, new Vector3(transform.position.x - 17f, transform.position.y, 0), Quaternion.identity);
                Destroy(gameObject);
            } else if (lokasi == "kanan")
            {
                Instantiate(prefab, new Vector3(transform.position.x + 17f, transform.position.y, 0), Quaternion.identity);
                Destroy(gameObject);
            } else if (lokasi == "atas")
            {
                Instantiate(prefab, new Vector3(transform.position.x, transform.position.y + 10f, 0), Quaternion.identity);
                Destroy(gameObject);
            } else if (lokasi == "bawah")
            {
                Instantiate(prefab, new Vector3(transform.position.x, transform.position.y - 10f, 0), Quaternion.identity);
                Destroy(gameObject);

            }
        }
    }

    void InstantieCollider()
    {

    }

}
