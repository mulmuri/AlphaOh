using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResetNum : MonoBehaviour
{
    public GameObject SingleMode;

    private void OnMouseDown() {
        //Reset();

        SingleMode.GetComponent<SingleMode>().ResetNum1();
    }

    /*public void Reset()
    {
        Inputnum.text = "";

        for(int i=0; i<10; i++)
        {
            PushCodeLock.transform.GetChild(i).gameObject.SetActive(true);
        }

        Block.gameObject.SetActive(false);
    }*/
}
