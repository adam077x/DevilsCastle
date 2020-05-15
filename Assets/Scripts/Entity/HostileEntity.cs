using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HostileEntity : Entity
{
    public int health;
    public Transform eye;
    private Rigidbody rb;
    public NavMeshAgent navMeshAgent;
    public float sightDistance;
    public float damageDistance;
    public int damage;
    private bool attacking;    
    public HostileEntity(int health, float sightDistance, int damage, float damageDistance) 
    {
        this.health = health;
        this.sightDistance = sightDistance;
        this.damageDistance = damageDistance;
        this.damage = damage;
        attacking = false;
    }  

    public void Hit(int damage) 
    {
        health -= damage;
    }

    public override void Start() 
    {
        rb = GetComponent<Rigidbody>();
    }

    public override void Update() 
    {
        base.Update();
        if(health <= 0) 
        {
            Destroy(gameObject);
        }

        if(Vector3.Distance(transform.position, target.position) < sightDistance) 
        {
            navMeshAgent.SetDestination(target.position);
        }

        if(Vector3.Distance(transform.position, target.position) < damageDistance && !attacking) 
        {
            StartCoroutine(AttackCoroutine());
        }
    }

    IEnumerator AttackCoroutine() {
        attacking = true;
        yield return new WaitForSeconds(1.0f);
        target.GetComponent<PlayerHealth>().health -= damage;
        attacking = false;
    }
}
