using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class EnemyHealth : Health {
    [SerializeField] private float _maxHealth;
    
    [SerializeField] private Transform HealthBar;
    private RandomLoots _randomLoots;

    //public UnityEvent EventOnTakeDamage;
    //private UnityEvent EventOnDie;
    public void Init (RandomLoots randomLoots){
        _randomLoots = randomLoots;
    }
    private void Start() {
        _currentHealth = _maxHealth;
    }
    public override void Die() {
        base.Die();
        _randomLoots.Choice(transform);
        //EventOnDie.Invoke();
        Destroy(gameObject);
    }

    public override void SetHealth(float value) {
        base.SetHealth(value);
        _currentHealth = value;
        //OnHealthChange?.Invoke(_currentHealth, _maxHealth);
        HealthBar.localScale = new Vector2((1 / _maxHealth) * _currentHealth, HealthBar.transform.localScale.y);
    }
}