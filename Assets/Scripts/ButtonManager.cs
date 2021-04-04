using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// https://www.youtube.com/watch?v=-Ad_jfl4Wjk&list=UUsVdhmw2Jittd_af5OE4HrQ&index=20

public class ButtonManager : MonoBehaviour
{
    private Button btn;
    public GameObject furniture;
    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(SelectObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SelectObject()
    {
        DataHandler.Instance.furniture = furniture;
    }
}
