using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammopack : Pickable 
{
    private int ammo;

    public Ammopack()
    {
        ammo = 40;
    }

    public override void OnPickup(GameObject player) 
    {
        if(player.GetComponent<WeaponHolder>().weapons[WeaponHolder.currentWeapon].ammo < 0) 
        {
            return;
        }

        base.OnPickup(player);

        player.GetComponent<WeaponHolder>().weapons[WeaponHolder.currentWeapon].ammo += ammo;
    }
}
