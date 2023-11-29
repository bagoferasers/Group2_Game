using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Slowly damages the player after a certain amount of time if they are underwater
/// </summary>
/// /// <remarks>
/// Authors: Ben Samuel
/// Date: October 7, 2023
/// </remarks>
public class PlayerBreath : MonoBehaviour
{
    [SerializeField] PlayerSettings settings;

    bool underwater = true;
    float currentBreath;
    float lastDrownTick = 0;


    /// <summary>
    /// Handles variable initialization
    /// </summary>
    void Start(){
        currentBreath = settings.breathSeconds;
    }
    /// <summary>
    /// Decreases breath meter and damages player over time
    /// </summary>
    void FixedUpdate(){
        if(underwater){
            DecreaseBreath();
            if(currentBreath <= 0){
                Drown();
            }
        }
    }
    /// <summary>
    /// Helper function to decrease breath
    /// </summary>
    void DecreaseBreath(){
        currentBreath -= Time.deltaTime;
        settings.oxygenBar.value = currentBreath / settings.breathSeconds;
    }
    /// <summary>
    /// Helper function to damage player over time
    /// </summary>
    void Drown(){
        if(Time.time > lastDrownTick + settings.drownRate){
            settings.entityManager.Hit(settings.drownDamage);
            lastDrownTick = Time.time + settings.drownRate;
        }
    }
}
