using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSettings : MonoBehaviour
{
    [Header("Object Assignments")]
    public PlayerMovement playerMovement;
    public BulletShoot bulletShoot;
    public EntityManager entityManager;
    public Rigidbody2D body;
    public Transform sprite;
    public GameObject bullet;
    [Header("Movement Settings")]
    public float speed = 5f;
    [Header("Shoot Settings")]
    public int damage = 10;
    public float fireRate = 3;
    [Header("Breath Settings")]
    public float breathSeconds = 180f;
    public int drownDamage = 5;
    public float drownRate = 1f;
    [Header("Entity Settings")]
    public int health;
}
