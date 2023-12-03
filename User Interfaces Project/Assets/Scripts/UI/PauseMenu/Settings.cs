using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [Header("Audio Object Assignments")]
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider masterSlider;
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider sfxSlider;
    [Header("Resolution Object Assignments")]
    [SerializeField] Dropdown resolutionDropdown;
    [SerializeField] Toggle toggle;
    Resolution[] resolutions;

    void Awake(){
        //Audio
        if(PlayerPrefs.GetInt("Default Volume Changed") == 0){
            masterSlider.value = .1f;
            sfxSlider.value = .1f;
            musicSlider.value = .1f;
            PlayerPrefs.SetInt("Default Volume Changed",1);
        }else{
            masterSlider.value = PlayerPrefs.GetFloat("Master");
            musicSlider.value = PlayerPrefs.GetFloat("Music");
            sfxSlider.value = PlayerPrefs.GetFloat("SFX");
        }
        //Resolution
        resolutions = Screen.resolutions;

        bool setDefault = false;
        if(PlayerPrefs.GetInt("set default resolution") == 0){
            setDefault = true;
            PlayerPrefs.SetInt("set default resolution",1);
        }

        for(int i = 0; i<resolutions.Length; i++){
            string resolutionString = resolutions[i].width.ToString() + " x " + resolutions[i].height.ToString();
            resolutionDropdown.options.Add(new Dropdown.OptionData(resolutionString));
            if(setDefault && resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height){
                resolutionDropdown.value = i;
            }
        }
        toggle.isOn = PlayerPrefs.GetInt("fullscreen") == 0;
        resolutionDropdown.value = PlayerPrefs.GetInt("resolution selection");
    }

    

    void SetVolume(string name,Slider slider){
        PlayerPrefs.SetFloat(name,slider.value);

        float volume = Mathf.Log10(slider.value) * 20;
        if(slider.value == 0){
            volume = -80;
        }
        mixer.SetFloat(name,volume);
    }

     public void SetMasterVolume(){
        SetVolume("Master",masterSlider);
    }

    public void SetSFXVolume(){
        SetVolume("SFX",sfxSlider);
    }

    public void SetMusicVolume(){
        SetVolume("Music",musicSlider);
    }



    public void ChangeResolution(){
        Screen.SetResolution(resolutions[resolutionDropdown.value].width,resolutions[resolutionDropdown.value].height,toggle.isOn);
        PlayerPrefs.SetInt("resolution selection",resolutionDropdown.value);
    }

    public void ChangeFullscreen(){
        Screen.SetResolution(resolutions[resolutionDropdown.value].width,resolutions[resolutionDropdown.value].height,toggle.isOn);
        if(toggle.isOn){
            PlayerPrefs.SetInt("fullscreen",0);
        }else{
            //Debug.Log("fullscreen off");
            PlayerPrefs.SetInt("fullscreen",1);
        }
    }
}