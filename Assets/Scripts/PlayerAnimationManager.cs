using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour
{
    private Animator animator;
    private PlayerMovement movement;
    private Rigidbody rb;

    // Local grounded state (optional — you can calculate here if PlayerMovement doesn’t have one)
    public bool isGrounded;

    public void Start()
    {
        animator = GetComponent<Animator>();
        movement = GetComponent<PlayerMovement>();
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        // Use Unity's velocity, not "linearVelocity"
        animator.SetFloat("CharacterSpeed", rb.linearVelocity.magnitude);

        // Option 1: If PlayerMovement has isGrounded, use that
        // animator.SetBool("IsGrounded", movement.isGrounded);

        // Option 2: If not, calculate grounding here (simple raycast)
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f);
        animator.SetBool("IsGrounded", isGrounded);

        if (Input.GetButtonUp("Fire1"))
        {
            animator.SetTrigger("doRoll");
        }

        if (Input.GetButtonUp("Fire2"))
        {
            animator.SetTrigger("doPunch");
        }
    }
}