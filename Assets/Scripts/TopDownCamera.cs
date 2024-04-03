using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class TopDownCamera : MonoBehaviour
{
    public Transform target; // The target the camera will follow
    public float height = 10f; // Height of the camera above the target
    public float distance = 10f; // Distance of the camera from the target

    public float rotationSpeed = 5f; // Speed of camera rotation

    void LateUpdate()
    {
        // Calculate the desired position based on the target's position, height, and distance
        Vector3 desiredPosition = target.position + new Vector3(0f, height, -distance);

        // Smoothly move the camera to the desired position
        transform.position = Vector3.Lerp(transform.position, desiredPosition, 0.1f);

        // Make the camera look at the target
        transform.LookAt(target);
    }
}
