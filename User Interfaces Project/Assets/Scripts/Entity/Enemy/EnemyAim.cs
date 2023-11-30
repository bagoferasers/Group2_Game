using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Rotates the enemy towards a target and shoots, if it is in range
/// </summary>
/// /// <remarks>
/// Authors: Ben Samuel
/// Date: November 26, 2023
/// </remarks>
public class EnemyAim : MonoBehaviour
{
    [SerializeField] EnemySettings settings;

    //[SerializeField] LayerMask layerMask;


    /// <summary>
    /// Handles physics updates
    /// </summary>
    void FixedUpdate(){
        Vector3 distance = transform.position - settings.target.position;
        //RaycastHit2D lineOfSight = Physics2D.Raycast(transform.position, transform.up, settings.aggroRange, layerMask);
        //Debug.Log(lineOfSight.collider);
        if(distance.sqrMagnitude <= settings.aggroRange * settings.aggroRange){ //&& lineOfSight.collider == null){
            //settings.SetLineOfSight(true);
            LockOn();
            settings.bulletShoot.Shoot(settings.target.position);
        /*} else {
            settings.SetLineOfSight(false);
        */
        }
    }
    /// <summary>
    /// Rotates the enemy towards the target
    /// </summary>
    void LockOn(){
        Vector3 rotatedVectorToTarget = Quaternion.Euler(0, 0, 0) * (settings.target.position - transform.position);
        Quaternion targetRotation = Quaternion.LookRotation(forward: Vector3.forward, upwards: rotatedVectorToTarget);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, settings.turnSpeed * Time.deltaTime);
    }
}
