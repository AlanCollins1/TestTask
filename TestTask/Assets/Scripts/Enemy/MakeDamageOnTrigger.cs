using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamageOnTrigger : MonoBehaviour {
    public int DamageValue;
    private float _attackTimer;
    private void OnTriggerStay(Collider other) {
        if (other) {
            Debug.Log("Hi");
            if (other.attachedRigidbody.GetComponent<PlayerHealth>()) {  
                _attackTimer += Time.deltaTime;
                if (_attackTimer > 1) {
                    other.attachedRigidbody.GetComponent<PlayerHealth>().TakeDamage(DamageValue);
                    _attackTimer = 0;
                }
            }
        }
    }
}


