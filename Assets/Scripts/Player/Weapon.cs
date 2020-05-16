using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damage;

    public Weapon(int damage)
    {
        this.damage = damage;
    }

    public virtual void Update() 
    {
        if(Input.GetButtonDown("Fire1")) {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) 
            {
                hit.collider.GetComponent<HostileEntity>().health -= damage;
            }
        }
    }
}
