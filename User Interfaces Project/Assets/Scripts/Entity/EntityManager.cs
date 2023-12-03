using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
/// <summary>
/// Manages the stats and status of any entity objects
/// </summary>
/// /// <remarks>
/// Authors: Ben Samuel
/// Date: November 26, 2023
/// </remarks>
public class EntityManager : MonoBehaviour
{
    [SerializeField] EntitySettings settings;

    [SerializeField] UnityEvent playerDeath;
    [SerializeField] LevelWin levelWin;



    void Awake(){
        //Debug.Log(gameObject);
        levelWin.totalEnemies++;
    }
    /// <summary>
    /// Reduces entity's health
    /// </summary>
    /// <param name="damage">Amount to reduce health by</param>
    public void Hit(int damage){
        settings.health -= damage;
        settings.healthBar.UpdateHealthbar(settings.health, settings.maxHealth);
        if(settings.health <= 0){
            Die();
        }
    }
    /// <summary>
    /// Kills the entity
    /// </summary>
    void Die(){
        if(gameObject.tag == "Player"){
            playerDeath.Invoke();
        } else {
            levelWin.totalEnemies--;
            Destroy(gameObject);
        }
    }
    /// <summary>
    /// Getter for entity's health
    /// </summary>
    /// <returns>Integer value of health</returns>
    public int GetHealth(){
        return settings.health;
    }
}
