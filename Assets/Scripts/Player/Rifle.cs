using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Weapon
{

    public Rifle() : base(1, "Rifle_Fire", UIManager.instance.GetSprite("Rifle").sprite) 
    {
        ammo = 30;
        timer = 0.0f;
    }

    public override void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            timer += Time.deltaTime;
            if(timer >= 0.1f) 
            {
                Shoot();
                timer = 0;
            }
        }
    }
}