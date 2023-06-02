using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKiller : MonoBehaviour
{
    public int health = 100; // Initial health of the enemy
    public int bulletDamage = 10; // Damage inflicted by each bullet

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            
            health -= bulletDamage;

            // Check if the enemy is dead
            if (health <= 0)
            {
                
                Destroy(gameObject);
            }

            // Destroy the bullet
            Destroy(collision.gameObject);
        }
    }
}
