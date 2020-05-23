using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallMedkit : Pickable 
{
    private int hp;

    public SmallMedkit()
    {
        hp = 15;
    }

    public override void OnPickup(GameObject player) 
    {
        base.OnPickup(player);

        player.GetComponent<PlayerHealth>().health += hp;
    }
}