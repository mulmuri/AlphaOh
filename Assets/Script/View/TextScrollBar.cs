using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScrollBar : MonoBehaviour
{
    public Scrollbar textScrollbar;
    public GameObject TextBoxBox;

    private RectTransform rectTransform;

    public void ScrollChange() {
        int num = TextBoxBox.transform.childCount;

        float scrollValue = textScrollbar.GetComponent<Scrollbar>().value;

        rectTransform = TextBoxBox.GetComponent<RectTransform>();
        float temp = rectTransform.anchoredPosition.y;

        if(num > 5)
        {
            rectTransform.anchoredPosition = new Vector3(0, scrollValue*(-0.2f)*(num-5), -10);
        }
    }
}
