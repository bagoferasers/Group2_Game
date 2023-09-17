using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityConfig : MonoBehaviour
{
    [Header("Stats")]
    public int health = 100;

    [Header("Available Weapons")]
    public Weapon[] weapons;
    public Weapon activeWeapon;
}
