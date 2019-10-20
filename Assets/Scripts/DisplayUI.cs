/*----------------------------------------
File Name: DisplayUI.cs
Purpose: Set if interactable menu is displayed
Author: Tarn Cooper
Modified: 16 September 2019
------------------------------------------
Copyright 2019 Tarn Cooper.
-----------------------------------*/
using UnityEngine;

public class DisplayUI : MonoBehaviour
{
    private Canvas UI;
    // Start is called before the first frame update
    void Start()
    {
        UI = GetComponent<Canvas>(); //Gets UI
    }

    // Update is called once per frame
    void Update()
    {
        //Changes if menu is displayed when button is pressed
        if (OVRInput.Get(OVRInput.Button.Back))
        {
            UI.enabled = !(UI.enabled);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UI.enabled = !(UI.enabled);
        }
    }
}
