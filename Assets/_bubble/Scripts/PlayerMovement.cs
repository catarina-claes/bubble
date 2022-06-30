using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Joystick joystick;
    public Scrollbar scrollbar;

    private Rigidbody2D rb;

    private float force;
    private float x;
    private float y;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    // Update is called once per frame
    void Update()
    {
        x = joystick.Direction.x;
        y = joystick.Direction.y;
        if (Input.GetButtonDown("Jump"))
        {
            Push();
        }
    }

    public void Push()
    {
        force = scrollbar.value * 1000;
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(x * force, y * force));
    }
}
