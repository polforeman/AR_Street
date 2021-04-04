using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.EventSystems;

// https://www.youtube.com/watch?v=Ilajw3BR9Bc&list=UUsVdhmw2Jittd_af5OE4HrQ&index=21

public class InputManager : MonoBehaviour
{
    [SerializeField] private GameObject arObj;
    [SerializeField] private Camera arCam;
    [SerializeField] private ARRaycastManager _raycastManager;
    [SerializeField] private int topPanelHeight;
    [SerializeField] private int bottomPanelHeight;
    

    private List<ARRaycastHit> _hits = new List<ARRaycastHit>();
    public static GameObject spawnedObject;

    private Touch touch;
    [SerializeField] private Material highlightMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //https://www.youtube.com/watch?v=_yf5vzZ2sYE&vl=en
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            var selectionRenderer = selection.GetComponent<Renderer>();
            if (selectionRenderer != null)
            {
                selectionRenderer.material = highlightMaterial;
            }
        }


        
        
        
        
        // if (Input.GetMouseButtonDown(0))
        // {
        //     Debug.Log("You tapped somewhere");
        //     Ray arRay = arCam.ScreenPointToRay(Input.mousePosition);
        //     if (_raycastManager.Raycast(arRay, _hits))
        //     {   
                
        //         Pose pose = _hits[0].pose;

        //         Debug.Log("pose X is: "+ pose.position.x + " and pose Y is: " + pose.position.y);

        //         // REMEMBER THAT YOU ARE FORCING A MUCH SMALLER RESOLUTION
        //         if (pose.position.y < Screen.height - 100 && pose.position.y > 100) 
        //         {
        //             Debug.Log("You tapped inside AR space");
        //             if(spawnedObject == null)
        //             {
        //                 spawnedObject = Instantiate(arObj, pose.position, pose.rotation);
        //             }
        //             else
        //             {
        //                 spawnedObject.transform.position = pose.position;
        //             }
        //         }
        //     }
        //}


        // touch = Input.GetTouch(0);

        // if(Input.touchCount<0 || touch.phase != TouchPhase.Began)
        // return;

        // if (IsPointerOverUI(touch)) return;

        //     Ray arRay_ = arCam.ScreenPointToRay(Input.mousePosition);  //CHECK THIS
        
        //if (!TryGetTouchPosition(out Vector2 touchPosition))
        //    return;

    }

    // bool IsPointerOverUI(Touch touch)
    // {
    //     PointerEventData eventData = new PointerEventData(EventSystem.current);
    //     eventData.position = new Vector2(touch.position.x, touch.position.y);
    //     List<RaycastResult> results = new List<RaycastResult>();
    //     EventSystem.current.RaycastAll(eventData, results);
    //     return results.Count > 0;
    // }
}
