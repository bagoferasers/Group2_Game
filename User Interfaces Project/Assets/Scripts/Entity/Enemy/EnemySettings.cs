using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySettings : EntitySettings
{
    [Header("Object Assignments")]
    public Transform target;
    [Header("AI Settings")]
    public float aggroRange = 0.5f;
    [Header("Aiming Settings")]
    public float turnSpeed = 10f;

    bool lineOfSight = false;

    void Awake(){
        target = GameObject.FindWithTag("Player").transform;
    }

    public bool GetLineOfSight(){
        return lineOfSight;
    }

    public void SetLineOfSight(bool lineOfSight){
        this.lineOfSight = lineOfSight;
    }
}
