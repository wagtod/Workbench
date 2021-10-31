using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField]
    public RotateBarrel RotateBarrelTest;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            if (RotateBarrelTest != null)
            {
                RotateBarrelTest.Destination = Input.mousePosition;
            }
        }
    }
}
