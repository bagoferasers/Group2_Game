using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Handles the shooting action of entities
/// </summary>
/// /// <remarks>
/// Authors: Ben Samuel
/// Date: September 29, 2023
/// </remarks>
public class BulletShoot : MonoBehaviour
{
    [Header("Object Assignments")]
    [SerializeField] Transform sprite;
    [SerializeField] GameObject bullet;
    [Header("Shoot Settings")]
    [SerializeField] int damage = 10;
    [SerializeField] float fireRate = 3;



    float shootCooldown = 0;
    /// <summary>
    /// Shoots towards the given target
    /// </summary>
    /// <param name="target">Vector3 representing the target to be shot</param>
    public void Shoot(Vector3 target){
        if(Time.time > shootCooldown){
            shootCooldown = Time.time + 1/fireRate;
            Bullet _bullet = Instantiate(bullet, sprite.position, Quaternion.identity).GetComponent<Bullet>();
            _bullet.SetDirection(target - sprite.transform.position);
            _bullet.SetDamage(damage);
            _bullet.Shoot();
        }
    }
    /// <summary>
    /// Getter for the fire rate setting
    /// </summary>
    /// <returns>Float representing the fire rate</returns>
    float GetFireRate(){
        return this.fireRate;
    }
}
