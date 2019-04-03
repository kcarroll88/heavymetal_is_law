using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCollider : MonoBehaviour
{
    private void OnCollisionEnter2D()
    {
        FindObjectOfType<GameOverDisplay>().SubtractLife();
    }
}
