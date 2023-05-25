using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardObject : MonoBehaviour
{
    public float speed = 5f;

    void FixedUpdate(){
        transform.position += Vector3.right * speed * Time.fixedDeltaTime;
    }

}
