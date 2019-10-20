/*----------------------------------------
File Name: WhenShot.cs
Purpose: Reacts when shot
Author: Tarn Cooper
Modified: 16 September 2019
------------------------------------------
Copyright 2019 Tarn Cooper.
-----------------------------------*/
using UnityEngine;
using UnityEngine.EventSystems;

public class WhenShot : MonoBehaviour
{
    private Rigidbody item;
    private GameObject vrController;
    private Ray ray;
    private float force = 10;
    bool wasShot = false;

    // Start is called before the first frame update
    void Start()
    {
        vrController = GameObject.Find("RightHandAnchor"); // gets vr controller
        item = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //tests if object is below game
        if (transform.position.y < 0)
        {
            GameObject.Find("Canvas").GetComponent<PointCounter>().IncreaseCount();
            Destroy(gameObject);
        }
            

    }

    //Action when shot
    private void Shot()
    {
        Vector3 forceDirection;


        if (Application.platform == RuntimePlatform.Android) //if on android vr, gives direction of vr controller
            forceDirection = (transform.position - vrController.transform.position).normalized;
        else
            forceDirection = Vector3.forward; //gives default forward direction

        item.AddForce(forceDirection * force, ForceMode.Impulse); //adds force to direction
        item.AddTorque(new Vector3(Random.Range(-1, 2), Random.Range(-1, 1), Random.Range(-1, 2)) * force, ForceMode.Impulse); //adds force rotation
    }

    //when clicked on by mouse
    private void OnMouseDown()
    {
        Shot();
    }

    //When event for clicked is triggered
    public void isShot(BaseEventData data)
    {
        Shot();
    }

}
