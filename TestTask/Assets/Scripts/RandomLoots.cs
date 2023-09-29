using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLoots : MonoBehaviour
{
    public List<GameObject> allLoots;

    public void Choice(Transform EnemyTransform) {
        if (allLoots.Count != 0) {
             int choise = Random.Range(0, allLoots.Count);
            CreateLoots(EnemyTransform, allLoots[choise], choise);

        }
    }
    public void CreateLoots(Transform EnemyTransform, GameObject loot, int ID) {

        GameObject newLoot = Instantiate(loot, EnemyTransform.position, Quaternion.identity);
        newLoot.GetComponent<Loot>().LootIndex = ID;
    }
}
