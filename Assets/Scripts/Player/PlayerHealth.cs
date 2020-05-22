using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public Animator playerAnimator;
    public static bool dead;

    void Start()
    {
        health = 100;
        dead = false;
    }

    void Update()
    {
        if(health <= 0) 
        {
            dead = true;
            health = 0;
        }

        if(dead) 
        {
            if(Input.GetKeyDown(KeyCode.R)) 
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        if(dead) 
        {
            UIManager.instance.GetText("Restart").Show();
        }

        playerAnimator.SetBool("Dead", dead);    
        UIManager.instance.GetImage("Damage").GetAnimator().SetBool("Dead", dead);

        UIManager.instance.GetText("Health").ChangeText("HP: " + health.ToString());
    }

    public void Hurt(int damage) 
    { 
        GameObject.Find("DamageImage").GetComponent<Animator>().SetTrigger("Damaged");
        this.health -= damage;
    }
}
