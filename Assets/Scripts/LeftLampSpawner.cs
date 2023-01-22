using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftLampSpawner : MonoBehaviour
{
    public GameObject LeftLamp;

    bool can_spawn = true;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (can_spawn)
        {
            Instantiate(LeftLamp, new Vector3(-2.649f, transform.position.y, 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }

        
    }
}
