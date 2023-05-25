using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseGameScript : MonoBehaviour{
    public Text pauseText;
    public Button returnToMenuButton;
    private bool isPaused = true;

    void Start(){
        returnToMenuButton.gameObject.SetActive(false);
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.P)){
            if(isPaused){
                ResumeGame();

            }else{
                PauseGame();
            }
        }
        if(Input.GetKeyDown(KeyCode.M)){
            SceneManager.LoadScene("MENUScene");
        }
    }

    private void PauseGame(){
        Time.timeScale = 0f; //Time set to 0
        isPaused = true;
        pauseText.text = "Game Paused"; //Text when the game is paused
        pauseText.gameObject.SetActive(true);
        returnToMenuButton.gameObject.SetActive(true);
    }

    private void ResumeGame(){
        Time.timeScale = 1f; //Time set to 1
        isPaused = false;
        pauseText.gameObject.SetActive(false); // Hide the pause message
        returnToMenuButton.gameObject.SetActive(false);

    }

}
