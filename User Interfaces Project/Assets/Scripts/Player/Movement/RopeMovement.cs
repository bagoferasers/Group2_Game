using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Controls how the player moves while on climbing on a rope (Note: this is a typical platforming camera angle)
/// </summary>
/// <remarks>
/// Authors: Ben Samuel
/// Date: September 11, 2023
/// </remarks>
public class RopeMovement : MonoBehaviour
{
    [SerializeField] PlayerConfig playerConfig;

    float vertical = 0f;
    float horizontal = 0f;

    float timeToNextClimb = 0f;



    /// <summary>
    /// Handles physics updates
    /// </summary>
    void FixedUpdate(){
        if(playerConfig.ropeConnector.GetIsAttached()){
            Swing();
            Climb();
        }
    }



    /// <summary>
    /// Gets the player's vertical input
    /// </summary>
    /// <param name="input"></param>
    public void VerticalInputCheck(float input){
        vertical = input;
    }
    /// <summary>
    /// Uses vertical input to either climb up or slide down the rope
    /// </summary>
    void Climb(){
        if(Time.time > timeToNextClimb){
            if(vertical > 0){
                playerConfig.ropeConnector.Ascend();
                timeToNextClimb = Time.time + playerConfig.upDelay;
            } else if(vertical < 0){
                playerConfig.ropeConnector.Descend();
                timeToNextClimb = Time.time + playerConfig.downDelay;
            }
        }
    }
    /// <summary>
    /// Gets the player's horizontal input
    /// </summary>
    /// <param name="input"></param>
    public void HorizontalInputCheck(float input){
        horizontal = input;
    }
    /// <summary>
    /// Uses horizontal input to swing the player on the rope
    /// </summary>
    void Swing(){
        playerConfig.body.AddRelativeForce(transform.right * horizontal * playerConfig.swingForce);
    }
}
