using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanScript : MonoBehaviour
{
    public float speed;
    private int lane;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        lane = Random.Range(1,3);

        switch (lane)
        {
            case 1:
                transform.position = new Vector3(-2.65f, transform.position.y + 10, 0);
                break;
            case 2:
                transform.position = new Vector3(2.67f, transform.position.y + 10, 0);
                break;
            default:
                break;
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(rb.velocity.x, speed * 20 * Time.deltaTime);
    }
}
