﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;

    GameObject projectileParent;
    AttackerSpawner myLaneSpawner;
    Animator animator;

    const string PROJECTILE_PARENT_NAME = "Projectiles";

    private void Start()
    {
        CreatProjectileParent();
        SetLaneSpawner();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (AttackerIsInLane())
        {
            Debug.Log("Fire");
            animator.SetBool("IsAttacking", true);
        }
        else
        {
            Debug.Log("Idle");
            animator.SetBool("IsAttacking", false);
        }
    }

    private void CreatProjectileParent()
    {
        projectileParent = GameObject.Find(PROJECTILE_PARENT_NAME);
        if (!projectileParent)
        {
            projectileParent = new GameObject(PROJECTILE_PARENT_NAME);
        }
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach (AttackerSpawner spawner in spawners)
        {
            bool isCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);

            if (isCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool AttackerIsInLane()
    {
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void Fire()
    {
        GameObject projectiles = Instantiate(projectile, gun.transform.position, Quaternion.identity) as GameObject;
        projectiles.transform.parent = projectileParent.transform;
    }
}
