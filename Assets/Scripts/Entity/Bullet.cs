using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Entity
{
    public int damage;

    public Bullet(int damage) {
        this.damage = damage;
    }

    public override void Update() {
        transform.Translate(transform.forward * Time.deltaTime);
    }
}
