﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    [SerializeField]
    private Vector3 offset;

     void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
