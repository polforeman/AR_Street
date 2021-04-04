using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrthoCamManager : MonoBehaviour
{
    private float currentYRot;
    // Start is called before the first frame update
    void Start()
    {
        currentYRot = ARTapToPlaceObject.streetRotY;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = ARTapToPlaceObject.spawnedObject.transform.position;
        gameObject.transform.rotation = ARTapToPlaceObject.spawnedObject.transform.rotation;
    }    
}
