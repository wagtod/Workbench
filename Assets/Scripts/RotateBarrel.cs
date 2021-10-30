using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBarrel : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
            Vector3 dir = Input.mousePosition - pos;
            float angle = (Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg) -90;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

    }
}
