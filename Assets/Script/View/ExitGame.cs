using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public GameObject SingleMdoe;

    private void OnMouseDown() {
        /*Mainmenu.gameObject.SetActive(true);
        black_screen.gameObject.SetActive(false);
        menu.gameObject.SetActive(false);
        Gamemode.gameObject.SetActive(false);*/

        SingleMdoe.GetComponent<SingleMode>().ExitGame1();
    }
}
