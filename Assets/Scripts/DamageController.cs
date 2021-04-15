using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DamageController : MonoBehaviour

{
    [SerializeField] private float crabDamage;
    [SerializeField] private HealthController healthController;
    public GameObject deathEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Damage();
        }
    }

    void Damage()
    {
        healthController.playerHealth = healthController.playerHealth - crabDamage;
        healthController.UpdateHealth();
        this.gameObject.SetActive(false);

    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }



}
