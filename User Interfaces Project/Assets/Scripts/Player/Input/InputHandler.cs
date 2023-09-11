using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    [SerializeField] PlayerConfig playerConfig;



    public void onLandMovement(InputAction.CallbackContext context){
        playerConfig.landMovement.Move(context.ReadValue<float>());
    }

    public void onLandJump(InputAction.CallbackContext context){
        if (context.performed){
            playerConfig.landMovement.Jump();
        }
    }

    public void onLandDash(InputAction.CallbackContext context){
        if (context.performed){
            playerConfig.landMovement.Dash();
        }
    }

    public void onLandSprint(InputAction.CallbackContext context){
        if (context.performed){
            playerConfig.landMovement.BeginSprint();
        }
        if (context.canceled){
            playerConfig.landMovement.EndSprint();
        }
    }

    public void onLandClimb(InputAction.CallbackContext context){
        if (context.performed && playerConfig.ropeConnector.Attach()){
            playerConfig.inputSwitcher.SwitchInput(InputSwitcher.InputTypes.ROPE);
        }
    }



    public void onRopeSwing(InputAction.CallbackContext context){
        if (context.performed){
            playerConfig.ropeMovement.Swing(context.ReadValue<float>());
        }
    }

    public void onRopeClimb(InputAction.CallbackContext context){
        if (context.performed || context.canceled){
            playerConfig.ropeMovement.Climb(context.ReadValue<float>());
        }
    }

    public void onRopeJump(InputAction.CallbackContext context){
        if (context.performed && playerConfig.ropeConnector.Dettach()){
            playerConfig.inputSwitcher.SwitchInput(InputSwitcher.InputTypes.LAND);
        }
    }



    public void onWaterMovement(InputAction.CallbackContext context){
        if (context.performed || context.canceled){
            playerConfig.waterMovement.Swim(context.ReadValue<float>());
        }
    }

    public void onWaterRotate(InputAction.CallbackContext context){
        if (context.performed || context.canceled){
            playerConfig.waterMovement.Rotate(context.ReadValue<float>());
        }
    }

    public void onWaterBoost(InputAction.CallbackContext context){
        if (context.performed){
            playerConfig.waterMovement.BeginBoost();
        }
        if (context.canceled){
            playerConfig.waterMovement.EndBoost();
        }
    }

    public void onWaterStrafe(InputAction.CallbackContext context){
        if (context.performed || context.canceled){
            playerConfig.waterMovement.Strafe(context.ReadValue<float>());
        }
    }
}
