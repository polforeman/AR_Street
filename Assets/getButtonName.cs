using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getButtonName : MonoBehaviour
{
    public GameObject thisButtonsStrip;
    public static GameObject currentButtonStrip;
    
    // Start is called before the first frame update
    void GetName()
    {
        currentButtonStrip = thisButtonsStrip;
    }
}
