using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySettings : EntitySettings
{
    [Header("Object Assignments")]
    public Transform target;
    public EnemyMovement movement;
    [Header("Movement Settings")]
    public float speed = 1;
    [Header("AI Settings")]
    public int aggroRange = 1;
    [Header("Aiming Settings")]
    public float turnSpeed = 10f;

    void Awake(){
        target = GameObject.FindWithTag("Player").transform;
    }
}
