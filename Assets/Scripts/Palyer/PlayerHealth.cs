using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    [SerializeField] public float _maxHealth;
    // [SerializeField] private float _regenerationPeriod;
    [SerializeField] private float _currentHealth;

    public event Action<float, float> OnHealthChange;
    public event Action OnDie;
    //private GameStateManager _gameStateManager;

    //public void Init(GameStateManager gameStateManager) {
    //    _gameStateManager = gameStateManager;
    //}

    private void Start() {
        SetHealth(_maxHealth);
    }

    public void TakeDamage(float value) {
        
        float newHealth = _currentHealth - value;
        newHealth = Mathf.Max(newHealth, 0);
        SetHealth(newHealth);
        if (newHealth == 0) {
            Die();
        }
    }
    private void SetHealth(float value) {
        _currentHealth = value;
        OnHealthChange?.Invoke(_currentHealth, _maxHealth);
    }
    public void Die() {
        OnDie?.Invoke();
     //   _gameStateManager.SetLose();
    }
}
