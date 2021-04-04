using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSettings : MonoBehaviour
{
    //private int originalScreenWidth;
    
    [SerializeField]private int targetARScreenWidth;
    [SerializeField]private int targetARScreenHeight;


    void Awake() 
    {
        Application.targetFrameRate = 30;
        // originalScreenWidth = Screen.currentResolution.width;

        // targetARScreenWidth = originalScreenWidth / 2;
        // targetARScreenHeight = Screen.currentResolution.height / 2;

        Screen.SetResolution(targetARScreenWidth, targetARScreenHeight, false);
    }
    
}
