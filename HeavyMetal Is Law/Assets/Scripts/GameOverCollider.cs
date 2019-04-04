using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        FindObjectOfType<GameOverDisplay>().SubtractLife();
        Destroy(otherCollider.gameObject);
    }
}
