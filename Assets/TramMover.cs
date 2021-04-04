using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TramMover : MonoBehaviour
{
    public static float zPos;
    public static Vector3 tramPos;
    public float speed = 5f;
    [SerializeField] private float minZ;
    [SerializeField] private float maxZ;
    
    // Start is called before the first frame update
    void Start()
    {
        tramPos = gameObject.transform.localPosition;
        zPos = minZ;
    }

    // Update is called once per frame
    void Update()
    {
        tramPos.x = gameObject.transform.localPosition.x;
        tramPos.y = gameObject.transform.localPosition.y;
        
        if( zPos < maxZ)
        {
            zPos = zPos + speed * Time.deltaTime;
        }
        else
        {
            zPos = minZ;
        }
        
        tramPos.z = zPos;

        gameObject.transform.localPosition = tramPos;
    }
}
