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

    public override void Update() 
    {
        base.Update();

        if(health <= 0) 
        {
            animator.SetTrigger("Die");
            this.GetComponent<BoxCollider>().enabled = false;
            this.GetComponent<NavMeshAgent>().enabled = false;
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

    IEnumerator AttackCoroutine() 
    {
        attacking = true;
        animator.SetTrigger("Swing");
        target.GetComponent<PlayerHealth>().Hurt(damage);

        yield return new WaitForSeconds(1.0f);
        attacking = false;
    }
}
