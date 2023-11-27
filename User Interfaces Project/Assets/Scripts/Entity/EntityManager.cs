using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Manages the stats and status of any entity objects
/// </summary>
/// /// <remarks>
/// Authors: Ben Samuel
/// Date: September 29, 2023
/// </remarks>
public class EntityManager : MonoBehaviour
{
    [SerializeField] EntitySettings settings;

    [SerializeField] private SceneTransition sceneTransition;
    /// <summary>
    /// Reduces entity's health
    /// </summary>
    /// <param name="damage">Amount to reduce health by</param>
    public void Hit(int damage){
        settings.health -= damage;
        if(settings.health <= 0){
            Die();
            sceneTransition.Credits( );
        }
    }
    /// <summary>
    /// Kills the entity
    /// </summary>
    public void Die(){
        Destroy(gameObject);
    }
    /// <summary>
    /// Getter for entity's health
    /// </summary>
    /// <returns>Integer value of health</returns>
    public int GetHealth(){
        return settings.health;
    }
}
