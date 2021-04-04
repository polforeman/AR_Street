using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    
    public Material hitMaterial;
    public static GameObject __spawned;
    [SerializeField] private GameObject spawnable;
    public static LayerMask floorRayMask;
    // Start is called before the first frame update
    void Start()
    {
        //__spawned = Instantiate(spawnable, new Vector3(0, 0, 0), Quaternion.identity);
        floorRayMask = 1 << 10;
    }

    // Update is called once per frame
    void Update()
    {
        // hitPose = hits[0].pose;

        
        // if(Input.GetMouseButtonDown(0))
        // {
        //     var __ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //     RaycastHit __hitInfo;
        //     if (Physics.Raycast(__ray, out __hitInfo, 2000f, floorRayMask))
        //     {
        //         var rig = __hitInfo.collider.GetComponent<Rigidbody>();
        //             if(rig != null)
        //             {
        //                 rig.GetComponent<MeshRenderer>().material = hitMaterial;
        //             }
                
        //         __spawned.transform.position = __hitInfo.point;
        //     Debug.Log("hit a cube");
                
        //     }
        //     else
        //     {
        //     Debug.Log("didn't hit a cube");
        //     }

            //Debug.Log("rgdfd, hitInfo:" + __hitInfo);
        // }
    }
}
