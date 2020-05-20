using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HostileEntity : Entity
{
    public int health;
    public float sightDistance;
    public float damageDistance;
    public int damage;

    private Rigidbody rb;
    private NavMeshAgent navMeshAgent;
    private bool attacking;
    private Animator animator;

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
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    bool onground = false;

    public override void Update() 
    {
        base.Update();

        if(onground) 
        {
        }

        if(health <= 0) 
        {
            animator.SetTrigger("Die");
            onground = true;
            navMeshAgent.Stop();
            return;
        }

        if(PlayerHealth.dead) return;

        if(Vector3.Distance(transform.position, target.position) < sightDistance) 
        {
            navMeshAgent.SetDestination(target.position);
            animator.SetBool("Walk", true);
        }
        else 
        {
            animator.SetBool("Walk", false);
        }

        if(Vector3.Distance(transform.position, target.position) < damageDistance && !attacking) 
        {
            StartCoroutine(AttackCoroutine());
        }
    }

    IEnumerator AttackCoroutine() {
        attacking = true;
        target.GetComponent<PlayerHealth>().Hurt(damage);
        animator.SetTrigger("Swing");
        yield return new WaitForSeconds(1.0f);
        attacking = false;
    }
}
