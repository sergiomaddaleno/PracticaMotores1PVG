using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpRaycast : MonoBehaviour
{

    public bool grounded = false;
    public float groundCheckDistance;
    public float bufferCheckDistance = 0.1f; //Slightly above 0
    public float rayDistance;

    // Update is called once per frame
    void Update(){
       groundCheckDistance = (GetComponent<CapsuleCollider>().height / 2) + bufferCheckDistance;
       //groundedCheckDistance = 1.1;

        if(Input.GetKeyDown(KeyCode.Space) && grounded){ //Jump code
          GetComponent<Rigidbody>().AddForce(transform.up * 5, ForceMode.Impulse);
        }

       Debug.DrawRay(transform.position, -transform.up * rayDistance, Color.red); //To draw the raycast

       RaycastHit hit;
       if(Physics.Raycast(transform.position, -transform.up, out hit, groundCheckDistance)){

            //ray hit ground
            grounded = true;
       }else{ //ray did not hit gorund
            grounded = false;
       }
    }   
}
