using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset = new Vector3(0f, 0.5f, -2f);

    public float distance = 2;

    // This is for moving the camera left and right
    public float xLowerLimit = -1f;
    public float xUpperLimit = 1f;
    // This is for tilting the camera up and down
    public float yLowerLimit = 0.3f;
    public float yUpperLimit = 1f;
    // This is for the distance of the camera behind the ball
    public float zLowerLimit = -1f;
    public float zUpperLimit = 0f;

    // This is for the camera distance
    public float distanceLowerLimit = 0f;
    public float distanceUpperLimit = 10;
    void FixedUpdate()
    {

        offset /= distance;

        // This is for tilting the camera up and down
        offset.y += Input.GetAxis("Mouse Y") / 10.0f;
        // This is for rotating the camera left and right
        offset.x += Input.GetAxis("Mouse X") / 10.0f;

        distance -= Input.GetAxis("Mouse ScrollWheel");

        distance = setBetween(distance, distanceLowerLimit, distanceUpperLimit);
        offset.x = setBetween(offset.x, xLowerLimit, xUpperLimit);
        offset.y = setBetween(offset.y, yLowerLimit, yUpperLimit);

        offset *= distance;
        offset.z = -distance;
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }

    private float setBetween(float value, float lowerLimit, float upperLimit)
    {
        value = Mathf.Max(value, lowerLimit);
        return Mathf.Min(value, upperLimit);
    }
}