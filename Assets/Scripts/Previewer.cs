using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;




public class Previewer : MonoBehaviour
{

    public Material previewMaterial;

    public GameObject strip0;
    public GameObject strip1;
    public GameObject strip2;
    public GameObject strip3;
    public GameObject strip4;
    public GameObject strip5;

    public static Vector3 currentPos;

    public static GameObject currentStrip;

    public static GameObject currentStripName;
    public static GameObject instantiatedStrip;
    public static Renderer rend;
    public static GameObject globalParent;
    public static Transform spawnedTransform; 

    public static int rayStreetBaseMask;

    public static bool rayWorked;

    public static RaycastHit mouseHitOnStreet;

    public static Vector3 currentMouseHitOnStreetPos;

    private Vector3 flippedRotAngles = new Vector3(0, 0, 0);
    private Transform flippedSpawnedTransform;
    private float flippedAngle;

    private bool flipped;

    private int flipAngle;


    // Start is called before the first frame update
    void Start()
    {
        currentStrip = Instantiate(strip0, new Vector3(0, 0, 0), Quaternion.Euler(flippedRotAngles));
        GetStripType();
        rayStreetBaseMask = 1 << 11;
        Vector3 rot = currentStrip.transform.rotation.eulerAngles;
        //flippedRot = rot;
        flipped = false;
    }

    
    void Update()
    {
        // Get the placed street and its transform.
        globalParent = ARTapToPlaceObject.spawnedObject;
        spawnedTransform = globalParent.transform;

        // Get the placed street's rotation.
        Vector3 globalParentRot = globalParent.transform.rotation.eulerAngles;
        flippedRotAngles = new Vector3 (globalParentRot.x, globalParentRot.y + flipAngle, globalParentRot.z);

        currentStrip.transform.rotation = Quaternion.Euler(flippedRotAngles);

        Debug.Log("previewer/70_flippedRot is: " + flippedRotAngles);

        
        
        if(Application.isEditor)
        {
            if(Input.GetMouseButtonDown(0))
            {
                if (Input.mousePosition.y < Screen.height - 350 && Input.mousePosition.y > 200)
                {
                    //Debug.Log("valid mouse area");
                    if(Physics.Raycast(Camera.main.ScreenPointToRay (Input.mousePosition), out mouseHitOnStreet, Mathf.Infinity, 2048))
                    {
                        //Debug.Log("mouseHitonStreet detected: " + mouseHitOnStreet);
                        //currentStrip.transform.position = mouseHitOnStreet.point;
                        rayWorked = true;
                        currentMouseHitOnStreetPos = mouseHitOnStreet.point;

                        currentStrip.transform.position = currentMouseHitOnStreetPos;
                    }

                }
                else
                {
                    //Debug.Log("invalid mouse area");
                }
                
            }
        }
        else
        {
            if(Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved)
                {
                    if(Physics.Raycast(Camera.main.ScreenPointToRay (Input.mousePosition), out mouseHitOnStreet, Mathf.Infinity, 2048))
                    {

                        currentMouseHitOnStreetPos = mouseHitOnStreet.point;
                        currentStrip.transform.position = currentMouseHitOnStreetPos;

                    }
                }
            }
        }
    }
        




    public void GetStripType()
    {
        currentStrip.SetActive(false);
        newStrip();
    }



    public void ButtonStripType()
    {
        currentStrip.SetActive(false);
        newStrip();
    }



    public float RoundToQuarters(float numToRound)
    {
        float roundedToQuarters = Mathf.Round( numToRound * 4f ) / 4f;
        return roundedToQuarters;

    }


    
    public void buttonChangeStrip(GameObject currentButtonGO)
    {
        currentStripName = currentButtonGO;

        currentStrip.SetActive(false);

        newStrip();

    }

    
    // Update the previewed Strip to the new type.
    public void newStrip()
    {
        currentStrip = Instantiate(currentStripName, mouseHitOnStreet.point, Quaternion.Euler(flippedRotAngles)); //globalParent.transform.rotation);
        //currentStrip = Instantiate(getButtonName.currentButtonStrip, currentPos, globalParent.transform.rotation); 
        currentStrip.transform.SetParent(globalParent.transform);

        
        foreach (Transform child0 in currentStrip.transform)
        {
            rend = child0.GetComponent<Renderer>();
            rend.material = previewMaterial;
            foreach (Transform child1 in child0)
            {
                rend = child1.GetComponent<Renderer>();
                rend.material = previewMaterial;
                foreach (Transform child2 in child1)
                {
                    rend = child2.GetComponent<Renderer>();
                    rend.material = previewMaterial;
                }
            }
        }
    }


    // create actual instance of the current strip at currentPos.
    public void InstantiateStrip()
    {
        instantiatedStrip = Instantiate(currentStripName, currentMouseHitOnStreetPos, Quaternion.Euler(flippedRotAngles)); //spawnedTransform.rotation);
        instantiatedStrip.transform.SetParent(globalParent.transform);
    }



    // public void FlipStrip()
    // {
  
    //     Vector3 rot = currentStrip.transform.rotation.eulerAngles;
    //     flippedRot =  new Vector3 (rot.x, rot.y + 180, rot.z);
    //     currentStrip.transform.rotation = Quaternion.Euler(flippedRot);
    // }



    public void FlipAngle()
    {
        flipped = ! flipped;
        
        //not done here directly because it's too slow and the button needs a double click!
        UpdateFlipAngle();

    }



    public void UpdateFlipAngle()
    {
        
            if (flipped == true)
        {
            flipAngle = 180;
        }
        else
        {
            flipAngle = 0;
        }

        //Debug.Log ("flipangle is " + flipAngle);
    }

    public void GetSpawnedObject()
    {

    }
}
