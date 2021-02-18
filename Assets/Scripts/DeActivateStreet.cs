using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeActivateStreet : MonoBehaviour
{
    private string street;
    private string gOName;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child0 in gameObject.transform)
            {
                child0.GetComponent<Renderer>().enabled = false;

                foreach (Transform child1 in child0.transform)
                {
                    child1.GetComponent<Renderer>().enabled = false;
                    foreach (Transform child2 in child1.transform)
                    {
                        child2.GetComponent<Renderer>().enabled = false;
                        foreach (Transform child3 in child2.transform)
                        {
                            child3.GetComponent<Renderer>().enabled = false;
                        }
                    }
                }
            }
    }

    // Update is called once per frame
    void Update()
    {
        street = chooseStreet.chosenStreet;
        //Debug.Log("current street value is " + street + ", I am " + gOName);

        if(gameObject.name == street)
        {
            foreach (Transform child0 in gameObject.transform)
            {
                child0.GetComponent<Renderer>().enabled = true;

                foreach (Transform child1 in child0.transform)
                {
                    child1.GetComponent<Renderer>().enabled = true;
                    foreach (Transform child2 in child1.transform)
                    {
                        child2.GetComponent<Renderer>().enabled = true;
                        foreach (Transform child3 in child2.transform)
                        {
                            child3.GetComponent<Renderer>().enabled = true;
                        }
                    }
                }
            }
        }
        else
        {
            foreach (Transform child0 in gameObject.transform)
            {
                child0.GetComponent<Renderer>().enabled = false;

                foreach (Transform child1 in child0.transform)
                {
                    child1.GetComponent<Renderer>().enabled = false;
                    foreach (Transform child2 in child1.transform)
                    {
                        child2.GetComponent<Renderer>().enabled = false;
                        foreach (Transform child3 in child2.transform)
                        {
                            child3.GetComponent<Renderer>().enabled = false;
                        }
                    }
                }
            }
        }
    }
}
