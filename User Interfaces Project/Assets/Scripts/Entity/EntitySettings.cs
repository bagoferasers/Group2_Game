using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntitySettings : MonoBehaviour
{
    [Header("Object Assignments")]
    public Rigidbody2D body;
    public Transform sprite;
    public EntityManager entityManager;
    public BulletShoot bulletShoot;
    public GameObject bullet;
    [Header("Shoot Settings")]
    public int damage = 10;
    public float fireRate = 3;
    [Header("Entity Settings")]
    public int health;
}
