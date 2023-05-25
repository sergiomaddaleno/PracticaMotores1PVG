using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScripEnemy : MonoBehaviour{

    public  GameObject cannonBallPrefab_;
    private Transform TR_;
    public float impulse_ = 1.0f;

    void Start(){
        
        TR_ = GetComponent<Transform>();
        InvokeRepeating("EnemyFire", 4f, 4f); // Calls the "EnemyFire" method every 7 seconds
    }

    void EnemyFire(){
        // Create a new enemy bullet and add force to it
        GameObject enemyBullet = Instantiate<GameObject>(cannonBallPrefab_, transform.position, Quaternion.identity);
        Rigidbody rb = enemyBullet.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * impulse_, ForceMode.Impulse);
        
    }
}
