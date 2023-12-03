using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSettings : EntitySettings
{
    [Header("Object Assignments")]
    public PlayerMovement playerMovement;
    public SaveData saveData;
    [Header("Movement Settings")]
    public float speed = 5f;
    [Header("Breath Settings")]
    public float breathSeconds = 180f;
    public int drownDamage = 5;
    public float drownRate = 1f;
    [Header("Parts")]
    public int partsCollected = 0;

    void Start(){
        int savedHealth = saveData.LoadPlayerData_int(saveData.player_health);

        if(savedHealth <= 0){
            saveData.SavePlayerData(saveData.player_health, health);
        } else {
            health = savedHealth;
        }
    }
}
