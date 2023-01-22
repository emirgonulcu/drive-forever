using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampScript : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 14, 0);
    }
}
