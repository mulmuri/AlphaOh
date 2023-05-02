using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitApp : MonoBehaviour
{
    public GameObject MainMenu;

    private void OnMouseDown() {
        MainMenu.GetComponent<MainMenu>().ExitApp1();
    }
}
