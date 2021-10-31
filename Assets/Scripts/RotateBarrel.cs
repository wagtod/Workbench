using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBarrel : MonoBehaviour
{
    public Vector3 Destination { get; set; }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //move this to a controller class
        //if (Input.GetMouseButton(1))
        //{
        //    Destination = Input.mousePosition;
        //}
        //if (Input.GetMouseButton(1))
        //{
        //    Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        //    Vector3 dir = Input.mousePosition - pos;
        //    float angle = (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg) - 90;
        //    Debug.Log($"Barrel angle = {angle}");
        //    transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        //}


    }

    private void FixedUpdate()
    {
        if (Destination != null)
        {
            RotateToDestination();
        }
    }

    private void RotateToDestination()
    {
        //start here tod: how to rotate towards and not instantly.
        Vector3 direction = Destination - Camera.main.WorldToScreenPoint(transform.position);
        float angle = (Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg) - 90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
