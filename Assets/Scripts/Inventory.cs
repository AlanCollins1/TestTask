using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {
    //public List<GameObject> ButtonList;
    public List<LootButton> CellList;
    public void AddLootInInventary(Loot loot) {
        Debug.Log("Hi");
        for (int i = 0; i < CellList.Count; i++) {
            Debug.Log(CellList.Count);
            if (CellList[i].LootID == loot.LootIndex) {
                Debug.Log(CellList[i].name);
                CellList[i].AddLoot(loot.LootIndex);
            }
            if (CellList[i].LootID == -1) {
                CellList[i].SetLoot(loot);
                return;
            }
        }
    }
}
