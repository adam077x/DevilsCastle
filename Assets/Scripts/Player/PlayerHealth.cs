using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health;

    [SerializeField] private Text healthText;

    void Start()
    {
        health = 100;
    }

    void Update()
    {
        healthText.text = "HP: " + health.ToString();
    }

    public void Hurt(int damage) 
    { 
        GameObject.Find("DamageImage").GetComponent<Animator>().SetTrigger("Damaged");
        this.health -= damage;
    }
}
