using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobaRespawn : MonoBehaviour
{
    public GameObject bluePrint;
    private GameObject bobaList;
    private float respawnCount, x, y;
    void Start()
    {
        x = transform.parent.position.x;
        y = transform.parent.position.y;
        respawnCount = Random.Range(5, 30);
        for (int i = 0; i < respawnCount; i++)
        {
            bobaList = Instantiate(bluePrint, new Vector3(Random.Range(x - 16, x + 16), Random.Range(y - 9, y + 9), 0), Quaternion.identity) as GameObject;
            bobaList.transform.parent = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
