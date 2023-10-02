using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LootButton : MonoBehaviour {
    public int LootID = -1;
    public Image LootSprite;
    public int Number = 0;
    //public TextMeshProUGUI LootName;
    public TextMeshProUGUI NumberText;

    public void SetLoot(Loot loot) {
        LootID = loot.LootIndex;
        LootSprite.sprite = loot.LootImage;
        //LootName.text = loot.LootName;
    }
    public void AddLoot() {
        Number++;
        if (Number > 1) {
            NumberText.text = Number.ToString();
        }

    }
    public void RemoveLoot() {
        LootID = -1;
        LootSprite.sprite = null;
        Number--;
        if (Number > 1) {
            NumberText.text = Number.ToString();
        }
        else {
            NumberText.text = null;
        }
        //LootName.text = loot.LootName;
    }
}
