using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject beta;

    private float beta1, beta2, beta3, beta4;
    private float alpha1, alpha2, alpha3, alpha4;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        beta1 = beta.transform.position.y + 5;
        beta2 = beta.transform.position.x + ((10 * (16 / 9)) / 2);
        beta3 = beta.transform.position.y - 5;
        beta4 = beta.transform.position.x - ((10 * (16 / 9)) / 2);

    }
}
