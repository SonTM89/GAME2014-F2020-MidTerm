/*--------------------------------------------------------------
// BackgroundController.cs
//
// Handle the moving background
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

public class BackgroundController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    // Reset background position
    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
    }

    // Move background from right to left
    private void _Move()
    {
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    // Check the boundary to reset background position
    private void _CheckBounds()
    {
        // if the background is out of the left of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
