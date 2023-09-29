using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    [SerializeField] private Transform _playerTransform; //Add to EnemyManager
    [SerializeField] private Transform _toPlayerTransform; //Add to EnemyManager
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationLerpRate = 3;
    [SerializeField] private Rigidbody2D _rigidbody;

    // private float _attackTimer;
    //[SerializeField] private float _attackPeriod = 1f;
    //[SerializeField] private float _dps;

    // [SerializeField] private PlayerHealth _playerHealth; //Add to EnemyManager

    // [SerializeField] private float _health = 50f;
    //[SerializeField] private GameObject _dieEffect;
    // private EnemyManager _enemyManager;

    public void Init(Transform playerTransform) {
        //EnemyManager enemyManager
        _playerTransform = playerTransform;
        // _enemyManager = enemyManager;
    }
    //private void Update() {
    //   if (_playerHealth) {
    //       _attackTimer += Time.deltaTime;
    //      if (_attackTimer > _attackPeriod) {
    //          _playerHealth.TakeDamage(_dps * _attackPeriod);
    //          _attackTimer = 0;
    //      } 
    //   }
    //  }

    void FixedUpdate() {
        if (_playerTransform) {
            Vector3 toPlayer = _playerTransform.position - _toPlayerTransform.position;
            Quaternion toPlayerRotation = Quaternion.LookRotation(toPlayer, Vector3.up);
            Quaternion rotation2d = Quaternion.Lerp(_toPlayerTransform.rotation, toPlayerRotation, Time.deltaTime * _rotationLerpRate);
            rotation2d = Quaternion.Euler(rotation2d.eulerAngles.x, rotation2d.eulerAngles.y, 0);
            _toPlayerTransform.rotation = rotation2d;
            _rigidbody.velocity = (_toPlayerTransform.forward * _speed);
            float angle = _toPlayerTransform.rotation.eulerAngles.y;
            angle = Mathf.Repeat(angle + 180, 360) - 180;
            if (angle < 0) {
                transform.rotation = Quaternion.Euler(0, 180, 0);

            }
            else {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
    }
}
//public void SetDamage(float value) {
//    _health -= value;
//    if (_health <= 0) {
//        Die();
//    }
//  }
//  private void Die() {
// Instantiate(_dieEffect, transform.position, Quaternion.identity);
//_enemyManager.RemoveEnemy(this);
//       Destroy(gameObject);
//   }
//}
