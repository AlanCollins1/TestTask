using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
    public GameObject EnemyPrefab;
    public Player Player;
    public RandomLoots Loots;
    public int NumberOfEnemies;
    private void Start() {
        for (int i = 0; i < NumberOfEnemies; i++) {
            GameObject _newEnemy = Instantiate(EnemyPrefab, new Vector2(Random.Range(-10f, 10f), Random.Range(-10f, 10f)), Quaternion.identity);
            _newEnemy.GetComponent<Enemy>().Init(Player.transform);
            _newEnemy.GetComponent<EnemyHealth>().Init(Loots);
        }
    }
}
