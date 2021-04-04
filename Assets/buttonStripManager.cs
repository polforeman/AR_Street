using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class buttonStripManager : MonoBehaviour
{
    public static GameObject currentStripName;

    void changeStripValue()
    {
        string currentStrip = gameObject.GetComponentInChildren<Text>().text;
        Debug.Log("currentStrip is " + currentStrip);
        //currentStripName = strip1;
    }
}
