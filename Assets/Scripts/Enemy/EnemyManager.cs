using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {
    
    public GameObject EnemyPrefab;
    public Player Player;
    public RandomLoots Loots;
    public float MinDistance;
    public float MaxDistance;
    private float Radius;
    public int NumberOfEnemies;
    public List<GameObject> Enemies;
    private void Start() {
        for (int i = 0; i < NumberOfEnemies; i++) {
            GameObject _newEnemy = Instantiate(EnemyPrefab, new Vector2(RandomDistance() + Player.transform.position.x, RandomDistance() + Player.transform.position.y),Quaternion.identity);
            Debug.Log(_newEnemy.transform.position - Player.transform.position);
            Enemies.Add(_newEnemy);
            _newEnemy.GetComponent<Enemy>().Init(Player.transform);
            _newEnemy.GetComponent<EnemyHealth>().Init(Loots);
        }
    }
    public float RandomDistance() {
        return Random.Range(Mathf.Clamp(Radius, -MinDistance, -MaxDistance), Mathf.Clamp(Radius, MinDistance, MaxDistance));
    }
}
