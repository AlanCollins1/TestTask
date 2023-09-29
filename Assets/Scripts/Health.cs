using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public float _currentHealth;

    public void TakeDamage(float value) {

        float newHealth = _currentHealth - value;
        newHealth = Mathf.Max(newHealth, 0);
        SetHealth(newHealth);
        if (newHealth == 0) {
            Die();
        }
    }
    public virtual void SetHealth(float value) {
    }
    public virtual void Die() {
    }
}