using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBarrel : MonoBehaviour
{
    public Vector3 Destination { get; private set; }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    private float _speed = 3.0f;

    private void FixedUpdate()
    {
    }

    public void SetDestination(Vector3 newDest)
    {
        Debug.Log(newDest.ToString());
        Destination = newDest;
        StartCoroutine(RotateToDestination());
    }

    private IEnumerator RotateToDestination()
    {
        Quaternion targetRotation = Quaternion.identity;
        do
        {
            Vector3 direction = (Destination - Camera.main.WorldToScreenPoint(transform.position));
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            targetRotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, _speed * Time.deltaTime);

            //Debug.Log(Quaternion.Angle(transform.rotation, targetRotation));
            yield return null;

        } while (Quaternion.Angle(transform.rotation, targetRotation) > 0.01f);
    }

}
