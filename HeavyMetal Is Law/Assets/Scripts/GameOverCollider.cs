using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCollider : MonoBehaviour
{
    private void OnTriggerEnter2D()
    {
        FindObjectOfType<GameOverDisplay>().SubtractLife();
    }
}
