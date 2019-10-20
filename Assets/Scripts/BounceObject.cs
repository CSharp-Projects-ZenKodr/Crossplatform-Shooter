/*----------------------------------------
File Name: BounceObject.cs
Purpose: Bounces a Object
are met.
Author: Tarn Cooper
Modified: 16 September 2019
------------------------------------------
Copyright 2019 Tarn Cooper.
-----------------------------------*/
using UnityEngine;

public class BounceObject : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // fixed Update is called once per frame
    void FixedUpdate()
    {
        //test if not moving
        if (rb.velocity == Vector3.zero)
        {
            if (Random.Range(1, 11) == 10)
            {
                rb.AddForce(new Vector3(0, 1, 0) * Random.Range(5, 7), ForceMode.Impulse); //Gves random force
            }
        }
    }
}
