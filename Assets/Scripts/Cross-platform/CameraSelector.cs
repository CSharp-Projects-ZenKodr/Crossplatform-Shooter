/*----------------------------------------
File Name: CameraSelector.cs
Purpose: selects correct camera to use
Author: Tarn Cooper
Modified: 18 September 2019
------------------------------------------
Copyright 2019 Tarn Cooper.
-----------------------------------*/
using UnityEngine;

public class CameraSelector : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ovaCamera;
    public Camera pcCamera;
#if UNITY_ANDROID
    //When using android
    void Start()
    {
        pcCamera.enabled = false;
        ovaCamera.SetActive(true);
    }
    
#else
    //when using PC
    void Start()
    {
        pcCamera.enabled = true;
        ovaCamera.SetActive(false);
    }
#endif
}
