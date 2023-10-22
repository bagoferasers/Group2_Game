using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Moves and rotates the player
/// </summary>
/// /// <remarks>
/// Authors: Ben Samuel
/// Date: September 29, 2023
/// </remarks>
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] PlayerSettings settings;

    Vector2 direction;


    /// <summary>
    /// Moves the player in the given direction
    /// </summary>
    /// <param name="x">Horizontal direction to move in</param>
    /// <param name="y">Vertical direction to move in</param>
    public void Move(int x, int y){
        if(x == 0 && y == 0){
            settings.body.velocity = Vector2.zero;
            return;
        }

        direction = new Vector2(x, y);
        SetRotation();
        settings.body.velocity = direction * settings.speed * Time.deltaTime;
    }
    /// <summary>
    /// Sets the player's rotation based on the direction of input
    /// </summary>
    public void SetRotation(){
        float angle = Vector2.SignedAngle(transform.up, direction);
        settings.sprite.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
