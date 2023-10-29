using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// Controls the AIStates of the Worm
/// </summary>
/// <remarks>
/// Authors: Colby Bailey
/// Date: October 29, 2023
/// </remarks>
public class moveWorm : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 1.0f;
    public bool rotating = false;
    public GameObject[] gameObjects;
    public float speed = 1.0f;

    private bool rotateRight = false;

    public enum AIState 
    {
        Idle,
        Chasing
    }

    private AIState currentState = AIState.Idle;

    void Start( )
    {
        if( target == null )
        {
            Debug.Log( "target is null in moveWorm.cs");
            Application.Quit( );
        }
    }
    void LateUpdate( )
    {
        switch( currentState )
        {
            case AIState.Idle:
                //
                //
                break;
            case AIState.Chasing:
                moveWormHere( );
                RotateJaws( );
                break;
            default:
                Debug.Log( "Could not set AIState in moveWorm.cs" );
                Application.Quit( );
                break;
        }
    }

    private void OnTriggerEnter2D( Collider2D other )
    {
        // Debug.Log( "Entered worm territory!" );
        if( other.CompareTag( "Player" ) )
        {
            currentState = AIState.Chasing;
            rotating = true;
        }
    }

    private void OnTriggerExit2D( Collider2D other ) 
    {
        // Debug.Log( "Exited worm territory!" );
        if( other.CompareTag( "Player" ) )
        {
            currentState = AIState.Idle;
            rotating = false;
        }
    }

    private void moveWormHere( )
    {
        Vector3 desiredPosition = new Vector3( target.position.x, target.position.y, transform.position.z );
        transform.position = Vector3.MoveTowards( transform.position, desiredPosition, smoothSpeed * Time.deltaTime );      
    }

    private void RotateJaws( )
    {
        if( rotating )
        {
            rotateRight = false;
            foreach( var item in gameObjects )
            {
                if( rotateRight )
                {
                    item.transform.Rotate( Vector3.forward * speed * Time.deltaTime );
                    rotateRight = false;
                }
                else 
                {
                    item.transform.Rotate( Vector3.back * speed * Time.deltaTime );
                    rotateRight = true;
                }
            }
        }
        else
        {
            Debug.Log( "Can't rotate jaws in RotateJaws.cs" );
            Application.Quit( );
        }
    }
}
