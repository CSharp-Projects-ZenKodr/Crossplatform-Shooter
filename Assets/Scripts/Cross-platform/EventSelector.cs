/*----------------------------------------
File Name: EventSelector.cs
Purpose: Selects correct event input
Author: Tarn Cooper
Modified: 18 September 2019
------------------------------------------
Copyright 2019 Tarn Cooper.
-----------------------------------*/
using UnityEngine;
using UnityEngine.EventSystems;


public class EventSelector : MonoBehaviour
{
    void Start()
    {

#if UNITY_ANDROID
         // Sets up canvas if using android
        GetComponent<ControllerSelection.OVRInputModule>().enabled = true;
        GetComponent<StandaloneInputModule>().enabled = false;
#else
        // Sets up canvas if using PC
        GetComponent<ControllerSelection.OVRInputModule>().enabled = false;
        GetComponent<StandaloneInputModule>().enabled = true;
#endif
    }
}
