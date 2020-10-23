/*--------------------------------------------------------------
// BulletController.cs
//
// Handle Bullets movement
//
// Created by Tran Minh Son on Oct 22 2020
// StudentID: 101137552
// Date last Modified: Oct 23 2020
// Rev: 1.1
//  
// Copyright © 2020 Tran Minh Son. All rights reserved.
--------------------------------------------------------------*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    public float horizontalSpeed;
    public float horizontalBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    // Moving bullet from left to right
    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }

    // Return bullets to the pool if they went off the screen
    private void _CheckBounds()
    {
        if (transform.position.x > horizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    // Return bullets to the pool if they collide with enemies
    public void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);
        bulletManager.ReturnBullet(gameObject);
    }

    // Apply damage to enemies
    public int ApplyDamage()
    {
        return damage;
    }
}
