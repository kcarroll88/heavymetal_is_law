﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravestone : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D otherCollider)
    {
        Attacker attacker = GetComponent<Attacker>();

        if (attacker)
        {
            // TODO do some sort of animation
        }
    }
}
