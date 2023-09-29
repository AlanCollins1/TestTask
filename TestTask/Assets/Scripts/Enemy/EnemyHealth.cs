using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour {
    public int Health = 1;
    private RandomLoots _randomLoots;

    //public UnityEvent EventOnTakeDamage;
    //private UnityEvent EventOnDie;
    public void Init (RandomLoots randomLoots){
        _randomLoots = randomLoots;
    }

    public void TakeDamage(int damageValue) {
        Health -= damageValue;
        //EventOnTakeDamage.Invoke();
        if (Health <= 0) {
            Die();
        }
    }
    public void Die() {
        _randomLoots.Choice(transform);
        //EventOnDie.Invoke();
        Destroy(gameObject);
    }
}