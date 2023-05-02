using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject menu;

    private void OnMouseDown() {
        /*black_screen.gameObject.SetActive(false);
        menu.gameObject.SetActive(false);*/

        MainMenu.GetComponent<MainMenu>().BackMenu1(menu);
    }
}
