using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereSizeTest : MonoBehaviour
{
    public static Vector3 sphereSize;
    public static Vector3 streetRotation;
    public float streetRot;
    
    // Start is called before the first frame update
    void Start()
    {
        sphereSize = transform.localScale;
        streetRotation = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        streetRot = ARTapToPlaceObject.streetRotY;
        transform.localScale = sphereSize;
        // Debug.Log(sphereSize);
        gameObject.transform.rotation =
        Quaternion.Euler(0, streetRot, 0);
        // Debug.Log("rotation is " + streetRot);
        //Quaternion.EulerRotation(0, sphereRotY, 0);
        //streetRotation.y = sphereRotY;
        // Debug.Log(streetRotation);
        //gameObject.transform.localRotation = streetRotation;
    }

    public void IncreaseSize()
    {
        sphereSize = sphereSize * 1.5f;
    }

    public void DecreaseSize()
    {
        sphereSize = sphereSize / 1.5f;
    }

    public void RotateStreet()
    {
        //streetRotation.y = sphereRotY;
    }



    // public void ScaleSphere()
    // {
    //     transform.localScale = SphereSize;
    // }
}
