using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XButtonHandler : MonoBehaviour
{
    public void SetX(int xValue)
    {
        Text currentXValue = transform.Find("Text").GetComponent<Text>();
        xValue = int.Parse(currentXValue.text);
    }
}
