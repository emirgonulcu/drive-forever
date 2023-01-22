using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayScript : MonoBehaviour
{
    public GameObject way;
    bool spawn_way = false;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "MainCar" && !spawn_way)
        {
            Vector3 spawn_location = new Vector3(transform.position.x, transform.position.y + 10, 0);
            Instantiate(way, spawn_location, Quaternion.identity);
            spawn_way = true;
            ScoreManager.score += 10;
            Destroy(this.gameObject, 6);
        }
    }
}
