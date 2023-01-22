using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingMenuCar : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    
    public Vector3 firstPos;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        firstPos = transform.position;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(rb.velocity.x + speed * Time.deltaTime , rb.velocity.y + 1.2f * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ResetPos")
        {
            transform.position = firstPos;
            rb.velocity = new Vector3(0,0,0);
        }   
    }
}
