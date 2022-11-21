using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 10f;
    float rotationspeed = 90f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += speed * transform.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= speed * transform.forward * Time.deltaTime;
        }




        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(transform.up, 1f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(transform.up, -1f);
        }
    }
}
