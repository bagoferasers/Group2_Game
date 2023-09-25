using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityManager : MonoBehaviour
{
    [SerializeField] int health;

    public void Hit(int damage){
        health -= damage;
        if(health <= 0){
            Die();
        }
    }

    void Die(){
        Destroy(gameObject);
    }

    int GetHealth(){
        return health;
    }
}
