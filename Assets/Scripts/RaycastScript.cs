using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Mouse X");
        float yDirection = Input.GetAxis("Mouse Y");

        transform.Rotate(-yDirection, xDirection, 0);

        checkIfRaycastHit();
    }

    private void checkIfRaycastHit()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            print(hit.collider.gameObject.name + " has been destroyed");
            Destroy(hit.collider.gameObject);
        }
    }
}

