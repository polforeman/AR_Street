using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=-Ad_jfl4Wjk&list=UUsVdhmw2Jittd_af5OE4HrQ&index=20

public class DataHandler : MonoBehaviour
{
    public GameObject furniture;
    private static DataHandler instance;
    public static DataHandler Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<DataHandler>();
            }
            return instance;
        }
    }
}
