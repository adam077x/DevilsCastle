using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public Pistol(Animator weaponAnimator) : base(1, weaponAnimator) 
    {
        ammo = -1;
    }
}
