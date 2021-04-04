using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebScaler : MonoBehaviour
{
    
    public static int receivedInt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var objTrans = transform.localScale;
        receivedInt = WebRequestManager.receivedInt;
        objTrans.y = receivedInt;
        transform.localScale = objTrans;
    }
}
