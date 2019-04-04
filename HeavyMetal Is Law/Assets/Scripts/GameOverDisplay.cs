using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverDisplay : MonoBehaviour
{
    [SerializeField] float baseLives = 3;
    [SerializeField] int takeLife = 1;

    float lives;

    Text healthText;

    private void Start()
    {
        lives = baseLives - PlayerPrefsController.GetDifficulty();
        healthText = GetComponent<Text>();
        UpdateText();
    }

    private void UpdateText()
    {
        healthText.text = lives.ToString();
    }

    public void SubtractLife()
    {
        lives -= takeLife;
        UpdateText();

        if (lives <= 0)
        {
            FindObjectOfType<LevelLoader>().GameOver();
        }
    }
}
