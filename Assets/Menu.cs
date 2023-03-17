using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEditor.Rendering;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _menu;
    [SerializeField] private bool _open = false;
    [SerializeField] private CinemachineVirtualCamera _cameraFollow;
    [SerializeField] private Transform _transform;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_open == false)
            {
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
}
