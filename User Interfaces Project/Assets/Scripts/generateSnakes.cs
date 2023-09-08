using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Generates snakes at intervals
/// </summary>
/// <remarks>
/// Authors: Colby Bailey
/// Date: September 10, 2023
/// </remarks>
public class generateSnakes : MonoBehaviour
{
    private GameObject snake;
    private float randomTime;

    void Start( )
    {
        snake = GameObject.Find( "Snake" );
        StartCoroutine( waitThisAmount( ) );
    }

    /// <summary>
    /// Coroutine generates snakes at random time intervals.
    /// </summary>
    /// <remarks>
    /// This method generates snakes by instantiating a GameObject and waits for a random
    /// time interval before creating the next one.
    /// </remarks>
    IEnumerator waitThisAmount( )
    {
        CheckNullReferences( );
        
        while( true )
        {
            try
            {
                Instantiate( snake, this.transform.position, Quaternion.identity );
            }
            catch( System.Exception e )
            {
                Debug.LogError( "An error occurred at: " + e.Message );
                Application.Quit( );
            }
            randomTime = Random.Range( 10.0f, 30.0f );
            yield return new WaitForSeconds( randomTime );
        }
    }

    /// <summary>
    /// Checks for null references and throws an exception if the snake GameObject is null.
    /// </summary>
    /// <exception cref="System.NullReferenceException">
    /// Thrown when the snake GameObject is null.
    /// </exception>
    void CheckNullReferences( )
    {
        if( snake == null )
            throw new System.NullReferenceException( "snake in generateSnakes script is null" );
    }
}
