using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputNumber : MonoBehaviour
{
    /*public TMP_Text Inputnum;
    public TMP_Text turnS;
    public TMP_Text turnC;
    private string number;
    public GameObject Black_screen;
    public GameObject ClearMessage;
    public GameObject TextBoxBox;
    public GameObject TextBox;
    public GameObject ResetButton;
    public GameObject InButton;
    public int count;
    public bool checkC;*/
    public GameObject SingleMode;

    //private RectTransform rectTransform;

    private void OnMouseDown() {
        /*number = Inputnum.text;

        for(int i=0; i<TextBoxBox.transform.childCount; i++)
        {
            rectTransform = TextBoxBox.transform.GetChild(i).GetComponent<RectTransform>();
            float temp = rectTransform.anchoredPosition.y;
            rectTransform.anchoredPosition = new Vector3(0, temp+0.2f, -10);
        }
        TextBox.transform.GetChild(0).GetComponent<TMP_Text>().text = Inputnum.text;
        TextBox.transform.GetChild(1).GetComponent<TMP_Text>().text = "0S0B";
        Instantiate(TextBox, new Vector3 (0,0.1f,-10), Quaternion.identity).transform.SetParent(TextBoxBox.transform, false);

        if(number == "1234")
        {
            Black_screen.gameObject.SetActive(true);
            ClearMessage.gameObject.SetActive(true);
        }

        else
        {
            ResetButton.GetComponent<ResetNum>().Reset();
        }

        if(checkC == true)
        {
            InButton.GetComponent<InputSB>().count += 1;
            turnC.text = InButton.GetComponent<InputSB>().count.ToString() + "\nturn";
        
            RectTransform rectTransform1 = GameObject.Find("Singlemode").GetComponent<RectTransform>();
            RectTransform rectTransform2 = GameObject.Find("Challengemode").GetComponent<RectTransform>();
            rectTransform1.anchoredPosition = new Vector3(-1080, 0, 0);
            rectTransform2.anchoredPosition = new Vector3(0, 0, 0);
        }

        else
        {
            count += 1;
            turnS.text = count.ToString() + "\nturn";
        }*/

        SingleMode.GetComponent<SingleMode>().InputNumber1();
    }
}