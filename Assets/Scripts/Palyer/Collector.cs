using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour {
    //[SerializeField] private float _distanceToCollect = 2f;
    //[SerializeField] private RandomLoots _randomLoots;
    public Inventory Inventory;
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.GetComponent<Loot>()){
            Loot loot = collision.gameObject.GetComponent<Loot>();
            Inventory.AddLootInInventary(loot);
            Destroy(collision.gameObject);
        }
    }
}
