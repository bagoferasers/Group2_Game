using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject settingsMenu;
    [SerializeField] GameObject instructionText;

    GameObject activeMenu;

    void Start(){
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(false);
        instructionText.SetActive(false);
        ToggleMenu(instructionText);
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
            if(menu == pauseMenu || instructionText){
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
        if(menu != instructionText){
            pauseMenu.SetActive(true);
        }
        menu.SetActive(false);
        activeMenu = pauseMenu;
    }
}
