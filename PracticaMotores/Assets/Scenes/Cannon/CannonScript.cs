using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour{   

    public  GameObject cannonBallPrefab_;
    private Transform TR_;
    public float impulse_ = 1.0f;
    

    // Start is called before the first frame update
    void Start(){
        TR_ =  GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update(){
        if(Time.timeScale==1){
            if(Input.GetButtonDown("Fire1")){
                Fire();
            }
        }
    }

    void Fire(){
        GameObject go = Instantiate<GameObject>(cannonBallPrefab_, TR_.position, TR_.rotation);

        Rigidbody rb = go.GetComponent<Rigidbody>();
        rb.AddForce(TR_.forward * impulse_, ForceMode.Impulse);
    }

}
