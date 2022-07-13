using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject ExplodeEffect;
    public PlayerHealthBar healthBar;
    private int maxHealth = 6;
    private int currentHealth;
    public event Action TankWin;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetPlayerMaxhealth(maxHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemybullet" || collision.gameObject.tag == "Playerbullet")
        {
            TakeDamage(1);
        }
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetPlayerHealth(currentHealth);
        if (currentHealth <= 0)
        {
            TankExplode();
        }
    }

    private void TankExplode()
    {
        GameObject tankExplodeEffect = Instantiate(ExplodeEffect, transform.position, Quaternion.identity);
        Destroy(tankExplodeEffect, 3f);
        Destroy(gameObject);
        TankWin?.Invoke();  
    }
}
