using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMover : MonoBehaviour
{
    public float maxVehicleZ = 300;
    public float minVehicleZ = -300;
    [SerializeField] private float speed = 1;
    
    void Update() 
    {
        Vector3 vehicleLocalPos = gameObject.transform.localPosition;
        float vehicleLocalZ = vehicleLocalPos.z;

        if (vehicleLocalZ < maxVehicleZ)
        {
            vehicleLocalZ = vehicleLocalZ + (speed * Time.deltaTime);
        }
        else
        {
            vehicleLocalZ = minVehicleZ;
        }
        
        Vector3 updatedVehicleLocalPos = new Vector3 (vehicleLocalPos.x, vehicleLocalPos.y, vehicleLocalZ);

        gameObject.transform.localPosition = updatedVehicleLocalPos;

    }
}
