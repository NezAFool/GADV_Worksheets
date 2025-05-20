using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    // Start is called before the first frame update
    private int health = 0;
    private int maxHealth = 10;
    private int minHealth = 0;
    public Player(int Health)
    {
        if (Health > maxHealth)
        {
            health = maxHealth;
            Debug.Log($"{health}");
        }
        else
        {
            health = Health;
            Debug.Log($"{health}");
        }
            
    }
    public void TakeDamage(int damage)
    {
        if ((health -= damage) < 0)
        {
            health = minHealth;
        }
        else
        {
            
            Debug.Log($"Took {damage} damage, Health remaining:{health}");
        }
    }
    public void getHealth(int Health)
    {
        Debug.Log($"{health}");
        if ((this.health +=Health)> maxHealth)
        {
            this.health = maxHealth;
            Debug.Log("Health Full");
        }
        else
        {
            Debug.Log($"Healed {Health} health, Current Health:{health}");
        }
        
    }
}
