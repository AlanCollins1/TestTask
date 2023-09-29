using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    //public GameObject EffectPrefab;
    void Start() {
        Destroy(gameObject, 4f);
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        // Instantiate(EffectPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
   // private void OnTriggerEnter(Collider other) {
      //  Instantiate(EffectPrefab, transform.position, Quaternion.identity);
      //  Destroy(gameObject);
   // }
}
