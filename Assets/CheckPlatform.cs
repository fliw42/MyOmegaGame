using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlatform : MonoBehaviour
{
    public GameObject canvas;
    // public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        #if UNITY_ANDROID
        canvas.SetActive(true);
        #elif UNITY_STANDALONE_WIN
        canvas.SetActive(false);
        #endif
        
        // animator.SetFloat("HorMove", 1);
    }
}
