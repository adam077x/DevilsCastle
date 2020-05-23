using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Weapon
{
    public Rifle() : base(1, "Rifle_Fire", UIManager.instance.GetSprite("Rifle").sprite) 
    {
        ammo = 30;
    }
}