using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPositionTriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
        other.gameObject.transform.position = new Vector3(100.0f + Random.Range(0.0f, 5.0f), 32.2f, 100.0f + Random.Range(0.0f, 5.0f));
        rb.velocity = new Vector3(0, 0, 0);
    }
}
