using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// Controls how the player moves while underwater (Note: this is a Top-Down camera angle)
/// </summary>
/// <remarks>
/// Authors: Ben Samuel
/// Date: September 11, 2023
/// </remarks>
public class WaterMovement : MonoBehaviour
{
    [SerializeField] PlayerConfig playerConfig;

    float vertical = 0f;
    float horizontal = 0f;

    float strafeTurnMultipler = 1;

    bool isStrafing = false;


    //Test function, enables water movement by default
    /*
    void Awake(){
        playerConfig.inputSwitcher.SwitchInput(InputSwitcher.InputTypes.WATER);
        playerConfig.body.gravityScale = 0;
        playerConfig.body.constraints = RigidbodyConstraints2D.None;
    }
    */
    /// <summary>
    /// Handles physics updates
    /// </summary>
    void FixedUpdate(){
        Swim();
        Rotate();

        ReduceVelocity();
    }



    /// <summary>
    /// Gets the player's vertical input
    /// </summary>
    /// <param VerticalInputCheck="input"></param>
    public void VerticalInputCheck(float input){
        vertical = input;
    }
    /// <summary>
    /// Uses vertical input to either move the player forward or slow the player down
    /// </summary>
    void Swim(){
        if (vertical > 0){
            playerConfig.body.AddForce(transform.up * vertical * playerConfig.swimForce);
        } else if (vertical < 0){
            playerConfig.body.velocity /= playerConfig.brakeForce;
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
    /// Uses horizontal input to rotate the player either clockwise or counter-clockwise
    /// </summary>
    void Rotate(){
        transform.Rotate(-Vector3.forward * horizontal * playerConfig.turnSpeed * strafeTurnMultipler * Time.deltaTime);
    }
    /// <summary>
    /// Increases the player's swimming speed while the input is held
    /// </summary>
    public void BeginBoost(){
        playerConfig.swimForce *= playerConfig.boostMultiplier;
    }
    /// <summary>
    /// Reduces the player's swmimming speed back to normal after the input ends
    /// </summary>
    public void EndBoost(){
        playerConfig.swimForce /= playerConfig.boostMultiplier;
    }
    /// <summary>
    /// Moves the player left or right rapidly and increases the speed at which the player can rotate during the movement window
    /// </summary>
    /// <param name="input"></param>
    public void Strafe(float input){
        StartCoroutine(StrafeRoutine());

        IEnumerator StrafeRoutine(){
            if (!isStrafing){
                isStrafing = true;
                strafeTurnMultipler = playerConfig.strafeTurnMultipler;

                playerConfig.body.velocity = new Vector2(0, playerConfig.body.velocity.y);
                playerConfig.body.AddForce(input * transform.right * playerConfig.strafeForce, ForceMode2D.Impulse);
                yield return new WaitForSeconds(playerConfig.strafeCooldown);

                strafeTurnMultipler = 1;
                isStrafing = false;
            }
        }
    }
    /// <summary>
    /// Continuously slows the player down, analog for water resistance
    /// </summary>
    void ReduceVelocity(){
        Vector3 reverseForce = -playerConfig.body.velocity * playerConfig.velocityDecay;
        playerConfig.body.AddForce(reverseForce * Time.deltaTime);
    }
}
