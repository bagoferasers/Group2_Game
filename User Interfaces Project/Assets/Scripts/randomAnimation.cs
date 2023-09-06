using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomAnimation : MonoBehaviour
{
    private Animator animator;
    private float randomNumber = 1.0f;

    void Start( )
    {
        randomNumber = Random.Range( 0.0f, 4.0f );
        animator = this.GetComponent< Animator >( );
        StartCoroutine( waitForAnimation( ) );
    }

    IEnumerator waitForAnimation( )
    {
        yield return new WaitForSeconds( randomNumber );
        animator.enabled = true;
    }
}
