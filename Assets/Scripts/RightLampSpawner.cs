using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightLampSpawner : MonoBehaviour
{
    public GameObject RightLamp;

    bool can_spawn = true;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (can_spawn)
        {
            Instantiate(RightLamp, new Vector3(2.625f, transform.position.y, 0), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
