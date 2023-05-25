using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Wall")){
           
            Destroy(gameObject); // Destroy the bullet object
        }
    }
}
