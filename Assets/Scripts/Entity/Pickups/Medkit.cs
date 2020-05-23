using UnityEngine;

public class Medkit : Pickable 
{
    private int hp;

    public Medkit()
    {
        hp = 40;
    }

    public override void OnPickup(GameObject player) 
    {
        base.OnPickup(player);

        player.GetComponent<PlayerHealth>().health += hp;
    }
}