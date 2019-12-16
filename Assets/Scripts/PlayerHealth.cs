using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    public int lives = 3;

    // Start is called before the first frame update
    void Start()
    {
        CrashObject.OnCrashedInto += DamagePlayer;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DamagePlayer()
    {
        if (lives <= 0)
            Death();
        lives--;
        HealthController.instance.UpdateHealthUI(lives);
    }

    void Death()
    {
        Debug.Log("Death");
        Application.Quit();
    }
}
