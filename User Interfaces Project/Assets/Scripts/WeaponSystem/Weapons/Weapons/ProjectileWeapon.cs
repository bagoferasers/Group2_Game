using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ProjectileWeapon : Weapon
{
    [Header("Projectile Settings")]
    [SerializeField] int shotForce;

    public override void Shoot(Vector3 target){
        Projectile newProjectile = Instantiate(
            projectile, playerConfig.gameObject.transform.position, Quaternion.LookRotation(projectile.transform.forward, target - playerConfig.gameObject.transform.position)
        ).GetComponent<Projectile>();

        newProjectile.SetDamage(damage);
        newProjectile.SetShotForce(shotForce);
        newProjectile.setLifeSpan(Time.time + lifeSpan);
    }
}
