using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour
{
    private Weapon currentWeapon;
    public Animator weaponAnimator;

    void Start() 
    {
        currentWeapon = new Pistol(weaponAnimator);
    }

    void Update()
    {
        if(PlayerHealth.dead) return;
        currentWeapon.Update();
    }
}
