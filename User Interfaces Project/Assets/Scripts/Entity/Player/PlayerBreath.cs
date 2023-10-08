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
    [Header("Object Assignments")]
    [SerializeField] EntityManager entityManager;
    [Header("Breath Settings")]
    [SerializeField] float breathSeconds = 180f;
    [SerializeField] int drownDamage = 5;
    [SerializeField] float drownRate = 1f;

    bool underwater = true;
    float currentBreath;
    float lastDrownTick = 0;


    /// <summary>
    /// Handles variable initialization
    /// </summary>
    void Start(){
        currentBreath = breathSeconds;
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
    }
    /// <summary>
    /// Helper function to damage player over time
    /// </summary>
    void Drown(){
        if(Time.time > lastDrownTick + drownRate){
            entityManager.Hit(drownDamage);
            lastDrownTick = Time.time + drownRate;
        }
    }
}
