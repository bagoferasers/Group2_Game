using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CircleLights : MonoBehaviour
{
    private UnityEngine.Rendering.Universal.Light2D light2D;
    public float speed = 1.0f;
    public float radius = 1.0f;
    private Vector2 center;
    
    void Start( )
    {
        light2D = this.GetComponent< UnityEngine.Rendering.Universal.Light2D >( );
        center = light2D.transform.position;
    }

    void Update( )
    {
        Vector2 newPos = center * new Vector2( Mathf.Cos( speed * Time.time ), Mathf.Sin( speed * Time.time ) ) * radius;
        light2D.transform.position = newPos;
    }
}
