using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Handles the player's input
/// </summary>
/// /// <remarks>
/// Authors: Ben Samuel
/// Date: September 29, 2023
/// </remarks>
public class PlayerInputs : MonoBehaviour
{
    [SerializeField] PlayerSettings settings;

    
    /// <summary>
    /// Handles physics updates
    /// </summary>
    void FixedUpdate(){
        settings.playerMovement.Move(GetHorizontal(), GetVertical());

        if(Input.GetKey(KeyCode.Mouse0)){
            settings.bulletShoot.Shoot(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }
    /// <summary>
    /// Gets the player's A/D input
    /// </summary>
    /// <returns>Integer representing horizontal input</returns>
    int GetHorizontal(){
        int input = 0;
        //Left
        if(Input.GetKey(KeyCode.A)){
            input = -1;
        }
        //Right
        if(Input.GetKey(KeyCode.D)){
            input = 1;
        }

        return input;
    }
    /// <summary>
    /// Gets the player's W/S input
    /// </summary>
    /// <returns>Integer representing vertical input</returns>
    int GetVertical(){
        int input = 0;
        //Up
        if(Input.GetKey(KeyCode.W)){
            input = 1;
        }
        //Down
        if(Input.GetKey(KeyCode.S)){
            input = -1;
        }

        return input;
    }
}
