using System.Collections;
using UnityEngine;

public class LandMovement : MonoBehaviour
{
    [SerializeField] PlayerConfig playerConfig;

    float horizontal = 0f;
    int direction = 1;

    bool isGrounded;
    bool isDashing = false;

    float groundCheckRadius = .2f;



    void FixedUpdate(){
        isGrounded = Physics2D.OverlapCircle(playerConfig.groundCheck.position, groundCheckRadius, playerConfig.layerMask);

        HorizontalInputCheck();
    }



    public void Move(float input){
        horizontal = input;
    }

    void HorizontalInputCheck(){
        if (horizontal > 0){
            direction = 1;
        } else if (horizontal < 0){
            direction = -1;
        }

        playerConfig.body.AddForce(transform.right * horizontal * playerConfig.moveForce);
    }

    public void Jump(){
        if (isGrounded){
            playerConfig.body.AddForce(transform.up * playerConfig.jumpForce, ForceMode2D.Impulse);
        }
    }

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

    public void BeginSprint(){
        playerConfig.moveForce *= playerConfig.sprintMultiplier;
    }

    public void EndSprint(){
        playerConfig.moveForce /= playerConfig.sprintMultiplier;
    }
}
