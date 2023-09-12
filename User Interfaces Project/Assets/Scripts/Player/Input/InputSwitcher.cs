using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// Controls the player InputAction maps
/// </summary>
/// <remarks>
/// Authors: Ben Samuel
/// Date: September 11, 2023
/// </remarks>
public class InputSwitcher : MonoBehaviour
{
    [SerializeField] PlayerConfig playerConfig;

    public enum InputTypes{LAND, ROPE, WATER};

    const string LAND_MAP = "Land";
    const string ROPE_MAP = "Rope";
    const string WATER_MAP = "Water";



    /// <summary>
    /// Switches the active map to the new map
    /// </summary>
    /// <param name="type"></param>
    public void SwitchInput(InputTypes type){
        InputActionMap newMap;
        InputActionMap oldMap = playerConfig.input.currentActionMap;

        switch(type){
            case InputTypes.LAND:
                playerConfig.input.SwitchCurrentActionMap(LAND_MAP);
                break;
            case InputTypes.ROPE:
                playerConfig.input.SwitchCurrentActionMap(ROPE_MAP);
                break;
            case InputTypes.WATER:
                playerConfig.input.SwitchCurrentActionMap(WATER_MAP);
                break;
        }

        newMap = playerConfig.input.currentActionMap;
        DisposeActionMap(oldMap, newMap);
    }
    /// <summary>
    /// Disables the old map and enables the new map
    /// </summary>
    /// <param name="oldMap"></param>
    /// <param name="newMap"></param>
    void DisposeActionMap(InputActionMap oldMap, InputActionMap newMap){
        StartCoroutine(DisposeRoutine());

        IEnumerator DisposeRoutine(){
            yield return null;

            oldMap.Disable();
            oldMap.Dispose();

            newMap.Enable();
        }
    }
}