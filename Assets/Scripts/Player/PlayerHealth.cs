using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public Animator animator;
    public Animator playerAnimator;
    public static bool dead;
    public Text resetText;

    [SerializeField] private Text healthText;

    void Start()
    {
        health = 100;
        dead = false;
        playerAnimator = GetComponent<Animator>();
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

        resetText.gameObject.SetActive(dead);

        animator.SetBool("Dead", dead);

        playerAnimator.SetBool("Dead", dead);    

        healthText.text = "HP: " + health.ToString();
    }

    public void Hurt(int damage) 
    { 
        GameObject.Find("DamageImage").GetComponent<Animator>().SetTrigger("Damaged");
        this.health -= damage;
    }
}
