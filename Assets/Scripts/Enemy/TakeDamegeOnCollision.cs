using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamegeOnCollision : MonoBehaviour {
    public EnemyHealth EnemyHealth;
    public int DamageValue;
    public bool DieOnAnyCollision;

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.rigidbody) {
            if (collision.rigidbody.GetComponent<Bullet>()) {
                EnemyHealth.TakeDamage(DamageValue);
            }
        }
        if (DieOnAnyCollision) {
            EnemyHealth.TakeDamage(10000);
        }
    }
}
