﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damage;

    public Weapon(int damage)
    {
        this.damage = damage;
    }

    public virtual void Shoot() 
    {
        if(Input.GetButtonDown("Fire1")) {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) 
            {
                entity.health -= damage;
            }
        }
    }
}
