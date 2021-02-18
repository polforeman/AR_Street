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

    private GameObject spawnedObject;
    private ARRaycastManager _arRaycastManager;
    private Vector2 touchPosition;
    public static float streetRotY;
    public Slider rotSlider;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
    
    // Start is called before the first frame update
    private void Awake()
    {
        _arRaycastManager = GetComponent<ARRaycastManager>();
    }

    public void getSlider()
    {
        streetRotY = rotSlider.value;
    }

    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if (Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(index: 0).position;
            return true;

            // // don't place the object on tap on the UI elements
            // if (touchPosition.y < Screen.height - 400) //&& touchPosition.y > Screen.height + 400)
            // {
            //     return true;
            // }
            // else
            // {
            //     return false;
            // }
        }

        touchPosition = default;
        return false;
    }

    // public static bool IsPointOverUIObject(this Vector2 pos)
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
    void Update()
    {
        
        if (!TryGetTouchPosition(out Vector2 touchPosition))
            return;

        if(_arRaycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
        {
            var hitPose = hits[0].pose;

            if(spawnedObject == null)
            {
                spawnedObject = Instantiate(objectToInstantiate, hitPose.position, hitPose.rotation);
            }
            else
            {
                spawnedObject.transform.position = hitPose.position;
            }
        }

    }
}
