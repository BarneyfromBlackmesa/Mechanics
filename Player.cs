using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public float maxHealth = 10;
    public float currentHealth;
    public HealthBar healthBar;

    [Header("Death Logic Variables")]
    private bool _active = true;
    private Collider2D _collider;


    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBar.setHealth(currentHealth / maxHealth * 10); // Update percentage

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        _active = false;
        if (_collider != null)
        {
            _collider.enabled = false;
        }
    }
}