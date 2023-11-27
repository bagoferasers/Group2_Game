using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WormStats : MonoBehaviour
{
    [SerializeField] private FloatingHealthBar healthBar;
    public float maxHealth = 10.0f;
    public float health = 10.0f;
    private void Awake( ) 
    {
        healthBar = GetComponentInChildren< FloatingHealthBar >( );
    }
    
    public void TakeDamage( float damageAmount )
    {
        Debug.Log( "Enemy taking damage!" );
        health -= 2;
        if( health <= 0 )
            Die( );
        healthBar.UpdateHealthbar( health, maxHealth );
    }

    public void Die( )
    {
        Destroy( this.gameObject );
    }
}