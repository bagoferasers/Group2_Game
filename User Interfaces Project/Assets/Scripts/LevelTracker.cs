using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTracker : MonoBehaviour
{
    [SerializeField] SaveData data;
    [SerializeField] Button[] buttons;



    void Start()
    {
        int levelCount = data.LoadPlayerData_int(data.levels_unlocked);
        if(levelCount > 5){
            levelCount = 5;
            data.SavePlayerData(data.levels_unlocked, levelCount);
        }
        Debug.Log(data.LoadPlayerData_int(data.levels_unlocked));

        if(buttons.Length > 0){
            for(int i = 1; i < buttons.Length; i++){
            buttons[i].GetComponent<Image>().color = Color.red;
            buttons[i].interactable = false;
            }

            for(int i = 1; i < levelCount; i++){
                buttons[i].GetComponent<Image>().color = Color.white;
                buttons[i].interactable = true;
            }
        }
    }
}
