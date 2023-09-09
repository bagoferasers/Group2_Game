using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Provides functionality to transition from scene to scene.
/// </summary>
/// <remarks>
/// Authors: Bryan Alvarado
/// Date: September 9, 2023
/// </remarks>


public class SceneTransition : MonoBehaviour
{
    private bool isPressed = false;


    /// <summary>
    /// Transitions to game from Main Menu. 
    /// </summary>
    /// <remarks>
    /// This method changes the scene from main menu to the game whenever 
    /// the "Play" option is selected.
    /// </remarks>
    public void Play()
    {
        if (!isPressed)
        {
            isPressed = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    /// <summary>
    /// Transitions to game from Main Menu. 
    /// </summary>
    /// <remarks>
    /// This method changes the scene from main menu to the game whenever 
    /// the "New Game" option is selected.
    /// </remarks>
    public void NewGame()
    {
        if (!isPressed)
        {
            isPressed = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    /// <summary>
    /// Transitions to the Settings screen from Main Menu. 
    /// </summary>
    /// <remarks>
    /// This method changes the scene from main menu to settings whenever 
    /// the "Settings" option is selected.
    /// </remarks>
    public void Settings()
    {
        if (!isPressed)
        {
            isPressed = true;
            SceneManager.LoadScene("Settings");
        }
    }

    /// <summary>
    /// Transitions to the Progress screen from Main Menu. 
    /// </summary>
    /// <remarks>
    /// This method changes the scene from main menu to the progress screen whenever 
    /// the "Progress" option is selected.
    /// </remarks>
    public void Progress()
    {
        if (!isPressed)
        {
            isPressed = true;
            SceneManager.LoadScene("Progress");
        }
    }

    /// <summary>
    /// Transitions to the Credits screen from Main Menu. 
    /// </summary>
    /// <remarks>
    /// This method changes the scene from main menu to the credits scene whenever 
    /// the "Credits" option is selected.
    /// </remarks>
    public void Credits()
    {
        if (!isPressed)
        {
            isPressed = true;
            SceneManager.LoadScene("Credits");
        }
    }

    /// <summary>
    /// Transitions to the Main Menu from whatever screen the user is on. 
    /// </summary>
    /// <remarks>
    /// This method changes the scene back to the main menu whenever 
    /// the "Back" option is selected.
    /// </remarks>
    public void Back()
    {
        if (!isPressed)
        {
            isPressed = true;
            SceneManager.LoadScene("MainMenu");
        }
    }
}
