using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDamageWcript : MonoBehaviour
{
    public EnemyHealthScript enemyHealth;

    private void Start()
    {
        enemyHealth = GetComponent<EnemyHealthScript>();
    }

    private void OnParticleCollision(GameObject other)
    {
        enemyHealth.curHealth -= 20;
    }
}
