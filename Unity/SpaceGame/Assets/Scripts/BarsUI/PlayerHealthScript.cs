using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthScript : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;

    public HealthbarScript healthBar;

    public void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
        else if(currentHealth < maxHealth)
        {
            currentHealth += 2f * Time.deltaTime;
            healthBar.SetHealth(currentHealth);
        }

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    //void IncreaseHealth(float increase)
    //{
    //    currentHealth += increase;
    //    healthBar.SetHealth(currentHealth);
    //
    //    if(currentHealth > maxHealth)
    //    {
    //        currentHealth = maxHealth;
    //    }
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Afval")
        {
            TakeDamage(10);
        }
    }

   // IEnumerator DamageWait()
   // {
   //     yield return new WaitForSeconds(10f);
   //     TakeDamage(10);
   // }

}
