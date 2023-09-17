using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D body;

    int damage;
    int shotForce;
    float lifeSpan;

    void Start(){
        body = gameObject.GetComponent<Rigidbody2D>();
        body.AddForce(transform.up * shotForce, ForceMode2D.Impulse);
    }

    void FixedUpdate(){
        if(Time.time >= lifeSpan){
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other){
        EntityManager entityManager = other.gameObject.GetComponent<EntityManager>();
        if(entityManager != null){
            entityManager.Hit(damage);
        }
        Destroy(gameObject);
    }

    public int GetDamage(){
        return damage;
    }

    public void SetDamage(int damage){
        this.damage = damage;
    }

    public int GetShotForce(){
        return shotForce;
    }

    public void SetShotForce(int shotForce){
        this.shotForce = shotForce;
    }

    public float GetLifeSpan(){
        return lifeSpan;
    }

    public void setLifeSpan(float lifeSpan){
        this.lifeSpan = lifeSpan;
    }
}
