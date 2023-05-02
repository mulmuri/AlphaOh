using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PushButton : MonoBehaviour
{
    public GameObject SingleMode;
    public int ButtonLabel;
    /*public TMP_Text Inputnum;
    public GameObject Block;*/

    private void OnMouseDown() {
        /*Inputnum.text += ButtonLabel;
        this.gameObject.SetActive(false);

        if(Inputnum.text.Length == 4)
        {
            Block.gameObject.SetActive(true);
        }*/

        SingleMode.GetComponent<SingleMode>().PushButton1(ButtonLabel, this.gameObject);
    }
}