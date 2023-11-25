using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject settingsMenu;

    GameObject activeMenu;

    void Start(){
        activeMenu = pauseMenu;
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            ToggleMenu(activeMenu);
        }
    }

    public void ToggleMenu(GameObject menu){
        bool active = menu.activeSelf;
        if(active){
            CloseMenu(menu);
            if(menu == pauseMenu){
                Time.timeScale = 1;
            }
        } else {
            OpenMenu(menu);
            Time.timeScale = 0;
        }
    }

    public void OpenMenu(GameObject menu){
        pauseMenu.SetActive(false);
        menu.SetActive(true);
        activeMenu = menu;
    }

    public void CloseMenu(GameObject menu){
        pauseMenu.SetActive(true);
        menu.SetActive(false);
        activeMenu = pauseMenu;
    }
}
