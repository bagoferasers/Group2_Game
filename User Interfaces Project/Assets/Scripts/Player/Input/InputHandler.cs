using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// Maps every input to its corresponding function
/// </summary>
/// <remarks>
/// Authors: Ben Samuel
/// Date: September 11, 2023
/// </remarks>
public class InputHandler : MonoBehaviour
{
    [SerializeField] PlayerConfig playerConfig;



    /// <summary>
    /// Triggers player's movement for the Land ActionMap
    /// </summary>
    /// <param name="context"></param>
    public void onLandMovement(InputAction.CallbackContext context){
        playerConfig.landMovement.HorizontalInputCheck(context.ReadValue<float>());
    }
    /// <summary>
    /// Triggers player's jump for the Land ActionMap
    /// </summary>
    /// <param name="context"></param>
    public void onLandJump(InputAction.CallbackContext context){
        if (context.performed){
            playerConfig.landMovement.Jump();
        }
    }
    /// <summary>
    /// Triggers player's dash for the Land ActionMap
    /// </summary>
    /// <param name="context"></param>
    public void onLandDash(InputAction.CallbackContext context){
        if (context.performed){
            playerConfig.landMovement.Dash();
        }
    }
    /// <summary>
    /// Triggers and ends player's sprint for the Land ActionMap
    /// </summary>
    /// <param name="context"></param>
    public void onLandSprint(InputAction.CallbackContext context){
        if (context.performed){
            playerConfig.landMovement.BeginSprint();
        }
        if (context.canceled){
            playerConfig.landMovement.EndSprint();
        }
    }
    /// <summary>
    /// Triggers player's rope attachment for the Land ActionMap, then switches to the Rope ActionMap
    /// </summary>
    /// <param name="context"></param>
    public void onLandClimb(InputAction.CallbackContext context){
        if (context.performed && playerConfig.ropeConnector.Attach()){
            playerConfig.inputSwitcher.SwitchInput(InputSwitcher.InputTypes.ROPE);
        }
    }



    /// <summary>
    /// Triggers player's swinging movement for the Rope ActionMap
    /// </summary>
    /// <param name="context"></param>
    public void onRopeSwing(InputAction.CallbackContext context){
        if (context.performed){
            playerConfig.ropeMovement.HorizontalInputCheck(context.ReadValue<float>());
        }
    }
    /// <summary>
    /// Triggers player's climbing movement for the Rope ActionMap
    /// </summary>
    /// <param name="context"></param>
    public void onRopeClimb(InputAction.CallbackContext context){
        if (context.performed || context.canceled){
            playerConfig.ropeMovement.VerticalInputCheck(context.ReadValue<float>());
        }
    }
    /// <summary>
    /// Triggers player's dettachment from the rope, then switches to the Land ActionMap
    /// </summary>
    /// <param name="context"></param>
    public void onRopeJump(InputAction.CallbackContext context){
        if (context.performed && playerConfig.ropeConnector.Dettach()){
            playerConfig.inputSwitcher.SwitchInput(InputSwitcher.InputTypes.LAND);
        }
    }



    /// <summary>
    /// Triggers player's movement for the Water ActionMap
    /// </summary>
    /// <param name="context"></param>
    public void onWaterMovement(InputAction.CallbackContext context){
        if (context.performed || context.canceled){
            playerConfig.waterMovement.VerticalInputCheck(context.ReadValue<float>());
        }
    }
    /// <summary>
    /// Triggers player's rotation for the Water ActionMap
    /// </summary>
    /// <param name="context"></param>
    public void onWaterRotate(InputAction.CallbackContext context){
        if (context.performed || context.canceled){
            playerConfig.waterMovement.HorizontalInputCheck(context.ReadValue<float>());
        }
    }
    /// <summary>
    /// Triggers player's boost (sprint) for the Water ActionMap
    /// </summary>
    /// <param name="context"></param>
    public void onWaterBoost(InputAction.CallbackContext context){
        if (context.performed){
            playerConfig.waterMovement.BeginBoost();
        }
        if (context.canceled){
            playerConfig.waterMovement.EndBoost();
        }
    }
    /// <summary>
    /// Triggers player's strafe (dash) for the Water ActionMap
    /// </summary>
    /// <param name="context"></param>
    public void onWaterStrafe(InputAction.CallbackContext context){
        if (context.performed || context.canceled){
            playerConfig.waterMovement.Strafe(context.ReadValue<float>());
        }
    }

    public void onAim(InputAction.CallbackContext context){
        if (context.performed){
            playerConfig.weaponManager.Aim(context.ReadValue<Vector2>());
        }
    }

    public void onSwitchWeapon(InputAction.CallbackContext context){
        if (context.performed){
            playerConfig.weaponManager.SwitchWeapon((int) context.ReadValue<float>());
        }
    }

    public void onShoot(InputAction.CallbackContext context){
        if (context.performed){
            playerConfig.weaponManager.Shoot();
        }
    }
}
