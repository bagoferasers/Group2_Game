using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [Header("Object Assignments")]
    [SerializeField] Transform sprite;
    [SerializeField] GameObject bullet;
    [Header("Shoot Settings")]
    [SerializeField] float fireRate = 3;



    float shootCooldown = 0;

    public void Shoot(Vector3 target){
        if(Time.time > shootCooldown){
            shootCooldown = Time.time + 1/fireRate;
            Bullet _bullet = Instantiate(bullet, sprite.position, Quaternion.identity).GetComponent<Bullet>();
            _bullet.SetDirection(target - sprite.transform.position);
            _bullet.Shoot();
        }
    }
}
