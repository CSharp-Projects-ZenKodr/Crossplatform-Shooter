/*----------------------------------------
File Name: WhenShooting.cs
Purpose: reacts to shooting
Author: Tarn Cooper
Modified: 16 September 2019
------------------------------------------
Copyright 2019 Tarn Cooper.
-----------------------------------*/
using UnityEngine;

public class WhenShooting : MonoBehaviour
{
    private LineRenderer line;

    private float delay = 0.1f;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>(); //gets line renderer
    }

    // Update is called once per frame
    void Update()
    {

        if (timer > 0) //when timer is triggered
        {
            timer -= Time.deltaTime;
            line.materials[1].color = Color.red;
        }
        else // default colour
        {
            line.materials[1].color = Color.white;
        }

        //reacts when trigger is pulled
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) && timer <=0 )
        {
            timer = delay;
        }
    }
}
