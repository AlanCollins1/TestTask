using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamageOnCollision : MonoBehaviour {
    public int DamageValue;
    private float _attackTimer;
    private void OnCollisionStay2D(Collision2D collision) {
        if (collision.rigidbody) {
            
            if (collision.rigidbody.GetComponent<PlayerHealth>()) {
                _attackTimer += Time.deltaTime;
                if (_attackTimer > 1) {
                    collision.rigidbody.GetComponent<PlayerHealth>().TakeDamage(DamageValue);
                    _attackTimer = 0;
                }
            }
        }
    }
}
