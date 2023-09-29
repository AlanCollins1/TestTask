using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : Health {
    [SerializeField] private float _maxHealth;
    // [SerializeField] private float _regenerationPeriod;

    //public event Action<float, float> OnHealthChange;
    public event Action OnDie;
    [SerializeField] private Image HealthBar;
    //private GameStateManager _gameStateManager;

    //public void Init(GameStateManager gameStateManager) {
    //    _gameStateManager = gameStateManager;
    //}

    private void Start() {
        SetHealth(_maxHealth);
    }
    public override void SetHealth(float value) {
        base.SetHealth(value);
        _currentHealth = value;
        //OnHealthChange?.Invoke(_currentHealth, _maxHealth);
        HealthBar.transform.localScale = new Vector2((1 / _maxHealth) * _currentHealth, HealthBar.transform.localScale.y);
    }

    //}
    public override void Die() {
        base.Die();
        //OnDie?.Invoke();
    }
}
