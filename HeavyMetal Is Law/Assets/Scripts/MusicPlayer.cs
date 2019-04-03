using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        var currentScene = SceneManager.GetActiveScene().buildIndex;

        if (currentScene == 1 || currentScene == 4)
        {
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsController.GetMasterVolume();
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
