using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySettings : EntitySettings
{
    [Header("Object Assignments")]
    public Transform target;
    [Header("AI Settings")]
    public int aggroRange = 1;
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
