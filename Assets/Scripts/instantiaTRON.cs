using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instantiaTRON : MonoBehaviour
{
    public GameObject firstSpawnedObject;
    public GameObject secondSpawnedObject;
    GameObject globalParent;
    public static string spawnedBool = "false";
    public static GameObject firstInstantiatedParented;
    public static GameObject nextInstantiated;
    public GameObject currentStrip;
    public static float streetRot;
    public Slider xPos;
    public Slider streetType;
    private float currentXPos = -100f;
    private int currentStreetType = 0;

    public static bool gotXPos;
    public static bool gotStreetType;

    public GameObject strip0;
    public GameObject strip1;
    public GameObject strip2;
    public GameObject strip3;
    public GameObject strip4;
    public GameObject strip5;

    public static int currentStripWidth = 2;

    public GameObject ghost;
    public static GameObject currentGhost;
    public static Renderer rend;

    public static Vector3 currentPos;

    private static Vector3 stripWidth;
    public static GameObject currentPreview;
    private GameObject oldPreview;
    
    // Start is called before the first frame update
    void Start()
    {
        
        globalParent = ARTapToPlaceObject.spawnedObject;

        // currentGhost = Instantiate(ghost, new Vector3 (0, 0, 0), Quaternion.identity); //, globalParent.transform);

        // rend = currentGhost.GetComponent<Renderer>();
        // rend.enabled = false;



        

        //Transform globalParentTransform = globalParent.transform;
        // Vector3 origPos = new Vector3 (0f, 0f, 0f);
        // GameObject firstInstantiated = Instantiate(firstSpawnedObject, origPos, Quaternion.identity);
        //firstInstantiatedParented = Instantiate(firstSpawnedObject, globalParentTransform, false);

        //float moveSpeed = Time.deltaTime;
        //firstInstantiatedParented.transform.Translate(moveSpeed, moveSpeed, 0);

        // Vector3 secondPos = new Vector3 (0.5f, 0f, 0f);
        // GameObject secondInstantiated = Instantiate(
        //     secondSpawnedObject, 
        //     secondPos, 
        //     Quaternion.identity
        //     );
        //secondInstantiated.transform.SetParent(spawnedTransform);

    }

    //Update is called once per frame
    void Update()
    {

            currentPos = new Vector3(0f, 1f, 1f);
            globalParent = ARTapToPlaceObject.spawnedObject;

            // if the object has been tapped into existance and xPos slider has been modified at least once
            // if((globalParent !=null) && (currentXPos != -100f))
            // {
                // currentGhost.transform.SetParent(globalParent.transform);
                // currentGhost.transform.rotation = globalParent.transform.rotation;

                // rend = currentGhost.GetComponent<Renderer>();
                // rend.enabled = true;
            // }

            //streetRot = ARTapToPlaceObject.streetRotY;
            
                        // currentPos = new Vector3 (currentXPos, -1, 0);

            //currentGhost = Instantiate(ghost, currentPos, Quaternion.identity, globalParent.transform);
            //currentGhost.transform.position = currentPos;   //used to be localposition
            
            // stripWidth = currentGhost.transform.localScale;
            // stripWidth.x = currentStripWidth;
            // currentGhost.transform.localScale = stripWidth;

            //currentPreview.transform.position = currentPos;

            currentPreview.transform.localPosition = currentPos;



    }

    public void getcurrentXPos()
    {
        currentXPos =  xPos.value;     //(int)xPos.value;
        Debug.Log("current Pos is " + currentXPos);
        //rend.enabled = true;

    }

    public void getCurrentStreetType()
    {
        currentStreetType = (int)streetType.value;
        Debug.Log("current Street Type is " + currentStreetType);
        //rend.enabled = true;
        
        changeCurrentPreview();

        if(currentStreetType == 0)
        {currentStripWidth = 2;}
        else if
        (currentStreetType == 1)
        {currentStripWidth = 3;}
        else if
        (currentStreetType == 2)
        {currentStripWidth = 2;}
        else if
        (currentStreetType == 3)
        {currentStripWidth = 2;}
        else if
        (currentStreetType == 4)
        {currentStripWidth = 3;}
        else if
        (currentStreetType == 5)
        {currentStripWidth = 3;}


    }
    
    public void InstantiaTHOR()

    {
        var spawnedTransform = globalParent.transform;

        //Vector3 RandPos = new Vector3 (Random.Range(0.7f, 1.3f),Random.Range(0.7f, 1.3f), 0);
        //currentPos = new Vector3 (currentXPos, -1, 0);  //already defined in update()
        //Vector3 RandPos = new Vector3 (0.5f, 0.5f, 0f);

        // nextInstantiated = Instantiate(secondSpawnedObject, RandPos, spawnedTransform.rotation);
        // nextInstantiated.transform.SetParent(spawnedTransform);

        if(currentStreetType == 0)
        {currentStrip = strip0;}
        else if
        (currentStreetType == 1)
        {currentStrip = strip1;}
        else if
        (currentStreetType == 2)
        {currentStrip = strip2;}
        else if
        (currentStreetType == 3)
        {currentStrip = strip3;}
        else if
        (currentStreetType == 4)
        {currentStrip = strip4;}
        else if
        (currentStreetType == 5)
        {currentStrip = strip5;}
        
        // Vector3 currentPosLower = new Vector3(currentPos.x, currentPos.y - 1, currentPos.z);
        nextInstantiated = Instantiate(
            currentStrip,            //prefab
            currentPos,                            //new Vector3 (2, 2, 0),                        //loc
            spawnedTransform.rotation,      //rot
            spawnedTransform);              //parent

    }

    public void clear()
    {
        foreach(Transform child in globalParent.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }

    public void changeCurrentPreview()
    {
        var spawnedTransform = globalParent.transform;
        
        //GameObject.Destroy (currentPreview);
        currentPreview = Instantiate(
            currentStrip,            //prefab
            currentPos,                            //new Vector3 (2, 2, 0),                        //loc
            spawnedTransform.rotation,      //rot
            spawnedTransform);  
    }
}
