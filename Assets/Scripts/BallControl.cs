using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{

    public float xForce = 10.0f;
    public float yForce = 100.0f;
    public float zForce = 10.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // this is for the X axis' movement (moving left and right)
        float x = xForce * Input.GetAxis("Horizontal");
        // this is for the Z axis' movement (moving backwards and forwards)
        float z = zForce * Input.GetAxis("Vertical");

        // this is for the Y axis' movement (jumping)
        float y = 0.0f;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            y = yForce;
        }

        GetComponent<Rigidbody>().AddForce(x, y, z);
    }
}
