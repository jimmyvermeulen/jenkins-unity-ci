using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    int score = 0;
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        UpdateUI();
        ScorePickup.OnPickedUp += AddPoint;
    }

    void AddPoint()
    {
        score++;
        UpdateUI();
    }

    void UpdateUI()
    {
        scoreText.text = $"Score: {score}";
    }
}
