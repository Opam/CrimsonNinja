using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creepHealth : MonoBehaviour
{
    [SerializeField]public int health;

    public int maxHealth = 4;

    public enemyHP healthbar;
    
    void Start()
    {
        health = maxHealth;
        // healthbar.SetHealth(health, maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void damage(int amount)
    {
        
        this.health -= amount;

        healthbar.SetHealth(health);

        if(health <= 0)
        {
            Die();
        }
    }

    public void heal(int amount)
    {
        if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative heal");
        }
        this.health -= amount;
    }

    private void Die()
    {
        Debug.Log("I am dead");
        Destroy(gameObject);
    }
}
