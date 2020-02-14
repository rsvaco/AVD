using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl2D : MonoBehaviour
{
    private bool jump, crouch, run;

    public Animator animator;

    [SerializeField]
    private float horizontalMove = 0f, runSpeed = 1f;

    [SerializeField]
    private CharacterController2D controller;

    public float Gravity2D = -30f;


    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("jump");
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }

        if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }


        controller.Move(horizontalMove, crouch, jump);
    }


    void FixedUpdate()

    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false); 

    }

    public void OnCrouching(bool isCrouching)
    {
        //   animator.SetBool("IsCrouching", isCrouching);
    }

} 

