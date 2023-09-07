using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveVampireFish : MonoBehaviour
{
    private float floatHeight = 0.01f;
    private Vector3 startPos;

    void Start( )
    {
        startPos = this.transform.position;
    }

    void Update( )
    {
        float newY = startPos.y + Mathf.Sin( Time.time * 1.0f ) * floatHeight;
        this.transform.position = new Vector3( this.transform.position.x, newY, this.transform.position.z );
    }
}
