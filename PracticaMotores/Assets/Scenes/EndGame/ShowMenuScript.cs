using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ShowMenuScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision){
        
        if (collision.gameObject.tag == "Player"){
            SceneManager.LoadScene("MENUScene");
        }
    }
}
