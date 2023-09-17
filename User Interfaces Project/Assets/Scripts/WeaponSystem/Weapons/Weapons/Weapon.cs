using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : ScriptableObject
{
    public PlayerConfig playerConfig;

    [Header("Behaviour Settings")]
    [SerializeField] protected int damage;
    [SerializeField] protected float fireRate;
    [SerializeField] protected float lifeSpan;

    [Header("Visual Settings")]
    [SerializeField] protected GameObject projectile;

    public virtual void Shoot(Vector3 target){

    }

    public float GetFireRate(){
        return fireRate;
    }

    public void SetFireRate(float fireRate){
        this.fireRate = fireRate;
    }
}
