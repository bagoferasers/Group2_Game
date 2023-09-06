using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionSnake : MonoBehaviour
{
    private float randomDepth = 0.0f;
    private Animation snakeAnimation;
    private SpriteRenderer spriteRenderer;

    void Start( )
    {
        spriteRenderer = this.GetComponent< SpriteRenderer >( );
        snakeAnimation = this.GetComponent< Animation >( );
        randomDepth = Random.Range( 0.0f, -0.4f );
        this.transform.position = new Vector2( 0.0f, randomDepth );
        StartCoroutine( animateSnake( ) );
    }

    IEnumerator animateSnake( ) 
    {
        if( gameObject.name == "Snake(Clone)" )
        {
            spriteRenderer.color = new Color( spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 1 );
            yield return new WaitForSeconds( snakeAnimation.clip.length );
            spriteRenderer.color = new Color( spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, 0 );
            Destroy( this.gameObject );
        }
        yield return null;
    }
}