using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _streetManager : MonoBehaviour
{
    public string currentStreet;
    public static Vector3 streetRotation;
    public float streetRot;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        streetRot = ARTapToPlaceObject.streetRotY;
        gameObject.transform.rotation =
        Quaternion.Euler(0, streetRot, 0);
        // currentStreet = 
    }


}
