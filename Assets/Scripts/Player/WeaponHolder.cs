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
        currentWeapon = new Pistol(cam);
    }

    public void Shoot(HostileEntity entity)
    {
        entity.health -= damage;
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1")) {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) 
            {
                currentWeapon.Shoot(hit.collider.GetComponent<HostileEntity>());
            }
        }
    }
}
