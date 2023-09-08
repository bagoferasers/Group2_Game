using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Provides functionality to exit the game.
/// </summary>
/// <remarks>
/// Authors: Colby Bailey
/// Date: September 11, 2023
/// </remarks>
public class ExitGame : MonoBehaviour
{
    private bool isPressed = false;
    private MenuFader menuFader;
    private CanvasGroup fadeCanvas;

    void Start( )
    {
        menuFader = GameObject.Find( "Fade" ).GetComponent< MenuFader >( );
        fadeCanvas = menuFader.GetComponent< CanvasGroup >( );
    }

    /// <summary>
    /// Checks for an "esc" key press and exits the game when pressed. 
    /// </summary>
    /// <remarks>
    /// This method checks for the "esc" key press and quits the application
    /// when it's pressed for the first time. Subsequent presses will not exit
    /// the game to prevent accidental quitting.
    /// </remarks>
    void Update( )
    {
        if ( Input.GetKey( "escape" ) && ( !isPressed ) )
        {
            isPressed = true;
            Debug.Log( "Exiting game!" );
            Application.Quit( );
        }
    }

    /// <summary>
    /// Exits the game immediately
    /// </summary>
    /// <remarks>
    /// This method can be called to exit game without waiting for "esc" key press.
    /// It will only exit the game if it hasn't already been called before
    /// to prevent accidental quitting.
    /// </remarks>
    public void ExitNow( )
    {
        CheckNullReferences( );

        if ( !isPressed && fadeCanvas.alpha == 0 )
        {
            isPressed = true;
            try
            {
                // Call hideCanvas method from MenuFader script to
                // fade before quitting.
                menuFader.hideCanvas( menuFader.time );

                // Wait for alpha of CanvasGroup to be 1
                StartCoroutine( WaitAndQuit( ) );
            }            
            catch( System.Exception e )
            {
                Debug.LogError( "An error occurred: " + e.Message );
                Application.Quit( );            
            }
        }
    }

    /// <summary>
    /// Waits for alpha of CanvasGroup to be 1 before exiting game.
    /// </summary>
    private IEnumerator WaitAndQuit( )
    {
        while( fadeCanvas.alpha < 0.95f )
        {
            yield return null;
        }
        Debug.Log( "Exiting game!" );
        Application.Quit( );            
        yield return null;
    }

    /// <summary>
    /// Checks for null references and throws an exception if null.
    /// </summary>
    /// <exception cref="System.NullReferenceException">
    /// Thrown when the variable is null.
    /// </exception>
    void CheckNullReferences( )
    {
        if( menuFader == null )
            throw new System.NullReferenceException( "menuFader in ExitGame script is null" );
        
        if( fadeCanvas == null )
            throw new System.NullReferenceException( "fadeCanvas in ExitGame script is null" );
    }
}
