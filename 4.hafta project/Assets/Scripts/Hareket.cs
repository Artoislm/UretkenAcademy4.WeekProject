using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{

    public float speed = -1.0f;

     // Update is called once per frame
    void Update()
    {

        Vector3 playerInput = new(-Input.GetAxis("Vertical"), 0.0f, Input.GetAxis("Horizontal"));
        Vector3 hizextrasi = playerInput * Time.deltaTime * speed;
        transform.position += hizextrasi;

    }
}
