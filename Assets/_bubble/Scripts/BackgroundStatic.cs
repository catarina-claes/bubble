using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundStatic : MonoBehaviour
{
    public static Transform tf;
    public static string nam;

    // Start is called before the first frame update
    void Start()
    {
        tf = transform;
        nam = transform.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
