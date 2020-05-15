using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damage;
    public string currentWeapon;
    public GameObject defaultBullet;
    public Camera cam;

    void Start() 
    {
        currentWeapon = "Pistol";
    }

    public void Shoot(HostileEntity entity) {
        switch(currentWeapon) {
            case "Pistol":
                entity.health -= 1;
                break;    
        }
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1")) {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) 
            {
                //if(!hit.collider.TryGetComponent(HostileEntity)) return;
                print(hit.collider.name);
                Shoot(hit.collider.GetComponent<HostileEntity>());
            }
        }
    }
}
