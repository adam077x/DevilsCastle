﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public Transform target;

    public void LookTowards() {
        Vector3 targetPosition = new Vector3(target.position.x, transform.position.y, target.position.z); 
        transform.LookAt(targetPosition);
        transform.Rotate(new Vector3(0, 180, 0));
    }

    public virtual void Start()
    {
        
    }

    public virtual void Update()
    {
        LookTowards();
    }
}
