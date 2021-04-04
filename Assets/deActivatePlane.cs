using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deActivatePlane : MonoBehaviour
{
    // Start is called before the first frame update
    Renderer planeRend;
    Color planeColor;
    bool onboardingFinished;

    void Start()
    {
        planeRend = gameObject.GetComponent<MeshRenderer>();
        //meshRend.enabled = false;

        planeColor = gameObject.GetComponent<MeshRenderer>().material.color;
        planeColor.a = 0f;

        onboardingFinished = false;
        Invoke("TurnOnPlaneMesh", 10.0f);

    }

    // Update is called once per frame
    void Update()
    {
        // if((ARTapToPlaceObject.spawnedObject = null) && (onboardingFinished = true))
        // {
        //     planeColor.a = 1.0f;
        // }
        // else
        // {
        //     planeColor.a = 0f;
        // }

        planeRend.material.color = planeColor;
    }

    void TurnOnPlaneMesh()
    {
        onboardingFinished = true;
        //meshRend.enabled = false;
    }
}
