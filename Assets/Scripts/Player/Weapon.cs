using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damage;
    private Animator animator;

    public Weapon(int damage, Animator weaponAnimator)
    {
        this.animator = weaponAnimator;
        this.damage = damage;
    }

    void FixedUpdate()
    {
    }

    public virtual void Update() 
    {
        if(Input.GetButtonDown("Fire1")) {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            animator.SetBool("Shoot", true);
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
