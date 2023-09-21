using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static event Action OnPlayerDeath;
    public float maxHealth, health;
    void Start()
    {
        health = maxHealth;
    }

   public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            health = 0;
            Debug.Log("ded");
            OnPlayerDeath?.Invoke();
        }
    }
}
