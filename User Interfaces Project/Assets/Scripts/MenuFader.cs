using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controls the fading of a CanvasGroup component for menu transitions.
/// </summary>
/// <remarks>
/// Authors: Colby Bailey
/// Date: September 11, 2023
/// </remarks>
public class MenuFader : MonoBehaviour
{
    /// <summary>
    /// Gets the CanvasGroup component for fading.
    /// </summary>
    public CanvasGroup Canvas
    {
        get 
        {
            return this.GetComponent< CanvasGroup >( );
        }
    }

    [ Header( "Insert fade time:" ) ]
    public float time = 4.0f;

    void Start( )
    {
        showCanvas( time );
    }

    /// <summary>
    /// Shows the CanvasGroup with a fade-in effect.
    /// </summary>
    /// <param name="fadeTime">The duration of the fade-in effect.</param>
    public void showCanvas( float fadeTime )
    {
        if( Canvas.alpha == 1 )
            StartCoroutine( fadeIn( fadeTime ) );
    }

    /// <summary>
    /// Hides the CanvasGroup with a fade-out effect.
    /// </summary>
    /// <param name="fadeTime">The duration of the fade-out effect.</param>
    public void hideCanvas( float fadeTime )
    {
        if( Canvas.alpha == 0 )
            StartCoroutine( fadeOut( fadeTime ) );
    }

    /// <summary>
    /// Fades in the CanvasGroup with the specified duration.
    /// </summary>
    /// <param name="fadeTime">The duration of the fade-in effect.</param>
    IEnumerator fadeIn( float fadeTime )
    {
        while( Canvas.alpha > 0 )
        {
            Canvas.alpha -= fadeTime * ( Time.fixedDeltaTime / 2 );
            yield return null;
        }
        Canvas.interactable = false;
        yield return null;
    } 

    /// <summary>
    /// Fades out the CanvasGroup with the specified duration.
    /// </summary>
    /// <param name="fadeTime">The duration of the fade-out effect.</param>
    IEnumerator fadeOut( float fadeTime )
    {
        while( Canvas.alpha < 1 )
        {
            Canvas.alpha += fadeTime * ( Time.fixedDeltaTime / 2 );
            yield return null;
        }
        Canvas.interactable = false;
        yield return null;
    }
}
