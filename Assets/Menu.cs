using System.Collections;
using System.Collections.Generic;
using BinaryCharm.UI.TextColorButtons.Extensions;
using Cinemachine;
using UnityEditor.Rendering;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Cursor = UnityEngine.Cursor;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _menu;
    [SerializeField] private bool _open = false;
    [SerializeField] private CinemachineVirtualCamera _cameraFollow;
    [SerializeField] private Transform _transform;
    [SerializeField] private Button _continue;
    [SerializeField] private GameObject _settings;
    [SerializeField] private Button _settingsButton;
    [SerializeField] private Button _save;
    [SerializeField] private Button _exit;
    
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
    public void onClick()
    {
        _menu.SetActive(false);
    }

}
