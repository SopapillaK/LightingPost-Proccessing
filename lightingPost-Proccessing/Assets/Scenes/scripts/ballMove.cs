using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMove : MonoBehaviour
{
    float movementSpeed = 10f;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))

        {
            transform.position += Vector3.forward * movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))

        {
            transform.position += Vector3.back * movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))

        {
            transform.position += Vector3.left * movementSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))

        {
            transform.position += Vector3.right * movementSpeed * Time.deltaTime;
        }
    }

}
