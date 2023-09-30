using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {
    //public List<GameObject> ButtonList;
    public List<LootButton> CellList;
    public void AddLootInInventary(Loot loot) {
        for (int i = 0; i < CellList.Count; i++) {
            if (CellList[i].LootID == -1) {
                Debug.Log(CellList[i].Number);
                CellList[i].SetLoot(loot);
                CellList[i].AddLoot();
                return;
            }
            else if (CellList[i].LootID == loot.LootIndex) {
                CellList[i].AddLoot();
                return;
            }
        }
    }
}
