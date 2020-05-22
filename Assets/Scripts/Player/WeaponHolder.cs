using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        if(currentWeapon.ammo == -1) 
        {
            UIManager.instance.GetText("Ammo").ChangeText("AMMO:");
            UIManager.instance.GetImage("Infinity").Show();
        }
        else 
        {
            UIManager.instance.GetText("Ammo").ChangeText("AMMO: " + currentWeapon.ammo.ToString());
            UIManager.instance.GetImage("Infinity").Show();
        }
    }
}
