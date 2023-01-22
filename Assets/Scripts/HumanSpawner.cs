using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSpawner : MonoBehaviour
{
    public GameObject[] random_human;

    private int rand;

    bool can_spawn=true;
    void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        while (can_spawn)
        {
            rand = Random.Range(0, 3);
            Instantiate(random_human[rand], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }

}
