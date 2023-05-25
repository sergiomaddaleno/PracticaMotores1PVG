using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMouse : MonoBehaviour
{
    public GameObject Player;
    public float turnSpeed_;

    // Update is called once per frame
    void Update(){
        
        if(Time.timeScale==1){
            float y = Input.GetAxis("Mouse X") * turnSpeed_;
            Player.transform.eulerAngles = new Vector3(0, Player.transform.eulerAngles.y + y, 0);
        }
    }
}
