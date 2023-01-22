using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarButNpcScript : MonoBehaviour
{
    private float speed;
    private int lane;
    private int random_sprite;

    public Sprite[] car_sprite;

    SpriteRenderer spr;

    Rigidbody2D rb2d;
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>();

        lane = Random.Range(1, 5);
        speed = Random.Range(2.5f, 3.5f);
        random_sprite = Random.Range(1, 19);

        switch (random_sprite)
        {
            case 1:
                spr.sprite = car_sprite[0];
                break;
            case 2:
                spr.sprite = car_sprite[1];
                break;
            case 3:
                spr.sprite = car_sprite[2];
                break;
            case 4:
                spr.sprite = car_sprite[3];
                break;
            case 5:
                spr.sprite = car_sprite[4];
                break;
            case 6:
                spr.sprite = car_sprite[5];
                break;
            case 7:
                spr.sprite = car_sprite[6];
                break;
            case 8:
                spr.sprite = car_sprite[7];
                break;
            case 9:
                spr.sprite = car_sprite[8];
                break;
            case 10:
                spr.sprite = car_sprite[9];
                break;
            case 11:
                spr.sprite = car_sprite[10];
                break;
            case 12:
                spr.sprite = car_sprite[11];
                break;
            case 13:
                spr.sprite = car_sprite[12];
                break;
            case 14:
                spr.sprite = car_sprite[13];
                break;
            case 15:
                spr.sprite = car_sprite[14];
                break;
            case 16:
                spr.sprite = car_sprite[15];
                break;
            case 17:
                spr.sprite = car_sprite[16];
                break;
            case 18:
                spr.sprite = car_sprite[17];
                break;
            default:
                break;
        } //Sprite deðiþtirme

        switch (lane)
        {
            case 1:
                transform.position = new Vector3(-1.41f, transform.position.y + 10, 0);
                break;
            case 2:
                transform.position = new Vector3(-0.488f, transform.position.y + 10, 0);
                break;
            case 3:
                transform.position = new Vector3(0.508f, transform.position.y + 10, 0);
                break;
            case 4:
                transform.position = new Vector3(1.482f, transform.position.y + 10, 0);
                break;
            default:
                break;
        } //Random þerit atama
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2d.velocity = new Vector3(rb2d.velocity.x, speed * 50 * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MainCar")
        {
            SceneManager.LoadScene(2);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "ExtraPoints")
        {
            ScoreManager.score += 50;
        }   
    }
}
