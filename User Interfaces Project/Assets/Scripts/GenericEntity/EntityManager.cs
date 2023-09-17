using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityManager : MonoBehaviour, IDamagable
{
    [SerializeField] EntityConfig entityConfig;

    public void Hit(int damage){
        entityConfig.health -= damage;
        if(entityConfig.health <= 0) {
            Die();
        }
    }

    public void Die(){
        Destroy(entityConfig.gameObject);
    }
}
