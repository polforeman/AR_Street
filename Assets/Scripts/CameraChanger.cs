using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraChanger : MonoBehaviour
{
    [SerializeField] private GameObject cameraAR;
    [SerializeField] private GameObject cameraTop;
    private bool cameraAROn = true;
    private bool cameraTopOn = false;
    private bool streetRotOn = true;

    [SerializeField] public GameObject streetRot;

    
    // Start is called before the first frame update
    void Start()
    {
        
        cameraAR.SetActive(cameraAROn);
        cameraTop.SetActive(cameraTopOn);
        streetRot.SetActive(streetRotOn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeCamera()
    {
        cameraAROn = !cameraAROn;
        cameraTopOn = !cameraTopOn;
        streetRotOn = !streetRotOn;
        cameraAR.SetActive(cameraAROn);
        cameraTop.SetActive(cameraTopOn);
        streetRot.SetActive(streetRotOn);
    }
}
