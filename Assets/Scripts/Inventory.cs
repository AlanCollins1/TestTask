using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {
    //public List<GameObject> ButtonList;
    public List<LootButton> CellList;
    public GameObject RemoveButton;
    private int highlighted;

    private void Start() {
        RemoveButton.gameObject.SetActive(false);
        //for (int i = 0; i < CellList.Count; i++) {
        CellList[0].GetComponent<Toggle>().onValueChanged.AddListener(delegate {
            Toggle(CellList[0].GetComponent<Toggle>());
        });
        //}
    }

    public void AddLootInInventary(Loot loot) {
        for (int i = 0; i < CellList.Count; i++) {
            if (CellList[i].LootID == -1) {
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
    public void RemoveLoots() {
        for (int i = 0; i < CellList.Count; i++) {
            if (!CellList[i].GetComponent<Toggle>().isOn && CellList[i].Number > 0) {
                CellList[i].RemoveLoot();
                CellList[i].GetComponent<Toggle>().isOn = true;
            }
        }
        RemoveButton.SetActive(false);
    }
    public void Toggle(Toggle toggle) {
        if (toggle.GetComponent<LootButton>().Number > 0) {
            if (!toggle.isOn) {
                highlighted++;
            }
            else {
                highlighted--;
            }
            if (highlighted == 0) {
                RemoveButton.SetActive(false);
            }
            else {
                RemoveButton.SetActive(true);
            }
        }
        else {
            toggle.isOn = true;
        }

    }
}
