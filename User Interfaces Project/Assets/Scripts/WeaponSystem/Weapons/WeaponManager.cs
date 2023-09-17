using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] PlayerConfig playerConfig;

    int weaponTracker;

    Vector3 cursorPosition;

    bool canShoot = true;

    void Start(){
        weaponTracker = 0;
        playerConfig.activeWeapon = playerConfig.weapons[weaponTracker];
        foreach(Weapon weapon in playerConfig.weapons){
            weapon.playerConfig = playerConfig;
        }
    }

    public void SwitchWeapon(int input){
        weaponTracker += input/120;
        if(weaponTracker >= playerConfig.weapons.Length){
            weaponTracker = 0;
        } else if(weaponTracker < 0){
            weaponTracker = playerConfig.weapons.Length - 1;
        }
        playerConfig.activeWeapon = playerConfig.weapons[weaponTracker];
        Debug.Log(playerConfig.activeWeapon);
    }

    public void Shoot(){
        if(canShoot){
            FireRateHandler();
            playerConfig.activeWeapon.Shoot(cursorPosition);
        }
    }

    void FireRateHandler(){
        StartCoroutine(FireRateHandlerRoutine());

        IEnumerator FireRateHandlerRoutine(){
            canShoot = false;
            yield return new WaitForSeconds(1 / playerConfig.activeWeapon.GetFireRate());
            canShoot = true;
        }
    }

    public void Aim(Vector2 mousePosition){
        cursorPosition = Camera.main.ScreenToWorldPoint(mousePosition);
    }

    public Vector3 GetCursorPosition(){
        return cursorPosition;
    }
}
