﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [Header("Volume")]
    [SerializeField] Slider volumeSlider;
    [SerializeField] float defaultVolume = 0.8f;
    [Header("Difficulty")]
    [SerializeField] Slider difficultySlider;
    [SerializeField] float defaultDifficulty = 0f;

    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
        difficultySlider.value = PlayerPrefsController.GetDifficulty();
    }

    // Update is called once per frame
    void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if (musicPlayer)
        {
            musicPlayer.SetVolume(volumeSlider.value);
        }
        else
        {
            Debug.LogWarning("No music in scene!");
        }
    }

    public void SaveAndExit()
    {
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        PlayerPrefsController.SetDifficulty(difficultySlider.value);
        FindObjectOfType<LevelLoader>().LoadMainMenuClassic();
    }

    public void SetDefaults()
    {
        volumeSlider.value = defaultVolume;
        difficultySlider.value = defaultDifficulty;
    }
}
