using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the random activation of an Animator component.
/// </summary>
/// <remarks>
/// Authors: Colby Bailey
/// Date: September 10, 2023
/// </remarks>
public class randomAnimation : MonoBehaviour
{
    private Animator animator;
    private float randomNumber = 1.0f;

    void Start( )
    {
        // Generate a random delay time before activating the Animator.
        randomNumber = Random.Range( 0.0f, 4.0f );

        animator = this.GetComponent< Animator >( );
        StartCoroutine( waitForAnimation( ) );
    }

    /// <summary>
    /// Waits for a random duration and then activates the Animator.
    /// </summary>
    IEnumerator waitForAnimation( )
    {
        yield return new WaitForSeconds( randomNumber );
        
        CheckNullReferences( );

        try 
        {
            // Enable Animator to start animation
            animator.enabled = true;
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
        if( animator == null )
            throw new System.NullReferenceException( "animator in randomAnimation script is null" );
    }
}
