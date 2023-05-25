﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Bullet")){
           
            Destroy(other.gameObject); // Destroy the bullet object
            Destroy(gameObject);
        }
    }
}
