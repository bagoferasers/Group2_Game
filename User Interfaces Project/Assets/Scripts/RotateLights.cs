using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the circular movement of a 2D light.
/// </summary>
/// <remarks>
/// Authors: Colby Bailey
/// Date: September 10, 2023
/// </remarks>
public class CircleLights : MonoBehaviour
{
    private UnityEngine.Rendering.Universal.Light2D light2D;
    private Vector2 center;
    private Vector2 newPos;

    public float speed = 1.0f;
    public float radius = 1.0f;
    
    void Start( )
    {
        light2D = this.GetComponent< UnityEngine.Rendering.Universal.Light2D >( );
        center = light2D.transform.position;
        newPos = center;
    }

    void Update( )
    {
        CheckNullReferences( );
        
        try
        {
            // Calculate the new position based on circular movement.
            newPos = center * new Vector2( Mathf.Cos( speed * Time.time ), Mathf.Sin( speed * Time.time ) ) * radius;
            light2D.transform.position = newPos;            
        }
        catch( System.Exception e ) 
        {
            Debug.LogError( "An error occurred: " + e.Message );
            Application.Quit( );
        }
    }

    /// <summary>
    /// Checks for null references to components and throws exceptions if any are found.
    /// </summary>
    void CheckNullReferences( )
    {
        if( newPos == null )
            throw new System.NullReferenceException( "newPos in RotateLights script is null" );
        
        if( center == null )
            throw new System.NullReferenceException( "center in RotateLights script is null" );

        if( light2D == null )
            throw new System.NullReferenceException( "light2D in RotateLights script is null" );
    }
}
