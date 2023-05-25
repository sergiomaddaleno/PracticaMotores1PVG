using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public float currentHealth = 100.0f;
    public float maxHealth = 100.0f;
    public float healthDecreaseAmount = 10.0f; // Adjust this value as needed

    public Image healthBarImage;

    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Bullet")){
           
            DecreaseHealth();
            Destroy(other.gameObject); // Destroy the bullet object
        }

        if (other.CompareTag("Car") || other.CompareTag("Floor")){
           
            DecreaseHealth();
        }

        if(currentHealth <= 0){
                SceneManager.LoadScene("MENUScene");
        }
    }

    private void DecreaseHealth(){
        currentHealth -= healthDecreaseAmount;
        UpdateHealthBar();
    }

    private void UpdateHealthBar(){
        float fillAmount = currentHealth / maxHealth;
        healthBarImage.fillAmount = fillAmount;
    }
}
