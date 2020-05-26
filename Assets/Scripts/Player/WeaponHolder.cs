using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponHolder : MonoBehaviour
{
    [System.NonSerialized]
    public Weapon[] weapons = new Weapon[2];
    public static int currentWeapon;

    void Start() 
    {
        currentWeapon = 0;
        weapons[0] = new Pistol();
        weapons[1] = new Rifle();
    }

    void Update()
    {
        if(PlayerHealth.dead) return;

        UIManager.instance.GetImage("Weapon").GetAnimator().SetInteger("CurrentWeapon", currentWeapon);

        if(Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            currentWeapon = 0;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2)) 
        {
            currentWeapon = 1;
        }

        weapons[currentWeapon].Update();
        if(weapons[currentWeapon].ammo == -1) 
        {
            UIManager.instance.GetText("Ammo").ChangeText("AMMO:");
            UIManager.instance.GetImage("Infinity").Show();
        }
        else 
        {
            UIManager.instance.GetText("Ammo").ChangeText("AMMO: " + weapons[currentWeapon].ammo.ToString());
            UIManager.instance.GetImage("Infinity").Hide();
        }
    }
}
