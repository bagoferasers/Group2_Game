using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateSnakes : MonoBehaviour
{
    private GameObject snake;
    private float randomTime;

    void Start( )
    {
        snake = GameObject.Find( "Snake" );
        StartCoroutine( waitThisAmount( ) );
    }

    IEnumerator waitThisAmount( )
    {
        while( true )
        {
            Instantiate( snake, this.transform.position, Quaternion.identity );
            randomTime = Random.Range( 10.0f, 30.0f );
            yield return new WaitForSeconds( randomTime );
        }
        yield return null;
    }
}
