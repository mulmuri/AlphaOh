using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMenu : MonoBehaviour
{
    //public GameObject black_screen;
    public GameObject MainMenu;
    public GameObject menu;

    private void OnMouseDown() {
        /*black_screen.gameObject.SetActive(true);
        menu.gameObject.SetActive(true);*/

        MainMenu.GetComponent<MainMenu>().ShowMenu1(menu);
    }
}