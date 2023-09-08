using UnityEngine;

/// <summary>
/// Controls the movement of the player character.
/// </summary>
/// <remarks>
/// Authors: Colby Bailey
/// Date: September 10, 2023
/// </remarks>
public class PlayerMovement : MonoBehaviour
{
    /// <summary>
    /// The speed at which the player moves.
    /// </summary>
    [ Header( "Speed of Player:" ) ]
    public float speed = 0.1f;

    private Vector3 moveHere;

    /// <summary>
    /// Updates the player's position based on user input.
    /// </summary>
    /// <remarks>
    /// This method calculates the movement vector based on the user's input and updates
    /// the player's position accordingly. It normalizes diagonal movement to ensure
    /// consistent speed.
    /// </remarks>
    void Update( )
    {
        // calculate vector
        moveHere = new Vector3( Input.GetAxis( "Horizontal" ), Input.GetAxis( "Vertical" ), 0.0f );
       
       CheckNullReferences( );

       try
       {
            // normalize diagonal movement
            moveHere.Normalize( ); 

            // move player
            transform.Translate( moveHere * speed * Time.deltaTime );        
       }
       catch( System.Exception e )
       {
            Debug.LogError( "An error occurred at: " + e.Message );
            Application.Quit( );
       }
    }

    /// <summary>
    /// Checks for null references and throws an exception if the moveHere vector is null.
    /// </summary>
    /// <exception cref="System.NullReferenceException">
    /// Thrown when the moveHere vector is null.
    /// </exception>
    void CheckNullReferences( )
    {
        if( moveHere == null )
            throw new System.NullReferenceException( "moveHere in PlayerMovement script is null" );
    }
}
