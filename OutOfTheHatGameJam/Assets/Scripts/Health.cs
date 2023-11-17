using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
   public int health = 100; // Health of the object
   public int maxHealth = 100;
   public GameObject objectToDestroy; 
   public void TakeDamage(int damage)
   {
       health -= damage;
       if (health <= 0)
       {
           print("Health is " + health);
           health = 0;
           //Die();
       }
   }
   
   
   public void GainHealth(int heals)
   {
       health += heals;
       if (health >= maxHealth)
       {
           health = maxHealth;
           print("Health is " + health);
           // Destroy the object or do something else when health is 0
           
       }
   }
   
   
   void Die()
   {
       // Implement logic for when the player dies
   }
}
