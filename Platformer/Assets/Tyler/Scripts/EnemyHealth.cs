using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called before the first frame update
    //keep track of enemy health
    //insert collision details here 2?
    public float maxHealth=1;
    public float currentHealth=1;


    void Start()
    {
        currentHealth = maxHealth;
       
    }

    public void TakeDamage (int dmg)
    {
        
        currentHealth -= 1;
        if (currentHealth <= 0)
        {
            Die();
        }
        
    }

    void Die()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
