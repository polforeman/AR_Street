using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Previewer : MonoBehaviour
{
    public float currentX;
    public Slider posXSlider;
    public Slider stripTypeSlider;
    public GameObject strip0;
    public GameObject strip1;
    public GameObject strip2;
    public GameObject parentStrip;

    public static Vector3 currentPos;
    public static Vector3 currentScale;
    public static GameObject currentStrip;
    public static float currentStripType;
    public static GameObject currentStripName;
    public static GameObject instantiatedStrip;
    
    // Start is called before the first frame update
    void Start()
    {
        //createdParentStrip = Instantiate(parentStr)
        currentStrip = Instantiate(strip0, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        currentPos = new Vector3(currentX, 0f, 0f);
        currentStrip.transform.position = currentPos;

    }

    public void GetX()
    {
        currentX = posXSlider.value;
    }

    public void GetStripType()
    {
        GameObject.Destroy(currentStrip);
        currentStripType = stripTypeSlider.value;
        if(currentStripType == 0)
        {currentStripName = strip0;}
        else if (currentStripType == 1)
        {currentStripName = strip1;}
        else if (currentStripType == 2)
        {currentStripName = strip2;}
        else
        {currentStripName = null;}

        currentStrip = Instantiate(currentStripName, currentPos, Quaternion.identity);
    }

    public void InstantiateStrip()
    {
        instantiatedStrip = Instantiate(currentStripName, currentPos, Quaternion.identity);
    }


}
