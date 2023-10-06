using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the fading of a light2DGroup component for kelp interaction.
/// </summary>
/// <remarks>
/// Authors: Colby Bailey
/// Date: October 06, 2023
/// </remarks>
public class KelpMove : MonoBehaviour
{
    public UnityEngine.Rendering.Universal.Light2D light2D;    
    
    [ Header( "Insert fade time:" ) ]
    public float time = 15.0f;
    public float lightIntensity = 1.0f;

    void Start( ) 
    {
        light2D.intensity = 0;
    }

    /// <summary>
    /// When player enters kelp collider, show light.
    /// </summary>
    /// <param name="other">The player Collider2D that entered the trigger.</param>
    private void OnTriggerEnter2D( Collider2D other )
    {
        // Check if the player entered the trigger.
        if ( other.CompareTag( "Player" ) )
        {
            // Player has moved through the kelp. You can add your custom logic here.
            Debug.Log( "Player moved into the kelp!" );
            showLight( time );
        }
    }

    /// <summary>
    /// Shows the light2 intensity with a fade-in effect.
    /// </summary>
    /// <param name="fadeTime">The duration of the fade-in effect.</param>
    public void showLight( float fadeTime )
    {
        if( light2D.intensity == 0 )
            StartCoroutine( fadeIn( fadeTime ) );
    }

    /// <summary>
    /// Hides the light2 intensity with a fade-out effect.
    /// </summary>
    /// <param name="fadeTime">The duration of the fade-out effect.</param>
    public void hideLight( float fadeTime )
    {
        if( light2D.intensity == lightIntensity )
            StartCoroutine( fadeOut( fadeTime ) );
    }

    /// <summary>
    /// Fades in the light2 intensity with the specified duration.
    /// </summary>
    /// <param name="fadeTime">The duration of the fade-in effect.</param>
    IEnumerator fadeIn( float fadeTime )
    {
        while( light2D.intensity < lightIntensity )
        {
            light2D.intensity += fadeTime * ( Time.fixedDeltaTime / 2 );
            yield return null;
        }
        light2D.intensity = lightIntensity;
        hideLight( time );
        yield return null;
    } 

    /// <summary>
    /// Fades out the light2 intensity with the specified duration.
    /// </summary>
    /// <param name="fadeTime">The duration of the fade-out effect.</param>
    IEnumerator fadeOut( float fadeTime )
    {
        while( light2D.intensity > 0 )
        {
            light2D.intensity -= fadeTime * ( Time.fixedDeltaTime / 2 );
            yield return null;
        }
        light2D.intensity = 0;
        yield return null;
    }
}