using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;


public class Animations : MonoBehaviour
{
    public CharacterController characterController;
    public Animator animator;
    private bool _isJump;
    
    
    private void Update()
    {
        Vector3 velocity = characterController.velocity;
        animator.SetFloat("HorMove", velocity.x * transform.forward.x);
        animator.SetFloat("VerMove", velocity.z * transform.forward.z);

        // if (Input.GetKeyDown(KeyCode.Space) && thirdPersonController.Grounded)
        // {
        //     animator.SetTrigger("Jump");
        //     // _isJump = true;
        //     // StartCoroutine(JumpTimer());
        // }
    }

    IEnumerator JumpTimer()
    {
        yield return new WaitForSeconds(2.07f);
        _isJump = false;
    }
}
