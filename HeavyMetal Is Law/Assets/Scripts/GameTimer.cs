using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Game Timer set in Seconds")]
    [SerializeField] float gameTime = 10f;

    bool triggeredLevelFinish = false;

    // Update is called once per frame
    void Update()
    {
        if (triggeredLevelFinish) { return; }

        GetComponent<Slider>().value = Time.timeSinceLevelLoad / gameTime;
        bool timerFinished = (Time.timeSinceLevelLoad >= gameTime);

        if (timerFinished)
        {
            FindObjectOfType<LevelController>().LevelTimerFinished();
            triggeredLevelFinish = true;
        }
    }
}
