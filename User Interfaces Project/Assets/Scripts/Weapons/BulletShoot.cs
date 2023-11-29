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
    [SerializeField] EntitySettings settings;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;

    float shootCooldown = 0;



    /// <summary>
    /// Shoots towards the given target
    /// </summary>
    /// <param name="target">Vector3 representing the target to be shot</param>
    public void Shoot(Vector3 target){
        if(Time.time > shootCooldown){
            audioSource.PlayOneShot(audioClip);
            shootCooldown = Time.time + 1/settings.fireRate;
            Bullet _bullet = Instantiate(settings.bullet, settings.sprite.position, Quaternion.identity).GetComponent<Bullet>();
            _bullet.SetDirection(target - settings.sprite.transform.position);
            _bullet.SetDamage(settings.damage);
            _bullet.Shoot();
        }
    }
    /// <summary>
    /// Getter for the fire rate setting
    /// </summary>
    /// <returns>Float representing the fire rate</returns>
    float GetFireRate(){
        return settings.fireRate;
    }
}
