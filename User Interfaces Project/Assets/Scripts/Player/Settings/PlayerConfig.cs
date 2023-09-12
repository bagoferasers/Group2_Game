using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// Container class for all player component references and script settings
/// </summary>
/// <remarks>
/// Authors: Ben Samuel
/// Date: September 11, 2023
/// </remarks>
public class PlayerConfig : MonoBehaviour
{
    [Header("Movement Scripts")]
    public LandMovement landMovement;
    public RopeMovement ropeMovement;
    public WaterMovement waterMovement;

    [Header("Input Scripts")]
    public InputSwitcher inputSwitcher;
    public PlayerInput input;

    [Header("Helper Scripts")]
    public RopeConnector ropeConnector;

    [Header("Object Assignments")]
    public Rigidbody2D body;
    public Transform groundCheck;
    public LayerMask layerMask;

    [Header("Land Movement")]
    public float moveForce = 5f;
    public float sprintMultiplier = 1.5f;
    public float jumpForce = 3.5f;
    public float dashForce = 2f;
    public float dashCooldown = .3f;

    [Header("Rope Movement")]
    public float upDelay = .3f;
    public float downDelay = .15f;
    public float swingForce = 5f;

    [Header("Water Movement")]
    public float swimForce = 5f;
    public float brakeForce = 2f;
    public float turnSpeed = 2f;
    public float boostMultiplier = 1.5f;
    public float strafeForce = 2f;
    public float strafeTurnMultipler = 3f;
    public float strafeCooldown = .3f;
    public float velocityDecay = .5f;
}