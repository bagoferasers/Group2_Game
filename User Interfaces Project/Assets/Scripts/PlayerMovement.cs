using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [ Header( "Speed of Player:" ) ]
    public float speed = 0.1f;

    void Update( )
    {
        // calculate vector
        Vector3 moveHere = new Vector3( Input.GetAxis( "Horizontal" ), Input.GetAxis( "Vertical" ), 0.0f );
       
        // normalize diagonal movement
        moveHere.Normalize( ); 

        // move player
        transform.Translate( moveHere * speed * Time.deltaTime );
    }
}
