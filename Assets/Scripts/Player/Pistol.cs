using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public Pistol() : base(1, "Pistol_Fire", UIManager.instance.GetSprite("Pistol").sprite) 
    {
        ammo = -1;
    }
}
