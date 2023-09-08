using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Provides functionality to exit the game.
/// </summary>
/// <remarks>
/// Authors: Colby Bailey
/// Date: September 10, 2023
/// </remarks>
public class ExitGame : MonoBehaviour
{
    private bool isPressed = false;

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
        if ( Input.GetKey( "escape" ) && ( isPressed == false ) )
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
        if ( isPressed == false )
        {
            isPressed = true;
            Debug.Log( "Exiting game!" );
            Application.Quit( );
        }
    }
}
