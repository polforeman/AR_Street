using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveSecondCamera : MonoBehaviour
{
    public GameObject mainCamera;
    public static Vector3 secondCamPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        secondCamPosition = mainCamera.transform.position;
        secondCamPosition.x = secondCamPosition.x + 10f;
        gameObject.transform.position = secondCamPosition;
        Debug.Log("secondCamPosotion = " + secondCamPosition);
    }
}
