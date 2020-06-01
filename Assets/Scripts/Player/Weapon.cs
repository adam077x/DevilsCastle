using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngineInternal;

public class Weapon
{
    public int damage;
    public int ammo;
    [System.NonSerialized]
    public string fireAnimationName;
    [System.NonSerialized]
    public Image weaponImage;
    public Sprite weaponSprite;

    [System.NonSerialized]
    public float timer = 0;
    public GameObject dustParticle;

    public Weapon(int damage, string fireAnimationName, Sprite weaponSprite)
    {
        this.fireAnimationName = fireAnimationName;
        this.damage = damage;
        this.weaponSprite = weaponSprite;
        ammo = 10;
        dustParticle = GameObject.Find("Dust");
        //weaponImage = GameObject.Find("Weapon").GetComponent<Image>();
    }

    void FixedUpdate()
    {
        
    }

    public virtual void Update() 
    {
        timer += Time.deltaTime;
        if(Input.GetButtonDown("Fire1")) 
        {
            if(timer >= 0.2)
            {
                Shoot();
                timer = 0;
            }
        }
    }

    public void Shoot() 
    {
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
        UIManager.instance.GetImage("Weapon").GetAnimator().SetTrigger("Shoot");
        SoundManager.instance.Play("Pistol_Fire");
        if (Physics.Raycast(ray, out hit)) 
        {
            //GameObject.Instantiate(dustParticle, hit.point, Quaternion.identity);
            HostileEntity entity = hit.collider.GetComponent<HostileEntity>();
            if(entity != null)
            {
                entity.health -= damage;
            }
        }
    }
}
