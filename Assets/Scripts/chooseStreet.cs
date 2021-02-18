using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chooseStreet : MonoBehaviour
{
    public static string chosenStreet;
    //public Button streetButton;

    // Start is called before the first frame update
    void Start()
    {
        Button streetButton = gameObject.GetComponent<Button>();
        streetButton.onClick.AddListener(ChangeCurrentStreet);
    }

    // Update is called once per frame
    void Update()
    {
        // if (Button.onClick = true)
        // {
            
        // }
    }

    void ChangeCurrentStreet()
    {
        chosenStreet = gameObject.name;
        //Debug.Log("Current street is " + chosenStreet);
    }
}
