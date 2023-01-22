using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject random_car_npc;

    bool can_spawn = true;

    void Start()
    {
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        while (can_spawn)
        {
            Instantiate(random_car_npc, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2.5f);
        }
        
    }
}
