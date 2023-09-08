using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the verticle floating of a vampire fish.
/// </summary>
/// <remarks>
/// Authors: Colby Bailey
/// Date: September 10, 2023
/// </remarks>
public class moveVampireFish : MonoBehaviour
{
    private float floatHeight = 0.01f;
    private Vector3 startPos;

    void Start( )
    {
        startPos = this.transform.position;
    }

    /// <summary>
    /// Update the y position of the vampire fish to create a floating effect.
    /// </summary>
    /// <remarks>
    /// This method updates the y position of the vampire fish to create a floating
    /// effect based on a sine wave. It uses the <see cref="floatHeight"/> variable to control
    /// the height of the float.
    /// </remarks>
    void Update( )
    {
        CheckNullReferences( );

        try
        {
            float newY = startPos.y + Mathf.Sin( Time.time * 1.0f ) * floatHeight;
            this.transform.position = new Vector3( this.transform.position.x, newY, this.transform.position.z );            
        }
        catch( System.Exception e )
        {
            Debug.LogError( "An error occurred: " + e.Message );
            Application.Quit( );
        }
    }

    /// <summary>
    /// Checks for null references and throws an exception if the startPos is null.
    /// </summary>
    /// <exception cref="System.NullReferenceException">
    /// Thrown when the startPos variable is null.
    /// </exception>
    void CheckNullReferences( )
    {
        if( startPos == null )
            throw new System.NullReferenceException( "startPos in moveVampireFish script is null" );
    }
}
