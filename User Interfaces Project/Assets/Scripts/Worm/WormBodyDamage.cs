using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormBodyDamage : MonoBehaviour
{
    [SerializeField] private WormStats wormStats;
    [SerializeField] private PlayerSettings settings;
    [SerializeField] private EntityManager entityManager;
    [SerializeField] private FloatingHealthBar floatingHealthBar;
    private int health;
    void Start( )
    {
        if( settings != null )
        {
            floatingHealthBar.UpdateHealthbar( settings.health, settings.maxHealth );            
        }
    }
    private void OnTriggerEnter2D( Collider2D other ) 
    {
        //Debug.Log( "Bullet collided with enemy!" );
        if( other.gameObject.name == "PlayerBullet(Clone)" )
        {
            int damage = other.gameObject.GetComponent< Bullet >( ).damage;
            //Destroy( other.gameObject );
            other.gameObject.SetActive(false);
            wormStats.TakeDamage( damageAmount: damage );
        }
        else if( other.gameObject.name == "Player" )
        {
            entityManager.Hit( 20 );
            floatingHealthBar.UpdateHealthbar( settings.health, settings.maxHealth );
        }
    }
}
