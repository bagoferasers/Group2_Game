using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BeamWeapon : Weapon
{
    [Header("Projectile Settings")]
    [SerializeField] int range;

    public override void Shoot(Vector3 target){

    }
}
