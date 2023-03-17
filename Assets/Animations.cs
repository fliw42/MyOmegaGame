using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public CharacterController characterController;
    public Animator animator;
    
    
    private void Update()
    {
        Vector3 velocity = characterController.velocity;
        animator.SetFloat("HorMove", velocity.x * transform.forward.x);
        animator.SetFloat("VerMove", velocity.z * transform.forward.z);
    }
}
