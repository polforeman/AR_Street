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
    
    public GameObject objectToInstantiate;

    public static GameObject spawnedObject;
    private ARRaycastManager _arRaycastManager;
    private Vector2 touchPosition;
    public static float streetRotY;
    public Slider rotSlider;
    public GameObject myCapsule;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
    
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
            if (touchPosition.y < Screen.height - 400) //&& touchPosition.y > Screen.height + 400)
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

    // bool IsPointOverUIObject(Vector2 pos)
    // {
    //     if (EventSystem.current.IsPointerOverGameObject())
    //     {
    //         return false;
    //     }

    //     PointerEventData eventPosition = new PointerEventData(EventSystem.current);
    //     eventPosition.position = new Vector2 (pos.x, pos.y);

    //     List<RaycastResult> results = new List<RaycastResult>();
    //     EventSystem.current.RaycastAll(eventPosition, results);

    //     return results.Count > 0;
    // }

    // Update is called once per frame

    void Start()
    {
        if(Application.isEditor)
        {spawnedObject = Instantiate(objectToInstantiate, new Vector3 (0,0,0), Quaternion.identity);}
    }

    void Update()
    {
        
        if (!TryGetTouchPosition(out Vector2 touchPosition))
            return;

        // true if a raycast from touchPosition hits a PlaneWithinPolygon
        if(_arRaycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
        {
            // saves the first hit as hitPose
            var hitPose = hits[0].pose;

            if(spawnedObject == null)
            {
                spawnedObject = Instantiate(objectToInstantiate, 
                hitPose.position, 
                hitPose.rotation);
            }

            //THIS ALLOWS REPOSITIONING OF THE SPAWNED OBJECT. TURNED OFF FOR NOW TO ALLOW
            else
            {
                spawnedObject.transform.position = hitPose.position;
            }
        }


            // for (int i = 0; i < 10; i++)
            // {
            //     Vector3 currentPos = new Vector3 (i, i, 0);
            //     GameObject currentInstance = Instantiate(myCapsule, currentPos, spawnedTransform.rotation);
            //     currentInstance.transform.SetParent(spawnedTransform);
                
            // }



            
            

            //var spawnedTransform = spawnedObject.transform;
        

    }
}
