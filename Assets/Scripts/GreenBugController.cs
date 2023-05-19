using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBugController : MonoBehaviour
{
    [SerializeField]
    public GameObject GreenBug;
    [SerializeField]
    public RotateBarrel rotateBarrel;
    [SerializeField]
    public GameObject Topsoil;

    // Start is called before the first frame update
    void Start()
    {

    }

    //Accept arrow key movement.  Rotate the GreenBug object in the direction of movement.
    void Update()
    {
        Move();
        Rotate();
        //Stop animation of GreenBug object when no movement.
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            GreenBug.GetComponent<Animator>().enabled = false;
        }
        //Start animation of GreenBug object when movement.
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            GreenBug.GetComponent<Animator>().enabled = true;
        }
        //RotateBarrel to GreenBug
        rotateBarrel.SetDestination(Camera.main.WorldToScreenPoint(GreenBug.transform.position));
    }



    //Move the GreenBug object in the direction of keyboard movement.
    void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * 3, Space.World);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * Time.deltaTime * 3, Space.World);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 3, Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 3, Space.World);
        }
    }
    //2d Rotate the GreenBug object in the direction of keyboard movement.
    void Rotate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 270);
        }
    }
}
