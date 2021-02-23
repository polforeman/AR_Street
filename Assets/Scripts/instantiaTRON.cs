using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiaTRON : MonoBehaviour
{
    public GameObject firstSpawnedObject;
    public GameObject secondSpawnedObject;
    GameObject globalParent;
    public static string spawnedBool = "false";
    public static GameObject firstInstantiatedParented;
    public static GameObject nextInstantiated;
    public static float streetRot;
    
    // Start is called before the first frame update
    void Start()
    {
        
        globalParent = ARTapToPlaceObject.spawnedObject;
        //Transform globalParentTransform = globalParent.transform;
        Vector3 origPos = new Vector3 (0f, 0f, 0f);
        GameObject firstInstantiated = Instantiate(firstSpawnedObject, origPos, Quaternion.identity);
        //firstInstantiatedParented = Instantiate(firstSpawnedObject, globalParentTransform, false);

        //float moveSpeed = Time.deltaTime;
        //firstInstantiatedParented.transform.Translate(moveSpeed, moveSpeed, 0);

        Vector3 secondPos = new Vector3 (0.5f, 0f, 0f);
        GameObject secondInstantiated = Instantiate(secondSpawnedObject, secondPos, Quaternion.identity);
        //secondInstantiated.transform.SetParent(spawnedTransform);

    }

    //Update is called once per frame
    void Update()
    {

            globalParent = ARTapToPlaceObject.spawnedObject;
            streetRot = ARTapToPlaceObject.streetRotY;

    }

    
    
    public void InstantiaTHOR()
    {
        var spawnedTransform = globalParent.transform;

        Vector3 RandPos = new Vector3 (Random.Range(-1f, 1f),Random.Range(-1f, 1f), 0);
        //Vector3 RandPos = new Vector3 (0.5f, 0.5f, 0f);

        nextInstantiated = Instantiate(secondSpawnedObject, RandPos, spawnedTransform.rotation);
        //Quaternion.identity);
        nextInstantiated.transform.SetParent(spawnedTransform);

    }
}
