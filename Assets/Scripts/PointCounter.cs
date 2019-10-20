/*----------------------------------------
File Name: PointCounter.cs
Purpose: Gets point and reacts when conditions 
are met.
Author: Tarn Cooper
Modified: 16 September 2019
------------------------------------------
Copyright 2019 Tarn Cooper.
-----------------------------------*/
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    private int counter = 0;
    public Text text;
    public ParticleSystem sparkler;
    // Start is called before the first frame update
    void Start()
    {
        sparkler.Stop(); //makes sure particle emitter is turned off
    }

    // Update is called once per frame
    private void Update()
    {
        //Displays time each frame
        if (counter != 10)
            text.text = (Time.timeSinceLevelLoad).ToString();
    }

    //Increases counter and triggers finish event
    public void IncreaseCount()
    {
        ++counter;
        if (counter == 10)
        {
            sparkler.Play(true);
            GetComponent<Canvas>().enabled = true;
        }
    }
}
