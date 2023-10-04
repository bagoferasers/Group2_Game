using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Rotates the enemy towards a target and shoots, if it is in range
/// </summary>
/// /// <remarks>
/// Authors: Ben Samuel
/// Date: September 29, 2023
/// </remarks>
public class EnemyAim : MonoBehaviour
{
    [Header("Object Assignments")]
    [SerializeField] BulletShoot bulletShoot;
    [SerializeField] Transform target;
    [Header("Aiming Settings")]
    [SerializeField] float aggroRange = 50f;
    [SerializeField] float turnSpeed = 10f;

    bool lockedOn;


    /// <summary>
    /// Handles physics updates
    /// </summary>
    void FixedUpdate(){
        Vector3 distance = transform.position - target.position;
        if(distance.sqrMagnitude <= aggroRange * aggroRange){
            LockOn();
            bulletShoot.Shoot(target.position);
        } else {
            lockedOn = false;
        }
    }
    /// <summary>
    /// Rotates the enemy towards the target
    /// </summary>
    void LockOn(){
        lockedOn = true;
        
        Vector3 rotatedVectorToTarget = Quaternion.Euler(0, 0, 0) * (target.position - transform.position);
        Quaternion targetRotation = Quaternion.LookRotation(forward: Vector3.forward, upwards: rotatedVectorToTarget);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
    }
}
