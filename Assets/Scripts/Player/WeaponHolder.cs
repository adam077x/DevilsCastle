using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour
{
    public int damage;
    public Weapon currentWeapon;
    public Camera cam;

    void Start() 
    {
        currentWeapon = new Pistol();
    }

    public void Shoot(HostileEntity entity)
    {
        entity.health -= damage;
    }

    void Update()
    {
        currentWeapon.Update();
    }
}
