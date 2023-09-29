using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LootButton : MonoBehaviour {
    public int LootID = -1;
    public Image LootSprite;
    public int Number;
    public TextMeshProUGUI LootName;
    public TextMeshProUGUI NumberText;

    public void SetLoot(Loot loot) {
        LootID = loot.LootIndex;
        LootSprite.sprite = loot.LootImage;
        LootName.text = loot.LootName;
    }
    public void AddLoot() {
        Number = Number + 1;
        Debug.Log("Number" + Number.ToString() + " : " + "LootID" + LootID.ToString());
        if (Number > 1) {
            NumberText.text = Number.ToString();
        }

    }
}
