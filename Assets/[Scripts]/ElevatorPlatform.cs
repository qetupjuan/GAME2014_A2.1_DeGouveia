using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorPlatform : MonoBehaviour
{
    [SerializeField]
    private float strenght = 2.0f;

    private bool isColliding = false;
    private Rigidbody2D rb;
    void Update()
    {
        if (rb && isColliding)
        {
            rb.AddForce(new Vector2(0.0f, strenght));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isColliding = true;
        rb = collision.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isColliding = false;
    }
}
