using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Handles movement and parameters of bullet objects
/// </summary>
/// /// <remarks>
/// Authors: Ben Samuel
/// Date: September 29, 2023
/// </remarks>
public class Bullet : MonoBehaviour
{
    [Header("Object Assignments")]
    [SerializeField] Rigidbody2D body;
    [SerializeField] BoxCollider2D hitbox;
    [Header("Bullet Settings")]
    [SerializeField] int damage;
    [SerializeField] float speed;
    [SerializeField] float lifeSpan = 2f;

    Vector2 direction;
    /// <summary>
    /// Fires the bullet
    /// </summary>
    public void Shoot()
    {
        body.AddForce(direction.normalized * speed, ForceMode2D.Impulse);
        DeathTimer();
    }
    /// <summary>
    /// Destroys the bullet after a few seconds
    /// </summary>
    void DeathTimer(){
        StartCoroutine(DeathTimerRoutine());

        IEnumerator DeathTimerRoutine(){
            float timer = 0;
            while(timer < lifeSpan){
                timer += Time.deltaTime;
                yield return null;
            }
            Destroy(gameObject);
            yield return null;
        }
    }
    /// <summary>
    /// Handles collisions
    /// </summary>
    /// <param name="other">Collision2D of the object that was collided with</param>
    void OnCollisionEnter2D(Collision2D other){
        EntityManager entity = other.gameObject.GetComponent<EntityManager>();
        if(entity != null){
            entity.Hit(damage);
        }
        Destroy(gameObject);
    }
    /// <summary>
    /// Setter for the bullet's damage
    /// </summary>
    /// <param name="damage">Integer representing the damage</param>
    public void SetDamage(int damage){
        this.damage = damage;
    }
    /// <summary>
    /// Setter for the bullet's direction
    /// </summary>
    /// <param name="direction">Vector2 repsenting direction to be shot in</param>
    public void SetDirection(Vector2 direction){
        this.direction = direction;
    }
}
