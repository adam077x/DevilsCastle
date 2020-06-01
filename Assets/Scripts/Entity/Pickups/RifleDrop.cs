using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleDrop : Pickable
{
    public override void OnPickup(GameObject player)
    {
        base.OnPickup(player);

        WeaponHolder holder = GameObject.Find("Player").GetComponent<WeaponHolder>();
        holder.weapons[1] = new Rifle();
    }
}
