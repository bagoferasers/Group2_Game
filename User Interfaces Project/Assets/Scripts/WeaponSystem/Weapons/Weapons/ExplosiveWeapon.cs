using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ExplosiveWeapon : Weapon
{
    [Header("Projectile Settings")]
    [SerializeField] int travelSpeed;
    [SerializeField] int force;
    [SerializeField] float radius;

    public override void Shoot(Vector3 target){

    }
}
