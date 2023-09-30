using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyActivation : MonoBehaviour {
    [SerializeField] private List<GameObject> Enemies;
    public Transform Player;

    private void Start() {

        Enemies = GetComponent<EnemyManager>().Enemies;
        for (int i = 0; i < Enemies.Count; i++) {
            if (Enemies[i]) {
                Enemies[i].gameObject.GetComponent<Enemy>().enabled =  false;
            }
        }
    }

    void Update() {
        for (int i = 0; i < Enemies.Count; i++) {
            if (!Enemies[i]) {
                Enemies.Remove(Enemies[i]);
                i--;
            }
            else {
                if (Vector3.Distance(Enemies[i].transform.position, Player.position) <= Enemies[i].GetComponent<SetDistance>().ObjectDistance()) {
                    Enemies[i].gameObject.GetComponent<Enemy>().enabled = true;
                }
            }
        }
    }
}
