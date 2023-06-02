using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamagae(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            SceneManager.LoadScene(0);
        }


    }

}

