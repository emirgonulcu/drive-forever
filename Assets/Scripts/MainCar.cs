using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainCar : MonoBehaviour
{
    public float vertical_speed, horizontal_speed, default_speed;
    private float vertical_move,horizontal_move;

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        vertical_move = Input.GetAxis("Vertical");
        horizontal_move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector3
            (horizontal_move*50*horizontal_speed*Time.deltaTime, 
            default_speed + vertical_move * 50 * vertical_speed * Time.deltaTime);

        if (transform.position.x > 1.73f)
        {
            Vector3 right_limit = new Vector3(1.73f, transform.position.y);
            transform.position = right_limit;
        } //SAÐ SINIR KONTROL
        if (transform.position.x < -1.7f)
        {
            Vector3 left_limit = new Vector3(-1.7f, transform.position.y);
            transform.position = left_limit;
        } //SOL SINIR KONTROL
    }

    public void Left()
    {
        horizontal_move = -1;
    }

    public void Right()
    {
        horizontal_move = 1;
    }

    public void Stop()
    {
        horizontal_move = 0;
        vertical_move = 0;
    }
    
    public void Boost()
    {
        vertical_move = 1;
    }
}
