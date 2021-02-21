using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiaTRON : MonoBehaviour
{
    public GameObject firstSpawnedObject;
    public GameObject secondSpawnedObject;
    GameObject globalParent;
    public static string spawnedBool = "false";
    
    // Start is called before the first frame update
    void Start()
    {
        //myCodeCapsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        globalParent = ARTapToPlaceObject.spawnedObject;
        Vector3 origPos = new Vector3 (0f, 0f, 0f);
        GameObject firstInstantiated = Instantiate(firstSpawnedObject, origPos, Quaternion.identity);
        
        Vector3 secondPos = new Vector3 (0.5f, 0f, 0f);
        GameObject secondInstantiated = Instantiate(secondSpawnedObject, secondPos, Quaternion.identity);
        //currentInstantiated.transform.SetParent(spawnedTransform);

    }

    // Update is called once per frame
    void Update()
    {

    }

    
    
    public void InstantiaTHOR()
    {
        var spawnedTransform = globalParent.transform;

        Vector3 RandPos = new Vector3 (Random.Range(-1f, 1f),Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        //Vector3 RandPos = new Vector3 (0.5f, 0.5f, 0f);

        GameObject nextInstantiated = Instantiate(secondSpawnedObject, RandPos, Quaternion.identity);
        //nextInstantiated.transform.SetParent(spawnedTransform);

    }
}
