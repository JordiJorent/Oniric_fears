using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuSettings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public TMP_Dropdown resolutionDropdown;

    private float saveVolumeValue = 0f;
    private float saveSens = 2f;

    public float mouseSensitivity = 2f;
    private bool isInverted = false;

    Resolution[] resolutions;

    // GAMEOBJECTS DE LOS BOTONES DE LA UI
    public Toggle invertMouse;
    public Slider volumeSlider;
    public Slider sensSlider;
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        saveVolumeValue = volume;
    }

    public void SetSensitivity(float sens)
    {
        if(isInverted)
        {
            mouseSensitivity = -sens;
        }
        else
        {
            mouseSensitivity = sens;
        }
        saveSens = mouseSensitivity;
    }
    public void SetFullscreen(bool isFullsrceen)
    {
        Screen.fullScreen = isFullsrceen;
    }
    void Start()
    {
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void InvertAxis()
    {
        if(mouseSensitivity < 0) // esta invertido
        {
            isInverted = true;
        }
        else
        {
            isInverted = false;
        }
        mouseSensitivity = -mouseSensitivity;
    }

    private void OnEnable()
    {
        invertMouse.isOn = isInverted;
        volumeSlider.value = saveVolumeValue;
        sensSlider.value = saveSens;
    }
}
