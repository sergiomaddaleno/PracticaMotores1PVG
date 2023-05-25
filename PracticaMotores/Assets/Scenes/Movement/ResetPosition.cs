using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour 
{
    public Vector3 resetPosition_;
    public Vector3 changePositionPlayer_;

    private void OnTriggerEnter(Collider collision){

        switch (collision.tag){
            case "Car": collision.transform.position = resetPosition_; break;
            case "Player": collision.transform.position = changePositionPlayer_; break;
        }
        
    }
}
