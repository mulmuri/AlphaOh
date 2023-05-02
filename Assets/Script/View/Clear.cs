using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Clear : MonoBehaviour
{
    public GameObject SingleMdoe;

    private void OnMouseDown() {
        /*Block.gameObject.SetActive(false);
        Inputnum.text = "";
        for(int i=0; i<10; i++)
        {
            PushCodeLock.transform.GetChild(i).gameObject.SetActive(true);
        }

        Black_screen.gameObject.SetActive(false);
        Gamemode.gameObject.SetActive(false);
        this.gameObject.SetActive(false);
        Mainmenu.gameObject.SetActive(true);*/

        SingleMdoe.GetComponent<SingleMode>().Clear1();
    }
}
