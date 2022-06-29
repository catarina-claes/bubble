using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobaRespawn : MonoBehaviour
{
    public GameObject bluePrint;
    private GameObject bobaList;
    private int respawnCount;
    void Start()
    {
        respawnCount = Random.Range(5, 30);
        for (int i = 0; i < respawnCount; i++)
        {
            bobaList = Instantiate(bluePrint, new Vector3(Random.Range(-13f, 14f), Random.Range(-8f, 8f), 0), Quaternion.identity) as GameObject;
            bobaList.transform.parent = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
