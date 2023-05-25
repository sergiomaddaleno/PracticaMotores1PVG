using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-hInput, 0f, -vInput) * moveSpeed * Time.deltaTime;
        transform.position += transform.TransformDirection(movement);

        /*if (vInput < 0){transform.position += transform.forward * Time.deltaTime *moveSpeed;}
        if (vInput > 0){transform.position -= transform.forward * Time.deltaTime *moveSpeed;}

        if (hInput > 0){transform.position -= transform.right * Time.deltaTime *moveSpeed;}
        if (hInput < 0){transform.position += transform.right * Time.deltaTime *moveSpeed;}*/
    }
}

