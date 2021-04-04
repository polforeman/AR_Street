using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentPosManager : MonoBehaviour
{
    private Vector2 contentPos;
    
    // Start is called before the first frame update
    void Start()
    {
        contentPos = gameObject.transform.localPosition;
        contentPos.x = 0;
        contentPos.y = 0;
        gameObject.transform.localPosition = new Vector3 (0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        contentPos = gameObject.transform.localPosition;
        Debug.Log(contentPos);
    }
}
