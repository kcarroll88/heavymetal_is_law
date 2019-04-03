using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverDisplay : MonoBehaviour
{
    [SerializeField] int lives = 5;
    [SerializeField] int takeLife = 1;
    Text healthText;

    private void Start()
    {
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
    }
}
