using UnityEngine;

/// <summary>
/// This script allows the camera to smoothly follow a specified target (e.g., the previousJoint).
/// /// Attach this script to the camera GameObject and assign the previousJoint's Transform to the "previousJoint" field
/// in the Unity Inspector. Adjust the "smoothSpeed" value to control the smoothness of the camera's movement.
/// </summary>
/// <remarks>
/// Authors: Colby Bailey
/// Date: October 18, 2023
/// </remarks>
public class WormJoints : MonoBehaviour
{
    /// <summary>
    /// The Transform of the target to follow (e.g., the previousJoint).
    /// </summary>
    public Transform previousJoint;

    /// <summary>
    /// Adjust this value to control the smoothness of the camera's movement.
    /// </summary>
    public float smoothSpeed = 5.0f;

/// <summary>
/// LateUpdate is called after all Update functions have been called.
/// </summary>
/// <remarks>
/// This method ensures that the camera follows the previousJoint smoothly.
/// It calculates the desired position for the camera, interpolates the camera's
/// position using SmoothDamp, and updates the camera's position accordingly.
/// </remarks>
    private void LateUpdate( )
    {
        // Check if the previousJoint transform is valid
        if ( previousJoint != null )
        {
            // Calculate the desired position for the camera
            Vector3 desiredPosition = new Vector3( previousJoint.position.x, previousJoint.position.y, transform.position.z );

            // Use SmoothDamp to interpolate the camera's position
            Vector3 smoothedPosition = Vector3.Lerp(
                transform.position,
                desiredPosition,
                smoothSpeed * Time.deltaTime
            );

            // Update the camera's position
            transform.position = smoothedPosition;
        }
    }
}
