using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UITimingManager : MonoBehaviour
{
    public TextMeshProUGUI instructions;
    public TextMeshProUGUI updates;
    //public GameObject bottomPanel;
    public CanvasGroup ARUI;
    public CanvasGroup Title;
    
    // Start is called before the first frame update
    void Start()
    {
        instructions.text = "";
        updates.text = "... loading ...";
        Invoke("Updates_FloatingObjs", 2.0f);
        Invoke("Instructions_intro", 2.0f);

        Invoke("Title_hide", 4.0f);

        Invoke("Updates_AnalyzingSpace", 9.0f);

        Invoke("Instructions_MovePhone", 9.0f);

        Invoke("Instructions_Spin", 14.0f);

        Invoke("Instructions_MoveToObject", 20.0f);
        
        Invoke("Instructions_TapBalloon", 26.0f);

        Invoke("Instructions_TapPlane", 30f);

        Invoke("Instructions_RotateStreet", 35f);

        Invoke("Updates_Empty", 35f);

        Invoke("Instructions_ChooseAStrip", 45f);

        Invoke("Instructions_PlaceAStrip", 55f);

        Invoke("Instructions_MovePreviewer", 67f);

        Invoke("Instructions_ExtraOptions1", 76f);

        Invoke("Instructions_ExtraOptions2", 81f);


        Invoke("Instructions_HaveFun", 86f);

        Invoke("Updates_HaveFun", 86f);


        Invoke("Updates_Empty", 96);

        Invoke("Instructions_Empty", 96);




        //Invoke("Look around ")

        
        ARUI.alpha = 0f;
        ARUI.interactable = false;
        ARUI.blocksRaycasts = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Application.isEditor)
        {
            Invoke("TEST_TurnOnUI", 60f);
        }
        else
        {
            if(ARTapToPlaceObject.spawnedObject != null)
            {
                TEST_TurnOnUI();
            }
        }
            
    }

    void Updates_FloatingObjs()
    {
        updates.text = "... generating virtual models ...";
    }

    void Instructions_intro()
    {
        instructions.text = "Welcome! follow this quick introduction to Augmented Reality before you proceed";
    }

    void Updates_AnalyzingSpace()
    {
        updates.text = "... analyzing your environment ...";
    }

    void Instructions_MovePhone()
    {
        instructions.text = "Move your phone slowly in all directions";
    }

    void Title_hide()
    {
        Title.alpha = 0f;
        Title.interactable = false;
        Title.blocksRaycasts = false;
    }

    void Instructions_Spin()
    {
        instructions.text = "Spin around slowly to see all the balloons hidden around you";
    }

    void Instructions_MoveToObject()
    {
        instructions.text = "Move in the real world to get closer to one of the balloons. Be careful not to trip on real obstacles or get in the way of cars!";
    }

    void Instructions_TapBalloon()
    {
        //instructions.text = "Tap on the balloon to select it";

        instructions.text = "Now look around the floor until you see some dotted areas appear";
    }

    void Instructions_TapPlane()
    {
        instructions.text = "Tap on some dotted area that is placed on the floor level (not on a table, chair, or other object!)";

    }


    void Updates_Empty()
    {
        updates.text = "";
    }

    void Instructions_RotateStreet()
    {
        instructions.text = "Drag the slider at the top of the screen to adjust the street's rotation so it fits the real environment";
    }
    
    void Instructions_ChooseAStrip()
    {
        instructions.text = "Drag the bottom list of street elements to see them all and tap on one to place it in the real world";
        
    }

    void Instructions_PlaceAStrip()
    {
        instructions.text = "Tap on any place on the floor plane to change the position of the street element. Tap on 'place strip' when done";
        
    }

    void Instructions_MovePreviewer()
    {
        instructions.text = "Tap somewhere else on the floor plane so the Preview doesn't cover your placed element";
        
    }

    void Instructions_ExtraOptions1()
    {
        instructions.text = "Tap on 'flip strip' to invert the direction of the element before placing it";
        
    }

    void Instructions_ExtraOptions2()
    {
        instructions.text = "Tap on 'change camera' to see a top of view of your current design";
        
    }


    void Instructions_HaveFun()
    {
        instructions.text = "That's it! Remember to move around in the real world to see your design from different angles";
        
    }

    void Instructions_Empty()
    {
        instructions.text = "";
        
    }



    void Updates_HaveFun()
    {
        updates.text = "Have fun :)";
    }





    void TEST_TurnOnUI()
    {
        ARUI.alpha = 1.0f;
        ARUI.interactable = true;
        ARUI.blocksRaycasts = true;
    }




}
