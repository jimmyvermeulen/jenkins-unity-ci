using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    Text healthText;
    int lives;

    public static HealthController instance;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        healthText = GetComponent<Text>();
        UpdateHealthUI(GameObject.Find("Player").GetComponent<PlayerHealth>().lives);
        
    }

    public void UpdateHealthUI(int health)
    {
        lives = health;
        healthText.text = $"Lives: {lives}";
    }
    
}
