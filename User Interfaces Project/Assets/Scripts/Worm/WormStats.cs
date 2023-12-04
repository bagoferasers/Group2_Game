using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WormStats : MonoBehaviour
{
    //[SerializeField] LevelWin levelWin;
    [SerializeField] private FloatingHealthBar healthBar;
    public float maxHealth = 10.0f;
    public float health = 10.0f;
    private void Awake( ) 
    {
        healthBar = GetComponentInChildren< FloatingHealthBar >( );
        //levelWin.totalEnemies++;
        //Debug.Log(gameObject);
    }
    
    public void TakeDamage( float damageAmount )
    {
        //Debug.Log( "Enemy taking damage!" );
        health -= damageAmount;
        if( health <= 0 )
            Die( );
        healthBar.UpdateHealthbar( health, maxHealth );
    }

    public void Die( )
    {
        //levelWin.totalEnemies--;
        Destroy( this.gameObject );
    }
}