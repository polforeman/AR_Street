using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;
using UnityEngine.EventSystems;

// based on https://www.youtube.com/watch?v=xguiSueY1Lw&list=LL

[RequireComponent(typeof(ARRaycastManager))]

public class ARTapToPlaceObject : MonoBehaviour
{
    [SerializeField] private GameObject arObj;
    [SerializeField] private Camera arCam;
    [SerializeField] private ARRaycastManager _raycastManager;

    public static GameObject spawnedWelcome;
    [SerializeField] private GameObject welcomeSign;
    public GameObject welcomeParent;
    public static GameObject instWelcomeParent;

    List<ARRaycastHit> _hits = new List<ARRaycastHit>();
    
    
    public GameObject objectToInstantiate;

    public static GameObject spawnedObject;
    public static ARRaycastManager _arRaycastManager;
    private Vector2 touchPosition;
    public static float streetRotY;
    public Slider rotSlider;
    public GameObject myCapsule;
    //private bool IsPointerOverUI;
    

    private Touch touch;

    public static List<ARRaycastHit> hits = new List<ARRaycastHit>();
    
    // Start is called before the first frame update
    private void Awake()
    {
        _arRaycastManager = GetComponent<ARRaycastManager>();
        //myCapsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
    }

    public void getSlider()
    {
        streetRotY = rotSlider.value;
    }

    
    // returns a bool for is there current a touch going on or not, also outs the touchPosition
    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if (Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(index: 0).position;
            //return true;

            // don't place the object on tap on the UI elements
            // REMEMBER THAT THE SCREEN SIZE IS RESCALED
            if (touchPosition.y < Screen.height - 350 && touchPosition.y > 200)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        touchPosition = default;
        return false;
    }


    void Start()
    {
        
        Invoke("InstWelcomeParent", 4.0f);
        
        
        Vector3 randomStreetRot = new Vector3 (0f, Random.Range(0f, 360f), 0f);
        
        if(Application.isEditor)
        {
            spawnedObject = Instantiate(objectToInstantiate, new Vector3 (0,-1.5f,0), Quaternion.identity);
            //spawnedObject = Instantiate(objectToInstantiate, new Vector3 (0,-1.5f,0), Quaternion.Euler(randomStreetRot));
        }

        Debug.Log("steet rot is " + randomStreetRot);


        
    }

    void Update()
    {
        
        if (!TryGetTouchPosition(out Vector2 touchPosition))
            return;

        //true if a raycast from touchPosition hits a PlaneWithinPolygon
        if(_arRaycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
        {
            // saves the first hit as hitPose
            var hitPose = hits[0].pose;

            if(spawnedObject == null)
            {
                spawnedObject = Instantiate
                (objectToInstantiate, 
                hitPose.position, 
                hitPose.rotation);
                instWelcomeParent.SetActive(false);

                //Previewer.getSpawnedObject();
                
            }
            //THIS ALLOWS REPOSITIONING OF THE SPAWNED OBJECT

            //CHANGED TO REPOSITION THE LATEST STRIP!
            else
            {
                instWelcomeParent.SetActive(false);
                Debug.Log("street has been spawned");
                //Previewer.newStripWithPose(hitPose.position);
                //Previewer.instantiatedStrip.transform.position = hitPose.position;
                //Previewer.currentStrip.transform.position = hitPose.position;
            }


        } 

    }


    void InstWelcomeParent()
    { 
        instWelcomeParent = Instantiate(welcomeParent, new Vector3 (0, 0, 0), Quaternion.identity);
        
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                float randZ = Random.Range(-1.5f, 0.7f);
                
                Vector3 welcomePos = new Vector3((i * 3f)- 5f, randZ,  (j * 3f)- 5f);
                spawnedWelcome = Instantiate(welcomeSign, welcomePos, Quaternion.identity);
                spawnedWelcome.transform.SetParent(instWelcomeParent.transform);
            }
        }

        instWelcomeParent.transform.Rotate(0, 45, 0);
        //spawnedWelcome = Instantiate(welcomeSign, new Vector3 (0f, -1f, 1.5f), Quaternion.identity);
        
    }

}
