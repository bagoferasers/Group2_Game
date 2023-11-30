using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSettings : EntitySettings
{
    [Header("Object Assignments")]
    public Slider oxygenBar;
    public PlayerMovement playerMovement;
    public SaveData saveData;
    [Header("Movement Settings")]
    public float speed = 5f;
    [Header("Breath Settings")]
    public float breathSeconds = 180f;
    public int drownDamage = 5;
    public float drownRate = 1f;
}