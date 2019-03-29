using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision collision)
    {
        var gameOver = collision;
        Destroy(gameObject);
    }
}
