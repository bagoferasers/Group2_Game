using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelWin : MonoBehaviour
{
    [SerializeField] UnityEvent win;
    [SerializeField] SaveData data;
    [SerializeField] public int totalEnemies = -1;

    bool winState = false;

    

    void Update(){
        if(totalEnemies == 0 && !winState){
            data.SavePlayerData(data.levels_unlocked, data.LoadPlayerData_int(data.levels_unlocked) + 1);
            win.Invoke();
            winState = true;
        }
    }
}
