using System.Collections;
using UnityEngine;
/// <summary>
/// Controls how the player moves while on land (Note: this is a typical platforming camera angle)
/// </summary>
/// <remarks>
/// Authors: Ben Samuel
/// Date: September 11, 2023
/// </remarks>
public class LandMovement : MonoBehaviour
{
    [SerializeField] PlayerConfig playerConfig;

    float horizontal = 0f;
    int direction = 1;

    bool isGrounded;
    bool isDashing = false;

    float groundCheckRadius = .2f;


    /// <summary>
    /// Handles physics updates
    /// </summary>
    void FixedUpdate(){
        isGrounded = Physics2D.OverlapCircle(playerConfig.groundCheck.position, groundCheckRadius, playerConfig.layerMask);
        
        Move();
    }



    /// <summary>
    /// Gets the player's horizontal input
    /// </summary>
    /// <param name="input"></param>
    public void HorizontalInputCheck(float input){
        horizontal = input;
    }
    /// <summary>
    /// Uses horizontal input to set which direction the player is facing and move that way
    /// </summary>
    void Move(){
        if (horizontal > 0){
            direction = 1;
        } else if (horizontal < 0){
            direction = -1;
        }

        playerConfig.body.AddForce(transform.right * horizontal * playerConfig.moveForce);
    }
    /// <summary>
    /// Lets the player jump if they are on the ground
    /// </summary>
    public void Jump(){
        if (isGrounded){
            playerConfig.body.AddForce(transform.up * playerConfig.jumpForce, ForceMode2D.Impulse);
        }
    }
    /// <summary>
    /// Lets the player move left/right rapidly, with an input cooldown
    /// </summary>
    public void Dash(){
        StartCoroutine(DashRoutine());

        IEnumerator DashRoutine(){
            if (!isDashing){
                isDashing = true;

                playerConfig.body.velocity = Vector2.zero;
                playerConfig.body.AddForce(direction * transform.right * playerConfig.dashForce, ForceMode2D.Impulse);
                yield return new WaitForSeconds(playerConfig.dashCooldown);

                isDashing = false;
            }
        }
    }
    /// <summary>
    /// Increases the player's movement speed while the input is held
    /// </summary>
    public void BeginSprint(){
        playerConfig.moveForce *= playerConfig.sprintMultiplier;
    }
    /// <summary>
    /// Reduces the player's movement speed back to normal after the input ends
    /// </summary>
    public void EndSprint(){
        playerConfig.moveForce /= playerConfig.sprintMultiplier;
    }
}
