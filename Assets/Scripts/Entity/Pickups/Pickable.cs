using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : Entity
{
    public Pickable() 
    {

    }

    public virtual void OnPickup(GameObject player) 
    {
        Destroy(gameObject);
        UIManager.instance.GetImage("Pickup").GetAnimator().SetTrigger("Pickup");
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")) 
        {
            OnPickup(other.gameObject);
        }
    }
}
