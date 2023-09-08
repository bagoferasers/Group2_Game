using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Controls the position and visibility of a snake GameObject.
/// </summary>
/// <remarks>
/// Authors: Colby Bailey
/// Date: September 10, 2023
/// </remarks>
public class positionSnake : MonoBehaviour
{
    private float randomDepth = 0.0f;
    private Animator snakeAnimator;
    private SpriteRenderer spriteRenderer;

    void Start( )
    {
        spriteRenderer = this.GetComponent< SpriteRenderer >( );
        snakeAnimator = this.GetComponent< Animator >( );
        
        // Randomly set the initial depth of the snake.
        randomDepth = Random.Range( 0.0f, -0.5f );
        this.transform.position = new Vector2( 0.0f, randomDepth );
        
        StartCoroutine( animateSnake( ) );
    }

    /// <summary>
    /// Controls the snake's visibility behavior.
    /// </summary>
    IEnumerator animateSnake( ) 
    {
        if( this.gameObject.name == "Snake(Clone)" )
        {
            CheckNullReferences( );

            try
            {
                // Show the snake by setting alpha to 1.
                spriteRenderer.color = new Color( spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 1 );              
            }
            catch( System.Exception e )
            {
                Debug.LogError( "An error occurred: " + e.Message );
                Application.Quit( );
            }

            // Wait for length of animation to complete.
            yield return new WaitForSeconds( snakeAnimator.GetCurrentAnimatorClipInfo( 0 )[ 0 ].clip.length );

            try 
            {
                // Hide snake by setting alpha to 0 and destroy it.
                spriteRenderer.color = new Color( spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 0 );
                Destroy( this.gameObject );    
            }
            catch( System.Exception e )
            {
                Debug.LogError( "An error occurred: " + e.Message );
                Application.Quit( );
            }
        }
        // End coroutine.
        yield return null;
    }

    /// <summary>
    /// Checks for null references to components and throws exceptions if any are found.
    /// </summary>
    void CheckNullReferences( )
    {
        if( spriteRenderer == null )
            throw new System.NullReferenceException( "spriteRenderer in positionSnake script is null" );
        
        if( snakeAnimator == null )
            throw new System.NullReferenceException( "snakeAnimator in positionSnake script is null" );
    }
}