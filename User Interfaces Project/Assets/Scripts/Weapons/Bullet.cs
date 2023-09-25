using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public void Shoot()
    {
        body.AddForce(direction.normalized * speed, ForceMode2D.Impulse);
        DeathTimer();
    }

    public void SetDirection(Vector2 direction){
        this.direction = direction;
    }

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

    void OnCollisionEnter2D(Collision2D other){
        EntityManager entity = other.gameObject.GetComponent<EntityManager>();
        if(entity != null){
            entity.Hit(damage);
        }
        Destroy(gameObject);
    }
}
