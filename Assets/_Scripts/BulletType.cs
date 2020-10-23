/*--------------------------------------------------------------
// BulletType.cs
//
// Setting an enum for Bullet Types
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

[System.Serializable]
public enum BulletType
{
    REGULAR, // = 0
    FAT,     // = 1
    PULSING, // = 2
    RANDOM   // = 3
}
