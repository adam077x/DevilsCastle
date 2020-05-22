using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : Entity
{
    public Pickable() 
    {

    }

    public virtual void OnPickup() 
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")) 
        {
            OnPickup();
        }
    }
}
