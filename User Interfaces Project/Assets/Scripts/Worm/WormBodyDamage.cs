using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormBodyDamage : MonoBehaviour
{
    [SerializeField] private WormStats wormStats;
    private void OnTriggerEnter2D( Collider2D other ) 
    {
        Debug.Log( "Bullet collided with enemy!" );
        if( other.gameObject.name == "PlayerBullet(Clone)" )
        {
            int damage = other.gameObject.GetComponent< Bullet >( ).damage;
            Destroy( other.gameObject );
            wormStats.TakeDamage( damageAmount: damage );
            if( wormStats.health <= 0 )
                wormStats.Die( );
        }
    }
}
