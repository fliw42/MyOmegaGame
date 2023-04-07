using System.Collections;
using System.Collections.Generic;
using BinaryCharm.UI.TextColorButtons.Extensions;
using Cinemachine;
using UnityEditor.Rendering;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using Cursor = UnityEngine.Cursor;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _menu;
    [SerializeField] private bool _open = false;
    [SerializeField] private CinemachineVirtualCamera _cameraFollow;
    [SerializeField] private Transform _transform;
    [SerializeField] private Button _continue;
    [Space]
    [Header("Settings")]
    [SerializeField] private Image _settingsContent;
    [SerializeField] private Button _settingsButton;
    [Space]
    [Header("Save")]
    [SerializeField] private Button _save;
    [Space]
    [Header("Exit")]
    [SerializeField] private Button _exit;
    [SerializeField] private Slider _slider;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_open == false)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                _menu.SetActive(true);
                _open = true;
                Time.timeScale = 0;
                _cameraFollow.enabled = false;
            }
            else
            {
                _menu.SetActive(false);
                _open = false;
                Time.timeScale = 1;
                _cameraFollow.enabled = true;
            }
        }
    }

    private void OnEnable()
    {
        _settingsButton.onClick.AddListener(Button_SettingsClicked);
        _settingsContent.gameObject.SetActive(false);
        _slider.onValueChanged.AddListener(Slider_OnValueChanged);
        _slider.value = AudioListener.volume;
    }
    private void Button_SettingsClicked()
    {
        _settingsContent.gameObject.SetActive(!_settingsContent.gameObject.activeSelf);
        _menu.SetActive(false);
        
    }

    private void Slider_OnValueChanged(float value)
    {
        AudioListener.volume = value;
    }

}
