using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Object Assignments")]
    [SerializeField] Rigidbody2D body;
    [SerializeField] Transform sprite;
    [Header("Movement Settings")]
    [SerializeField] float speed = 5f;

    Vector2 direction;



    public void Move(int x, int y){
        direction = new Vector2(x, y);
        SetRotation();
        body.velocity = direction * speed * Time.deltaTime;
    }

    public void SetRotation(){
        float angle = Vector2.SignedAngle(transform.up, direction);
        sprite.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
