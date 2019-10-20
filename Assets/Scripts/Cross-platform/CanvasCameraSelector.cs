/*----------------------------------------
File Name: CanvasCameraSelector.cs
Purpose: selects setting for canvas to use
Author: Tarn Cooper
Modified: 18 September 2019
------------------------------------------
Copyright 2019 Tarn Cooper.
-----------------------------------*/
using UnityEngine;
using UnityEngine.UI;

public class CanvasCameraSelector : MonoBehaviour
{
    public Camera ovaCamera;
    public Camera pcCamera;

#if UNITY_ANDROID
    // Sets up canvas if using android
    void Start()
    {
        GetComponent<Canvas>().worldCamera = ovaCamera;
        GetComponent<GraphicRaycaster>().enabled = false;
        GetComponent<ControllerSelection.OVRRaycaster>().enabled = true;
    }

#else
    // Sets up canvas if using PC
    void Start()
    {
        GetComponent<Canvas>().worldCamera = pcCamera;
        GetComponent<GraphicRaycaster>().enabled = true;
        GetComponent<ControllerSelection.OVRRaycaster>().enabled = false;
    }
#endif
}
