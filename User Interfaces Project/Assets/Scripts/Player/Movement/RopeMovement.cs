using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeMovement : MonoBehaviour
{
    [SerializeField] PlayerConfig playerConfig;

    float vertical = 0f;
    float horizontal = 0f;

    float timeToNextClimb = 0f;



    void FixedUpdate(){
        if(playerConfig.ropeConnector.GetIsAttached()){
            VerticalInputCheck();
            HorizontalInputCheck();
        }
    }



    public void Swing(float input){
        horizontal = input;
    }

    void HorizontalInputCheck(){
        playerConfig.body.AddRelativeForce(transform.right * horizontal * playerConfig.swingForce);
    }

    public void Climb(float input){
        vertical = input;
    }

    void VerticalInputCheck(){
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
}
