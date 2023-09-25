using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    [Header("Object Assignments")]
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] PlayerShoot playerShoot;

    void FixedUpdate(){
        playerMovement.Move(GetHorizontal(), GetVertical());

        if(Input.GetKey(KeyCode.Mouse0)){
            playerShoot.Shoot(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }

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
