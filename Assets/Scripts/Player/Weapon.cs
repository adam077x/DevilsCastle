using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon
{
    public int damage;
    public int ammo;
    [System.NonSerialized]
    public string fireAnimationName;
    [System.NonSerialized]
    public Image weaponImage;
    public Sprite weaponSprite;

    public Weapon(int damage, string fireAnimationName, Sprite weaponSprite)
    {
        this.fireAnimationName = fireAnimationName;
        this.damage = damage;
        this.weaponSprite = weaponSprite;
        ammo = 10;
        weaponImage = GameObject.Find("Weapon").GetComponent<Image>();
    }

    void FixedUpdate()
    {
        
    }

    public virtual void Update() 
    {
        weaponImage.overrideSprite = weaponSprite;

        if(Input.GetButtonDown("Fire1")) {
            if(ammo == 0)
            {
                return;
            }
            else if(ammo != -1) 
            {
                ammo -= 1;
            }
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            UIManager.instance.GetImage("Weapon").GetAnimator().SetBool("Shoot", true);
            SoundManager.instance.Play("Pistol_Fire");
            if (Physics.Raycast(ray, out hit)) 
            {
                HostileEntity entity = hit.collider.GetComponent<HostileEntity>();
                if(entity != null)
                {
                    entity.health -= damage;
                }
            }
        }
    }
}
