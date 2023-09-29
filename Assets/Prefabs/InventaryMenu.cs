using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventaryMenu : MonoBehaviour {
    public void StartMenu() {
        Time.timeScale = 0;
    }
    public void ExitMenu() {
        Time.timeScale = 1;
    }
}
