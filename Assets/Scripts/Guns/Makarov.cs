using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Makarov : Gun {
    public int NumberOfBullet;
    public int MaxNumberOfBullet;
    //public Text BulletsText;
    //public PlayerArmory PlayerArmory;

    public override void Shot() {
        if (NumberOfBullet != 0) {
            base.Shot();
            NumberOfBullet--;
            TextUpdate();
        }
    }
    public override void Activate() {
        base.Activate();
       // BulletsText.enabled = true;
        TextUpdate();
    }

    public override void Deactivate() {
        base.Deactivate();
      //  BulletsText.enabled = false;
    }

    private void TextUpdate() {
      //  BulletsText.text = "Пули: " + NumberOfBullet.ToString();
    }

    public override void AddBullets(int bullets) {
        //PlayerArmory.TakeGunByIndex(1);
        NumberOfBullet += bullets;
        TextUpdate();
        if (NumberOfBullet > MaxNumberOfBullet) {
            NumberOfBullet = MaxNumberOfBullet;
        }
    }
}
