using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public string levels_unlocked = "levels_unlocked";



    void Start(){
        int levels = LoadPlayerData_int(levels_unlocked);

        if(levels <= 0){
            SavePlayerData(levels_unlocked, 1);
        }
    }

    public void SavePlayerData(string key, int value){
        PlayerPrefs.SetInt(key, value);
    }

    public void SavePlayerData(string key, float value){
        PlayerPrefs.SetFloat(key, value);
    }

    public void SavePlayerData(string key, string value){
        PlayerPrefs.SetString(key, value);
    }

    public int LoadPlayerData_int(string key){
        return PlayerPrefs.GetInt(key);
    }

    public float LoadPlayerData_float(string key){
        return PlayerPrefs.GetFloat(key);
    }

    public string LoadPlayerData_string(string key){
        return PlayerPrefs.GetString(key);
    }
}
