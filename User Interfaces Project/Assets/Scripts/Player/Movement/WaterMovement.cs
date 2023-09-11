using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WaterMovement : MonoBehaviour
{
    [SerializeField] PlayerConfig playerConfig;

    float vertical = 0f;
    float rotation = 0f;

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

    void FixedUpdate(){
        VerticalInputCheck();
        RotationInputCheck();

        ReduceVelocity();
    }


    public void Swim(float input){
        vertical = input;
    }

    void VerticalInputCheck(){
        if (vertical > 0){
            playerConfig.body.AddForce(transform.up * vertical * playerConfig.swimForce);
        } else if (vertical < 0){
            playerConfig.body.velocity /= playerConfig.brakeForce;
        }
        
    }

    public void Rotate(float input){
        rotation = input;
    }

    void RotationInputCheck(){
        transform.Rotate(-Vector3.forward * rotation * playerConfig.turnSpeed * strafeTurnMultipler * Time.deltaTime);
    }

    public void BeginBoost(){
        playerConfig.swimForce *= playerConfig.boostMultiplier;
    }

    public void EndBoost(){
        playerConfig.swimForce /= playerConfig.boostMultiplier;
    }

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

    void ReduceVelocity(){
        Vector3 reverseForce = -playerConfig.body.velocity * playerConfig.velocityDecay;
        playerConfig.body.AddForce(reverseForce * Time.deltaTime);
    }
}
