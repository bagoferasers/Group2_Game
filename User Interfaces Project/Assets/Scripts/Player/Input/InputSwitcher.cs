using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputSwitcher : MonoBehaviour
{
    [SerializeField] PlayerConfig playerConfig;

    public enum InputTypes{LAND, ROPE, WATER};

    const string LAND_MAP = "Land";
    const string ROPE_MAP = "Rope";
    const string WATER_MAP = "Water";



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